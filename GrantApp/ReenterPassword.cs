using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrantApp
{
    /// <summary>
    /// Window for reentering password when changing a user's password.
    /// </summary>
    public partial class ReenterPassword : Form
    {
        private string newPassword;

        /// <summary>
        /// Initializes window
        /// </summary>
        /// <param name="newPassword">The password entered on first attempt.</param>
        public ReenterPassword(string newPassword)
        {
            InitializeComponent();
            this.newPassword = newPassword;

            this.FormClosing += ReenterPassword_FormClosing;
        }

        /// <summary>
        /// Called when window closes.
        /// Checks if two password attempts matched.
        /// </summary>
        private void ReenterPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if ok button was clicked and passwords don't match
            if (DialogResult == DialogResult.OK && textBox1.Text != newPassword)
            {
                //change dialog result to cancelled
                MessageBox.Show(this, "The two passwords do not match. Please try again.");
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
