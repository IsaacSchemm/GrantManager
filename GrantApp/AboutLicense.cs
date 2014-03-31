using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrantApp
{
    public partial class AboutLicense : Form
    {
        public AboutLicense()
        {
            InitializeComponent();
        }

        public static void ShowDialog(string text, string title) {
            var dialog = new AboutLicense();
            dialog.Text = title;
            dialog.textBox1.Text = text.Replace("\n", "\r\n");
            dialog.ShowDialog();
        }
    }
}
