using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrantApp {
	public partial class TextBoxWithExpandButton : UserControl {
		public bool AcceptsReturn {
			get {
				return textBox1.AcceptsReturn;
			}
			set {
				textBox1.AcceptsReturn = value;
			}
		}
		public bool Multiline {
			get {
				return textBox1.Multiline;
			}
			set {
				textBox1.Multiline = value;
			}
		}
		public bool ReadOnly {
			get {
				return textBox1.ReadOnly;
			}
			set {
				textBox1.ReadOnly = value;
			}
		}
		public ScrollBars ScrollBars {
			get {
				return textBox1.ScrollBars;
			}
			set {
				textBox1.ScrollBars = value;
			}
		}

		public override string Text {
			get {
				return textBox1.Text;
			}
			set {
				textBox1.Text = value;
			}
		}

		public TextBoxWithExpandButton() {
			InitializeComponent();
		}

		private void btnExpand_Click(object sender, EventArgs e) {
			string newText = ExpandedTextDialog.ShowDialog(this.Text);
			if (newText != null) this.Text = newText;
		}
	}
}
