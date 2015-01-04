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
	public partial class BudgetManager : Form {
		private static decimal ParseMoney(object o) {
			if (o == null) return 0;
			string s = o.ToString().Replace("$", "");
			if (string.IsNullOrWhiteSpace(s)) return 0;
			return decimal.Parse(s);
		}

		private int grant_id;
		private object oldcellvalue;

		public BudgetManager(int grant_id) {
			InitializeComponent();

			this.grant_id = grant_id;

			using (var db = new DataClasses1DataContext()) {
				foreach (budget_item b in db.budget_items.Where(d => d.grant_id == grant_id).OrderBy(d => d.sort_order)) {
					int i = dataGridView1.Rows.Add();
					dataGridView1.Rows[i].SetValues(b.budget_item_id, b.name, b.amount == 0 ? "" : b.amount.ToString("$0.00"));
				}
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
						budget_item b = db.budget_items.Single(f => f.budget_item_id == id);

						string oldname = b.name;
						decimal oldamount = b.amount;

						b.name = row.Cells[1].Value.ToString();
						b.amount = ParseMoney(row.Cells[2].Value);

						if (oldname != b.name || oldamount != b.amount) {
							db.changelogs.InsertOnSubmit(new changelog {
								object_edited = "budget for grant " + grant_name,
								username = Login.currentUser,
								date = DateTime.Now,
								details = string.Format("Budget item edited ({0} {1} -> {2} {3})", oldname, oldamount, b.name, b.amount)
							});
						}
					} else {
						var b = new budget_item {
							grant_id = this.grant_id,
							name = (row.Cells[1].Value ?? "").ToString(),
							amount = ParseMoney(row.Cells[2].Value)
						};
						db.budget_items.InsertOnSubmit(b);

						db.changelogs.InsertOnSubmit(new changelog {
							object_edited = "budget for grant " + grant_name,
							username = Login.currentUser,
							date = DateTime.Now,
							details = string.Format("Budget item added ({0} {1})", b.name, b.amount)
						});
					}
				}

				foreach (budget_item d in db.budget_items.Where(f => f.grant_id == grant_id && !ids.ToArray().Contains(f.budget_item_id))) {
					db.budget_items.DeleteOnSubmit(d);
					db.changelogs.InsertOnSubmit(new changelog {
						object_edited = "budget for grant " + grant_name,
						username = Login.currentUser,
						date = DateTime.Now,
						details = string.Format("Budget item removed ({0} {1})", d.name, d.amount)
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
				case 2:
					string val = (newcellvalue ?? "0").ToString().Replace("$", "");
					if (val == "") val = "0";
					decimal d;
					if (decimal.TryParse(val, out d)) {
						dataGridView1[e.ColumnIndex, e.RowIndex].Value = d == 0 ? "" : d.ToString("$0.00");
					} else {
						dataGridView1[e.ColumnIndex, e.RowIndex].Value = oldcellvalue;
					}
					break;
			}
		}
	}
}
