using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrantApp {
	public partial class TimelineManager : Form {
		private int grant_id;
		private object oldcellvalue;

		public TimelineManager(int grant_id) {
			InitializeComponent();

			this.grant_id = grant_id;

			this.ColorCol.Items.Clear();
			for (KnownColor c = KnownColor.AliceBlue; c <= KnownColor.YellowGreen; c++) {
				this.ColorCol.Items.Add(c.ToString("G"));
			}

			using (var db = new DataClasses1DataContext()) {
				lblGrantName.Text = db.grants.Single(g => g.grant_id == grant_id).grant_name;
				foreach (timeline_date d in db.timeline_dates.Where(d => d.grant_id == grant_id).OrderBy(d => d.date)) {
					int i = dataGridView1.Rows.Add();
					dataGridView1.Rows[i].SetValues(d.timeline_date_id, d.date.ToString("d"), d.name, d.color);
					SetRowColor(i, Color.FromName(d.color));
				}
			}

			dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
			dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
		}

		private void SetRowColor(int i, Color c) {
			dataGridView1.Rows[i].Cells[4].Style.BackColor = c;
			dataGridView1.Rows[i].Cells[4].Style.SelectionBackColor = c;
		}

		void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e) {
			if (this.dataGridView1.IsCurrentCellDirty) {
				// This fires the cell value changed handler below
				dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
			if (e.ColumnIndex == 3) {
				SetRowColor(e.RowIndex, Color.FromName(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()));
			}
		}

		private void Save_Click(object sender, EventArgs e) {
			using (var db = new DataClasses1DataContext()) {
				string grant_name = db.grants.Where(g => g.grant_id == grant_id).Select(g => g.grant_name).Single();

				HashSet<int> ids = new HashSet<int>();
				for (int i = 0; i < dataGridView1.Rows.Count; i++) {
					var row = dataGridView1.Rows[i];
					if (row.IsNewRow) continue;

					int id;
					if (row.Cells[0].Value != null && int.TryParse(row.Cells[0].Value.ToString(), out id)) {
						ids.Add(id);
						timeline_date d = db.timeline_dates.Single(f => f.timeline_date_id == id);

						string oldname = d.name;
						DateTime olddate = d.date;

						d.date = DateTime.Parse(row.Cells[1].Value.ToString());
						d.name = row.Cells[2].Value.ToString();
						d.color = row.Cells[3].Value.ToString();

						if (oldname != d.name || olddate != d.date) {
							db.changelogs.InsertOnSubmit(new changelog {
								object_edited = "timeline for grant " + grant_name,
								username = Login.currentUser,
								date = DateTime.Now,
								details = string.Format("Date edited ({0} {1} -> {2} {3})", oldname, olddate, d.name, d.date)
							});
						}
					} else {
						var d = new timeline_date {
							date = DateTime.Parse((row.Cells[1].Value ?? new DateTime(1900, 1, 1)).ToString()),
							grant_id = this.grant_id,
							name = (row.Cells[2].Value ?? "").ToString(),
							color = (row.Cells[3].Value ?? "Yellow").ToString()
						};
						db.timeline_dates.InsertOnSubmit(d);

						db.changelogs.InsertOnSubmit(new changelog {
							object_edited = "timeline for grant " + grant_name,
							username = Login.currentUser,
							date = DateTime.Now,
							details = string.Format("Date added ({0} {1})", d.name, d.date)
						});
					}
				}

				foreach (timeline_date d in db.timeline_dates.Where(f => f.grant_id == grant_id && !ids.ToArray().Contains(f.timeline_date_id))) {
					db.timeline_dates.DeleteOnSubmit(d);
					db.changelogs.InsertOnSubmit(new changelog {
						object_edited = "timeline for grant " + grant_name,
						username = Login.currentUser,
						date = DateTime.Now,
						details = string.Format("Date removed ({0} {1})", d.name, d.date)
					});
				}
				db.SubmitChanges();
			}
			this.Close();
		}

		private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) {
			oldcellvalue = dataGridView1[e.ColumnIndex, e.RowIndex].Value;
		}

		private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
			object newcellvalue = dataGridView1[e.ColumnIndex, e.RowIndex].Value;
			switch (e.ColumnIndex) {
				case 1:
					DateTime dt;
					if (DateTime.TryParse(newcellvalue + "", out dt)) {
						dataGridView1[e.ColumnIndex, e.RowIndex].Value = dt.ToString("d");
					} else {
						dataGridView1[e.ColumnIndex, e.RowIndex].Value = oldcellvalue;
					}
					break;
			}
		}

		private void lblGrantName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			new AddGrant(this.grant_id).ShowDialog(this);
		}
	}
}
