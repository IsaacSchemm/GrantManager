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
    /// Window for adding users to database.
    /// If current user is not an admin, this window only allows them to change their password.
    /// </summary>
    public partial class AddUser : Form
    {
        private string currentlyEditingUsername;

        /// <summary>
        /// Initializes window when adding new user.
        /// </summary>
        public AddUser()
        {
            InitializeComponent();

            this.FormClosing += AddUser_FormClosing;
        }

        /// <summary>
        /// Initializes window when editing old user.
        /// </summary>
        /// <param name="toEdit">Username of user being edited.</param>
        public AddUser(string toEdit) : this()
        {
            currentlyEditingUsername = toEdit;

            //fill in values
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                user edit = (from u in db.users
                             where u.username == currentlyEditingUsername
                             select u).First();

                txtUsername.Text = edit.username;
                txtDisplayName.Text = edit.display_name;
                activeCheckBox.Checked = edit.active;
                adminCheckBox.Checked = edit.admin;

                activeCheckBox.Enabled = (edit.username != Login.currentUser); // You cannot deactivate yourself
                adminCheckBox.Enabled = (edit.username != Login.currentUser); //You cannot change your admin status

                //cannot edit username
                txtUsername.Enabled = false;

                // Admins can edit passwords, and users can edit own passwords
                txtPassword.Enabled = (edit.username == Login.currentUser) || (from u in db.users where u.username == Login.currentUser select u.admin).First();
                if (txtPassword.Enabled)
                {
                    txtPassword.Text = edit.password;
                }
            }
        }

        /// <summary>
        /// Submits user changes to database.
        /// Called when form is closed with OK button.
        /// </summary>
        private void AddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            //make sure OK button was clicked
            if (DialogResult == DialogResult.OK) {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    //all fields must have a value
                    if (txtUsername.Text == "")
                    {
                        MessageBox.Show("Please enter a username.");
                        e.Cancel = true;
                        return;
                    }
                    if (txtPassword.Text == "")
                    {
                        MessageBox.Show("Passwords cannot be empty.");
                        e.Cancel = true;
                        return;
                    }
                    if (txtDisplayName.Text == "")
                    {
                        MessageBox.Show("Please enter a display name.");
                        e.Cancel = true;
                        return;
                    }

                    //adding new user
                    if (currentlyEditingUsername == null)
                    {
                        user toAdd = new user
                        {
                            username = txtUsername.Text,
                            password = txtPassword.Text,
                            display_name = txtDisplayName.Text,
                            active = activeCheckBox.Checked,
                            admin = adminCheckBox.Checked
                        };

                        //check if username exists
                        var userWithUsername = (from u in db.users
                                                where u.username == txtUsername.Text
                                                select u);

                        //can't insert user with duplicate username
                        if (userWithUsername.Any())
                        {
                            MessageBox.Show("Username already exists - cannot insert user with the same username as another user.");
                            e.Cancel = true;
                            return;
                        }

                        //insert into database
                        db.users.InsertOnSubmit(toAdd);
                        db.SubmitChanges();
                    }
                    else
                    {
                        user edit = (from u in db.users
                                     where u.username == currentlyEditingUsername
                                     select u).First();

                        //change display name
                        edit.display_name = txtDisplayName.Text;
                        
                        //catch warnings for different changes
                        bool warnpw = txtPassword.Text != edit.password;
                        bool warnactive = edit.active != activeCheckBox.Checked;
                        bool warnadmin = edit.admin != adminCheckBox.Checked;

                        //only change admin status, active status, and password if those fields were enabled
                        if (activeCheckBox.Enabled) edit.active = activeCheckBox.Checked;
                        if (adminCheckBox.Enabled) edit.admin = adminCheckBox.Checked;
                        if (txtPassword.Enabled) edit.password = txtPassword.Text;

                        //make sure user wants to activate / deactivate user
                        if (warnactive && DialogResult.Yes != MessageBox.Show(this, "Are you sure you want to " + (edit.active ? "" : "de") + "activate " + edit.display_name + "?", "(De)activate User", MessageBoxButtons.YesNo))
                        {
                            if (warnpw)
                            {
                                MessageBox.Show(this, "Password not changed.");
                            }
                            return;
                        }

                        //make sure user wants to change admin status of user
                        if (warnadmin && DialogResult.Yes != MessageBox.Show(this, "Are you sure you want to " + (edit.admin ? "make " : "remove ") + edit.display_name + (edit.admin ? "" : " as") + " an administrator?", "Change Admin Status", MessageBoxButtons.YesNo))
                        {
                            if (warnpw)
                            {
                                MessageBox.Show(this, "Password not changed.");
                            }
                            return;
                        }

                        //make sure user wants to change the password
                        if (warnpw && DialogResult.Yes != MessageBox.Show(this, "Are you sure you want to change " + edit.display_name + "'s password?", "Change Password", MessageBoxButtons.YesNo))
                        {
                            e.Cancel = true;
                            return;
                        }

                        //have them reenter password
                        if (warnpw && DialogResult.OK != new ReenterPassword(txtPassword.Text).ShowDialog(this))
                        {
                            e.Cancel = true;
                            return;
                        }

                        //submit changes once everything is valid
                        db.SubmitChanges();
                    }
                }
            }
        }
    }
}
