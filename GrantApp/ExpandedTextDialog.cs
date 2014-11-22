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
	public partial class ExpandedTextDialog : Form {
		private ExpandedTextDialog() {
			InitializeComponent();
		}

		public static string ShowDialog(string originalText) {
			using (ExpandedTextDialog dialog = new ExpandedTextDialog()) {
				dialog.textBox1.Text = originalText;
				if (dialog.ShowDialog() == DialogResult.OK) return dialog.textBox1.Text;
				else return null;
			}
		}
	}
}
