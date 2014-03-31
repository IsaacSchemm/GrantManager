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
    /// Displays grantors and allows adding, editing, and deleting.
    /// </summary>
    public partial class GrantorManager : Form
    {
        /// <summary>
        /// Initializes window.
        /// </summary>
        public GrantorManager()
        {
            InitializeComponent();
            RefreshGrantors();
            searchBox.KeyDown += new KeyEventHandler(search_Enter);
        }

        /// <summary>
        /// Reloads the list of grantors to the most updated list.
        /// </summary>
        internal void RefreshGrantors()
        {
            //if search box is empty, load all grantors
            if (searchBox.Text == "")
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    var q = from g in db.grantors
                            orderby g.organization_name
                            select new
                            {
                                ID = g.grantor_id,
                                Name = g.organization_name,
                                Contact = g.contact_name,
                                City = g.city + ", " + g.state_id,
                                Email = g.email,
                                Phone = g.phone,
                            };
                    grantorGrid.DataSource = q;

                    //hide id column
                    grantorGrid.Columns[0].Visible = false;
                    grantorGrid.Columns[2].HeaderText = "Contact Name";
                }
            }
            //otherwise only load those whose name matches the search text
            else
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    var q = from g in db.grantors
                            where g.organization_name.Contains(searchBox.Text)
                            orderby g.organization_name
                            select new
                            {
                                ID = g.grantor_id,
                                Name = g.organization_name,
                                Contact = g.contact_name,
                                City = g.city + ", " + g.state_id,
                                Email = g.email,
                                Phone = g.phone,
                            };
                    grantorGrid.DataSource = q;

                    //hide id column
                    grantorGrid.Columns[0].Visible = false;
                    grantorGrid.Columns[2].HeaderText = "Contact Name";
                }
            }
        }

        /// <summary>
        /// Remove a grantor from the database.
        /// </summary>
		private void RemoveSelected()
        {
            //only one grantor can be selected
			if (grantorGrid.SelectedRows.Count != 1)
            {
				MessageBox.Show("Please select a single row.");
				return;
			}

			using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
				foreach (DataGridViewRow row in grantorGrid.SelectedRows)
                {
                    //find id
					int id = (int)row.Cells["ID"].Value;
					var grantor = (from g in db.grantors
								   where g.grantor_id == id
								   select g).First();

					var grants = from g in db.grants
								 where g.grantor_id == grantor.grantor_id
								 select g;

                    //cannot remove grantors who are listed on a grant
					if (grants.Any())
                    {
						MessageBox.Show(this, "Could not remove the grantor: " + 
							(grants.Count() == 1
								? "the grant \"" + grants.First().grant_name + "\" is "
								: grants.Count() + " grants are ")
							+ "still listed in the database that reference this grantor.",
							this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

                    //get user confirmation
					if (MessageBox.Show(this, "Are you sure you want to delete " + grantor.organization_name + " from the database?", this.Text, MessageBoxButtons.YesNo) != DialogResult.Yes)
                    {
						return;
					}

                    //write to changelog
					try {
						if (Settings.EnableChangelog) {
							changelog log = new changelog {
								username = Login.currentUser,
								object_edited = "grantor " + grantor.organization_name,
								date = DateTime.Now,
								details = "Deleted: " + grantor.ToString()
							};
							db.changelogs.InsertOnSubmit(log);
						}

                        //delete grantor
						db.grantors.DeleteOnSubmit(grantor);

                        //submit changes
						db.SubmitChanges();
					} catch (SqlException e) {
						Console.Error.WriteLine(e.Message);
						MessageBox.Show(this, "Could not remove the grantor: - a database error occured.",
							this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

        /// <summary>
        /// Delete a grantor.
        /// </summary>
		private void btnDelete_Click(object sender, EventArgs args)
        {
            //remove grantor
			RemoveSelected();

            //refresh list
			RefreshGrantors();
		}

        /// <summary>
        /// Add grantor.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // carry current window state over to next view
            AddGrantor ag = new AddGrantor();
            ag.WindowState = this.WindowState;
            ag.ShowDialog(this);

            //refresh list
            RefreshGrantors();
        }

        /// <summary>
        /// Edit a grant
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //find id
            int id = 0;
            foreach (DataGridViewRow row in grantorGrid.SelectedRows)
            {
                id = (int)row.Cells["ID"].Value;
            }

            // carry current window state over to next view
            AddGrantor ag = new AddGrantor(id);
            ag.WindowState = this.WindowState;
            ag.ShowDialog(this);

            //refresh list
            RefreshGrantors();
        }

        /// <summary>
        /// Refreshes the list of grantor.
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrantors();
        }

        /// <summary>
        /// Filters list of grantors to only include those that match search term.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshGrantors();
        }

        /// <summary>
        /// Allows filtering grantors by hitting enter.
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
