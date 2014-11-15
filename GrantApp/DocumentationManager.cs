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
    /// Displays doc types and allows adding, editing, and deleting them.
    /// </summary>
    public partial class Documentation : Form
    {
        /// <summary>
        /// Initializes window.
        /// </summary>
        public Documentation()
        {
            InitializeComponent();
            RefreshDocumentation();
            searchBox.KeyDown += new KeyEventHandler(search_Enter);
            btnSearch.Click += new EventHandler(btnSearch_Click);
            btnRefresh.Click += new EventHandler(btnRefresh_Click);
            btnAdd.Click += new EventHandler(btnAdd_Click);
            btnEdit.Click += new EventHandler(btnEdit_Click);
            btnDelete.Click += new EventHandler(btnDelete_Click);
        }

        /// <summary>
        /// Reloads list of doc types.
        /// </summary>
        internal void RefreshDocumentation()
        {
            //if search box is empty, load all doc types
            if (searchBox.Text == "")
            {

                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    var q = from d in db.documentation_types
                            orderby d.name
                            select new
                            {
                                ID = d.documentation_type_id,
                                Name = d.name,
                            };
                    docGrid.DataSource = q;

                    //hide id column
                    docGrid.Columns[0].Visible = false;
                    docGrid.Columns[1].HeaderText = "Name";
                }
            }
            //otherwise filter search based on text in search input
            else
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    var q = from d in db.documentation_types
                            where d.name.Contains(searchBox.Text)
                            orderby d.name
                            select new
                            {
                                ID = d.documentation_type_id,
                                Name = d.name,
                            };
                    docGrid.DataSource = q;

                    //hide id column
                    docGrid.Columns[0].Visible = false;
                    docGrid.Columns[1].HeaderText = "Name";
                }

            }
        }

        /// <summary>
        /// Removes a doc type drom the database.
        /// </summary>
        private void RemoveSelected()
        {
            //make sure only one row is selected
            if (docGrid.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select a single row.");
                return;
            }

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                foreach (DataGridViewRow row in docGrid.SelectedRows)
                {
                    //find id
                    int id = (int)row.Cells["ID"].Value;
                    var doc = (from d in db.documentation_types
                               where d.documentation_type_id == id
                               select d).First();

                    //get user confirmation
                    if (MessageBox.Show(this, "Are you sure you want to delete " + doc.name + " from the database?", this.Text, MessageBoxButtons.YesNo) != DialogResult.Yes)
                    {
                        return;
                    }

                    //doc type could be linked to one or more grants
                    //get users confirmation again if this is the case
                    if (doc.documentation_requirements.Any())
                    {
                        if (MessageBox.Show(this, "This project is attached to " + doc.documentation_requirements.Count() + " grant(s), including " + doc.documentation_requirements.First().grant.grant_name + ". Is it OK to remove this documentation type from each grant it's attached to?", this.Text, MessageBoxButtons.OKCancel) != DialogResult.OK)
                        {
                            return;
                        }
                    }

                    try
                    {
                        //delete doc type
                        db.documentation_types.DeleteOnSubmit(doc);

                        //remove doc type field in each grant it's associated with
                        db.documentation_requirements.DeleteAllOnSubmit(doc.documentation_requirements);
                        
                        //submit changes
                        db.SubmitChanges();
                    }
                    catch (SqlException e)
                    {
                        Console.Error.WriteLine(e.Message);
                        MessageBox.Show(this, "Could not remove the documentation type: - a database error occured.",
                            this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Opens AddDocumentation window for adding.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //open window
            new AddDocumentationType().ShowDialog(this);

            //refresh list after adding
            RefreshDocumentation();
        }

        /// <summary>
        /// Opens AddDocumentation window for editing.
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //find id of selected doc type
            int id = 0;
            foreach (DataGridViewRow row in docGrid.SelectedRows)
            {
                id = (int)row.Cells["ID"].Value;
            }

            //open window
            new AddDocumentationType(id).ShowDialog(this);

            //refresh list after editing
            RefreshDocumentation();
        }

        /// <summary>
        /// Deletes doc type.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //delete
            RemoveSelected();

            //refresh list
            RefreshDocumentation();
        }

        /// <summary>
        /// Refreshes the list of doc types to current updated list.
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDocumentation();
        }

        /// <summary>
        /// Filters the doc types displayed in the list based on the search text.
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshDocumentation();
        }

        /// <summary>
        /// Allows search filtering when the enter button is pressed.
        /// </summary>
        private void search_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                btnSearch_Click(sender, e);
            }
        }

		/// <summary>
		/// Clears the search box and restores the original non-filtered view.
		/// </summary>
		private void btnClear_Click(object sender, EventArgs e) {
			searchBox.Text = "";
			btnSearch_Click(sender, e);
		}
    }
}
