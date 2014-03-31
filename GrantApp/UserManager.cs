using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrantApp
{
    /// <summary>
    /// Displays users and allows adding, editing, or deleting.
    /// </summary>
    public partial class Users : Form
    {
        /// <summary>
        /// Initializes window.
        /// </summary>
        public Users()
        {
            InitializeComponent();
            RefreshUsers();
            searchBox.KeyDown += new KeyEventHandler(search_Enter);
        }

        /// <summary>
        /// Reloads the list of users to reflect current database state.
        /// </summary>
        internal void RefreshUsers()
        {
            //if search box is empty, load all users
            if (searchBox.Text == "")
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    //make sure user is admin
                    //shouldn't have been able to get here if not an admin, but make sure
                    bool admin = (from u in db.users
                                  where u.username == Login.currentUser
                                  select u.admin).FirstOrDefault();
                    if (!admin)
                    {
                        throw new UnauthorizedAccessException("User " + Login.currentUser + " does not have admin privileges.");
                    }

                    //populate list
                    var q = from u in db.users
                            orderby u.username
                            select new
                            {
                                Username = u.username,
                                Display = u.display_name,
                                Active = u.active ? "Yes" : "No",
                                Administrator = u.admin ? "Yes" : "No",
                            };
                    dataGridView1.DataSource = q;
                    dataGridView1.Columns[1].HeaderText = "Display Name";
                }
            }
            //otherwise filter results based on search text
            else
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    //make sure user is admin
                    //shouldn't have been able to get here if not an admin, but make sure
                    bool admin = (from u in db.users
                                  where u.username == Login.currentUser
                                  select u.admin).FirstOrDefault();
                    if (!admin)
                    {
                        throw new UnauthorizedAccessException("User " + Login.currentUser + " does not have admin privileges.");
                    }

                    //populate list
                    var q = from u in db.users
                            where u.username.Contains(searchBox.Text)
                            orderby u.username
                            select new
                            {
                                Username = u.username,
                                Display = u.display_name,
                                Active = u.active ? "Yes" : "No",
                            };
                    dataGridView1.DataSource = q;
                    dataGridView1.Columns[1].HeaderText = "Display Name";
                }

            }
        }

        /// <summary>
        /// Remove entry from database.
        /// </summary>
        private void RemoveSelected()
        {
            //only one row can be selected.
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select a single row.");
                return;
            }

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    //get selected username
                    string username = row.Cells["Username"].Value.ToString();

                    //find user
                    var user = (from u in db.users
                                where u.username == username
                                select u).First();

                    //users cannot delete themselves
					if (user.username == Login.currentUser) {
						MessageBox.Show(this, "You cannot delete yourself.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

                    //get list of all active users
                    var otherActiveUsers = from u in db.users
                                           where u.active == true
                                           && u.username != user.username
                                           select u;

                    //if user being deleted is last active user, don't allow deletion (or no one will be able to log in)
                    if (!otherActiveUsers.Any())
                    {
						MessageBox.Show(this, "There must be at least one active user in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //if user is a writer of a grant, don't allow deletion
                    //user should be set to inactive instead to preserve grant records
                    if (user.grants.Any())
                    {
                        MessageBox.Show(this, "This user is the writer of at least one grant. Set the user to inactive instead of deleting them.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //if user is a part of any contact histories, don't allow deletion
                    //user should be set to inactive instead to preserve records
                    if (user.contact_histories.Any())
                    {
                        MessageBox.Show(this, "This user is associated with at least one contact history. Set the user to inactive instead of deleting them.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    try
                    {
                        //confirm deletion
                        if (MessageBox.Show("Are you sure you want to delete " + user.username + "?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            //delete user
                            db.users.DeleteOnSubmit(user);

                            //submit to database
                            db.SubmitChanges();
                        }
                    }
                    catch (SqlException e)
                    {
                        Console.Error.WriteLine(e.Message);
                        MessageBox.Show(this, "Could not remove the user - there is still a record of them in the system.\n" +
                            "If you don't want them to be able to log in anymore, change their status to not \"Active.\"",
                            this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Add a user.
        /// </summary>
        private void Add_User(object sender, EventArgs e)
        {
            //add user
            new AddUser().ShowDialog(this);

            //refresh list
            RefreshUsers();
        }

        /// <summary>
        /// Edit a user.
        /// </summary>
        private void Edit_User(object sender, EventArgs e)
        {
            //find id
            string username = null;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                username = row.Cells["Username"].Value.ToString();
            }

            //edit user
            new AddUser(username).ShowDialog(this);

            //refresh list
            RefreshUsers();
        }

        /// <summary>
        /// Delete a user.
        /// </summary>
        private void Delete_User(object sender, EventArgs e)
        {
            //delete user
            RemoveSelected();

            //refresh list
            RefreshUsers();
        }

        /// <summary>
        /// Refreshes list of users.
        /// </summary>
        private void Refresh_User(object sender, EventArgs e)
        {
            RefreshUsers();
        }

        /// <summary>
        /// Filters users displayed in table based on text in search input.
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshUsers();
        }

        /// <summary>
        /// Allows searching by hitting enter.
        /// </summary>
        private void search_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                btnSearch_Click(sender, e);
            }
        }
    }
}
