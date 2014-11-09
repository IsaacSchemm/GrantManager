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
	public partial class SelectItemToAddDialog : Form {
		public enum DBType {
			PROJECTS, PROGRAMS, DOCTYPES
		}

		private class Wrapper {
			public object Value { get; private set; }
			public Wrapper(object o) {
				Value = o;
			}

			public string Name {
				get {
					return ToString();
				}
			}

			public override string ToString() {
				if (Value is project) {
					return ((project)Value).project_name;
				} else if (Value is program) {
					return ((program)Value).program_name;
				} else if (Value is documentation_type) {
					return ((documentation_type)Value).name;
				} else {
					return Value.ToString();
				}
			}
		}

		private Wrapper[] objects;

		public SelectItemToAddDialog(DBType type) {
			InitializeComponent();

			listBox1.DoubleClick += (o, e) => {
				if (listBox1.SelectedItem != null) btnOkay.PerformClick();
			};

			using (DataClasses1DataContext db = new DataClasses1DataContext()) {
				switch (type) {
					case DBType.PROJECTS:
						objects = db.projects.Select(p => new Wrapper(p)).ToArray();
						break;
					case DBType.PROGRAMS:
						objects = db.programs.Select(p => new Wrapper(p)).ToArray();
						break;
					case DBType.DOCTYPES:
						objects = db.documentation_types.Select(p => new Wrapper(p)).ToArray();
						break;
					default:
						break;
				}
			}

			listBox1.Items.AddRange(objects);
		}

		public static project SelectProject() {
			using (SelectItemToAddDialog dialog = new SelectItemToAddDialog(DBType.PROJECTS)) {
				if (dialog.ShowDialog() == DialogResult.OK) {
					return ((Wrapper)dialog.listBox1.SelectedItem).Value as project;
				} else {
					return null;
				}
			}
		}

		public static program SelectProgram() {
			using (SelectItemToAddDialog dialog = new SelectItemToAddDialog(DBType.PROGRAMS)) {
				if (dialog.ShowDialog() == DialogResult.OK) {
					return ((Wrapper)dialog.listBox1.SelectedItem).Value as program;
				} else {
					return null;
				}
			}
		}

		public static documentation_type SelectDocumentationType() {
			using (SelectItemToAddDialog dialog = new SelectItemToAddDialog(DBType.DOCTYPES)) {
				if (dialog.ShowDialog() == DialogResult.OK) {
					return ((Wrapper)dialog.listBox1.SelectedItem).Value as documentation_type;
				} else {
					return null;
				}
			}
		}

		private void txtSearch_TextChanged(object sender, EventArgs e) {
			listBox1.Items.Clear();
			listBox1.Items.AddRange((from w in objects
									 where w.Name.ToLowerInvariant().Contains(txtSearch.Text.ToLowerInvariant())
									 select w).ToArray());
		}
	}
}
