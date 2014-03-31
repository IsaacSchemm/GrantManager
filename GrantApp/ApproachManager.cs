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
    /// Displays approaches and allows adding, editing, or deleting them.
    /// </summary>
    public partial class ApproachManager : Form
    {
        public ApproachManager()
        {
            InitializeComponent();
            RefreshApproaches();
            searchBox.KeyDown += new KeyEventHandler(search_Enter);
            btnSearch.Click += new EventHandler(btnSearch_Click);
            btnRefresh.Click += new EventHandler(btnRefresh_Click);
            btnAdd.Click += new EventHandler(btnAdd_Click);
            btnEdit.Click += new EventHandler(btnEdit_Click);
            btnDelete.Click += new EventHandler(btnDelete_Click);
        }

        /// <summary>
        /// Refills list of approaches from database.
        /// Called after adding/editing/deleting or after narrowing down display with a search.
        /// </summary>
        internal void RefreshApproaches()
        {
            //if not searching, display all approaches
            if (searchBox.Text == "")
            {

                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    var q = from a in db.approaches
                            orderby a.approach_type
                            select new
                            {
                                ID = a.approach_id,
                                Name = a.approach_type,
                            };
                    approachGrid.DataSource = q;

                    //hide id column
                    approachGrid.Columns[0].Visible = false;
                    approachGrid.Columns[1].HeaderText = "Type";
                }
            }
            //otherwise only display approaches that match their type with the search box text
            else
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    var q = from a in db.approaches
                            where a.approach_type.Contains(searchBox.Text)
                            orderby a.approach_type
                            select new
                            {
                                ID = a.approach_id,
                                Name = a.approach_type,
                            };
                    approachGrid.DataSource = q;
                    approachGrid.Columns[0].Visible = false;
                    approachGrid.Columns[1].HeaderText = "Type";
                }

            }
        }

        /// <summary>
        /// Deletes approach from database.
        /// </summary>
        private void RemoveSelected()
        {
            //make sure an approach was selected
            if (approachGrid.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select a single row.");
                return;
            }

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                foreach (DataGridViewRow row in approachGrid.SelectedRows)
                {
                    //get id of approach
                    int id = (int)row.Cells["ID"].Value;
                    var app = (from a in db.approaches
                               where a.approach_id == id
                               select a).First();

                    //get confirmation of delete
                    if (MessageBox.Show(this, "Are you sure you want to delete " + app.approach_type + " from the database?", this.Text, MessageBoxButtons.YesNo) != DialogResult.Yes)
                    {
                        return;
                    }

                    //don't allow deleting approaches that are used in at least one grant's contact history
                    if (app.contact_histories.Any())
                    {
                        MessageBox.Show("This project is attached to the contact history of " + app.contact_histories.Count() + " grant(s), including " + app.contact_histories.First().grant.grant_name + ". It cannot be deleted.");
                        return;
                    }

                    //remove from database
                    try
                    {
                        db.approaches.DeleteOnSubmit(app);
                        foreach (var ch in app.contact_histories)
                        {
                            ch.initial_approach_id = null;
                        }
                        db.SubmitChanges();
                    }
                    catch (SqlException e)
                    {
                        Console.Error.WriteLine(e.Message);
                        MessageBox.Show(this, "Could not remove the approach: - a database error occured.",
                            this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Opens AddApproach window.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //add
            new AddApproach().ShowDialog(this);

            //refresh list
            RefreshApproaches();
        }

        /// <summary>
        /// Opens AddApproach window with ability to edit approach.
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //find id
            int id = 0;
            foreach (DataGridViewRow row in approachGrid.SelectedRows)
            {
                id = (int)row.Cells["ID"].Value;
            }

            //edit
            new AddApproach(id).ShowDialog(this);

            //refresh list
            RefreshApproaches();
        }

        /// <summary>
        /// Calls remove function to delete an approach.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //remove
            RemoveSelected();

            //refresh list
            RefreshApproaches();
        }

        /// <summary>
        /// Refreshes the list of  approaches by repopulating list from database
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshApproaches();
        }

        /// <summary>
        /// Calls refresh method to filter out approaches that don't match the search text.
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshApproaches();
        }

        /// <summary>
        /// Allows searching by hitting enter when the focus is on the search text input.
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
