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
		private string originalText;

		private ExpandedTextDialog() {
			InitializeComponent();

			this.FormClosing += ExpandedTextDialog_FormClosing;
		}

		private void ExpandedTextDialog_FormClosing(object sender, FormClosingEventArgs e) {
			if (this.textBox1.Text != this.originalText && DialogResult != DialogResult.OK) {
				if (DialogResult.Yes != MessageBox.Show("Are you sure you want to discard your changes to the text field?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) {
					e.Cancel = true;
				}
			}
		}

		public static string ShowDialog(string originalText) {
			using (ExpandedTextDialog dialog = new ExpandedTextDialog()) {
				dialog.originalText = originalText;
				dialog.textBox1.Text = originalText;
				if (dialog.ShowDialog() == DialogResult.OK) return dialog.textBox1.Text;
				else return null;
			}
		}
	}
}
