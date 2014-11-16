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

		public TimelineManager(int grant_id) {
			InitializeComponent();

			this.grant_id = grant_id;

			this.ColorCol.Items.Clear();
			this.ColorCol.Items.AddRange(Enum.GetNames(typeof(KnownColor)));

			using (var db = new DataClasses1DataContext()) {
				foreach (timeline_date d in db.timeline_dates.Where(d => d.grant_id == grant_id).OrderBy(d => d.date)) {
					int i = dataGridView1.Rows.Add();
					dataGridView1.Rows[i].SetValues(d.timeline_date_id, d.date.ToString("d"), d.name, d.color);
					dataGridView1.Rows[i].Cells[4].Style.BackColor = Color.FromName(d.color);
				}
			}

			dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
			dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
		}

		void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e) {
			if (this.dataGridView1.IsCurrentCellDirty) {
				// This fires the cell value changed handler below
				dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
			if (e.ColumnIndex == 3) {
				dataGridView1.Rows[e.RowIndex].Cells[4].Style.BackColor = Color.FromName(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
			}
		}

		private void Save_Click(object sender, EventArgs e) {
			using (var db = new DataClasses1DataContext()) {
				for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) {
					var row = dataGridView1.Rows[i];

					int tmp;
					if (row.Cells[0].Value != null && int.TryParse(row.Cells[0].Value.ToString(), out tmp)) {
						timeline_date d = db.timeline_dates.Single(f => f.timeline_date_id == tmp);
						d.date = DateTime.Parse(row.Cells[1].Value.ToString());
						d.name = row.Cells[2].Value.ToString();
						d.color = row.Cells[3].Value.ToString();
					} else {
						var d = new timeline_date {
							date = DateTime.Parse(row.Cells[1].Value.ToString()),
							grant_id = this.grant_id,
							name = row.Cells[2].Value.ToString(),
							color = row.Cells[3].Value.ToString()
						};
						db.timeline_dates.InsertOnSubmit(d);
					}
				}
				db.SubmitChanges();
			}
		}
	}
}
