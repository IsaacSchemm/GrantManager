using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrantApp
{
    /// <summary>
    /// Displays programs and allows adding, editing, or deleting.
    /// </summary>
    public partial class ProgramManager : Form
    {
        /// <summary>
        /// Initializes window.
        /// </summary>
        public ProgramManager()
        {
            InitializeComponent();
            RefreshPrograms();

            addProgram.Click += new EventHandler(Add_Program);
            editProgram.Click += new EventHandler(Edit_Program);
            deleteProgram.Click += new EventHandler(Delete_Program);
            refreshButton.Click += new EventHandler(Refresh_Program);
            searchProgram.Click += new EventHandler(Search_Program);
            searchBox.KeyDown += new KeyEventHandler(search_Enter);
        }

        /// <summary>
        /// Reloads the list of programs to reflect newest changes.
        /// </summary>
        public void RefreshPrograms()
        {
            //if search box text is empty, load all programs
            if (searchBox.Text == "")
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    var q = from p in db.programs
                            select new
                            {
                                ID = p.program_id,
                                Name = p.program_name,
                                Description = p.program_description
                            };
                    programGrid.DataSource = q;

                    //hide id column
                    programGrid.Columns[0].Visible = false;
                }
            }
            //otherwise only load programs whose names matches the search text
            else
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    var q = from p in db.programs
                            where p.program_name.Contains(searchBox.Text)
                            select new
                            {
                                ID = p.program_id,
                                Name = p.program_name,
                                Description = p.program_description
                            };
                    programGrid.DataSource = q;

                    //hide id column
                    programGrid.Columns[0].Visible = false;
                }
            }
        }

        /// <summary>
        /// Add a program.
        /// </summary>
        public void Add_Program(object sender, EventArgs e)
        {
            //add program
            new AddProgram().ShowDialog(this);

            //refresh list
            RefreshPrograms();
        }

        /// <summary>
        /// Edit a program.
        /// </summary>
        public void Edit_Program(object sender, EventArgs e)
        {
            //find id
            int id = 0;
            foreach (DataGridViewRow row in programGrid.SelectedRows)
            {
                id = (int)row.Cells["ID"].Value;
            }

            //edit program
            new AddProgram(id).ShowDialog(this);

            //refresh list
            RefreshPrograms();
        }

        /// <summary>
        /// Delete a program.
        /// </summary>
        public void Delete_Program(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                foreach (DataGridViewRow row in programGrid.SelectedRows)
                {
                    //find id of selected program
                    int id = (int)row.Cells["ID"].Value;
                    var deleted = (from p in db.programs
                                   where p.program_id == id
                                   select p).First();

                    //get user confirmation
                    if (MessageBox.Show(this, "Are you sure you want to delete " + deleted.program_name + " from the database?", this.Text, MessageBoxButtons.YesNo) != DialogResult.Yes)
                    {
                        return;
                    }

                    //if program is connected to any grants, make sure user wants to delete it
                    if (deleted.grant_programs.Any())
                    {
                        if (MessageBox.Show(this, "This project is attached to " + deleted.grant_programs.Count() + " grant(s). Is it OK to remove this program from each grant it's attached to?", this.Text, MessageBoxButtons.OKCancel) != DialogResult.OK)
                        {
                            return;
                        }
                    }

                    try
                    {
                        //delete program
                        db.programs.DeleteOnSubmit(deleted);

                        //delete entries in linking table associated with this program
                        db.grant_programs.DeleteAllOnSubmit(deleted.grant_programs);

                        //submit to database
                        db.SubmitChanges();

                        //refresh list
                        RefreshPrograms();
                    }
                    catch (SqlException e1)
                    {
                        Console.Error.WriteLine(e1.Message);
                        MessageBox.Show(this, "Could not remove the program: - a database error occured.",
                            this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Refreshes list of programs
        /// </summary>
        private void Refresh_Program(object sender, EventArgs e)
        {
            RefreshPrograms();
        }

        /// <summary>
        /// Filters the displayed programs based on the search text.
        /// </summary>
        private void Search_Program(object sender, EventArgs e)
        {
            RefreshPrograms();
        }
        
        /// <summary>
        /// Allows filtering programs by hitting enter.
        /// </summary>
        private void search_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                Search_Program(sender, e);
            }
        }

		/// <summary>
		/// Clears the search box and restores the original non-filtered view.
		/// </summary>
		private void btnClear_Click(object sender, EventArgs e) {
			searchBox.Text = "";
			Search_Program(sender, e);
		}

    }
}
