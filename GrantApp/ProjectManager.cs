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
    /// Displays projects and allows adding, editing, or deleting.
    /// </summary>
    public partial class ProjectManager : Form
    {
		private bool UseAsSelectProjectWindow = false;
		private int? SelectedProjectIDOnClose = null;

        /// <summary>
        /// Initializes window.
        /// </summary>
        public ProjectManager()
        {
            InitializeComponent();
            RefreshProjects();

            addProject.Click += new EventHandler(Add_Project);
            editProject.Click += new EventHandler(Edit_Project);
            deleteProject.Click += new EventHandler(Delete_Project);
            refreshButton.Click += new EventHandler(Refresh_Project);
            searchProject.Click += new EventHandler(Search_Project);
            searchBox.KeyDown += new KeyEventHandler(search_Enter);

			projectGrid.DoubleClick += (o, e) => {
				if (UseAsSelectProjectWindow) {
					var rows = projectGrid.SelectedRows;
					if (rows.Count > 0) SelectedProjectIDOnClose = (int)rows[0].Cells["ID"].Value;
					this.Close();
				}
			};
        }

		public static int? SelectProject() {
			using (ProjectManager form = new ProjectManager()) {
				form.UseAsSelectProjectWindow = true;
				form.ShowDialog();
				return form.SelectedProjectIDOnClose;
			}
		}

        /// <summary>
        /// Reloads list of projects to reflect updated database.
        /// </summary>
        public void RefreshProjects()
        {
            //if search box text is empty, load all projects
            if (searchBox.Text == "")
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    var q = from p in db.projects
                            select new
                            {
                                ID = p.project_id,
                                Name = p.project_name,
                                Overview = p.project_overview
                            };
                    projectGrid.DataSource = q;

                    //hide id column
                    projectGrid.Columns[0].Visible = false;
                }
            }
            //otherwise only load grants whose names matches the search text
            else
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    var q = from p in db.projects
                            where p.project_name.Contains(searchBox.Text)
                            select new

                            {
                                ID = p.project_id,
                                Name = p.project_name,
                                Overview = p.project_overview
                            };
                    projectGrid.DataSource = q;

                    //hide id column
                    projectGrid.Columns[0].Visible = false;
                }
            }
        }

        /// <summary>
        /// Add a project.
        /// </summary>
        public void Add_Project(object sender, EventArgs e)
        {
            //add project
           new AddProject().ShowDialog(this);

            //refresh list
           RefreshProjects();
        }

        /// <summary>
        /// Edit a project.
        /// </summary>
        public void Edit_Project(object sender, EventArgs e)
        {
            //find id
            int id = 0;
            foreach (DataGridViewRow row in projectGrid.SelectedRows)
            {
                id = (int)row.Cells["ID"].Value;
            }
            
            //edit project
            new AddProject(id).ShowDialog(this);

            //refresh list
            RefreshProjects();
        }

        /// <summary>
        /// Delete a project.
        /// </summary>
        public void Delete_Project(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                foreach (DataGridViewRow row in projectGrid.SelectedRows)
                {
                    //find id of selected project
                    int id = (int)row.Cells["ID"].Value;
                    var deleted = (from p in db.projects
                                   where p.project_id == id
                                   select p).First();

                    //get user confirmation
                    if (MessageBox.Show(this, "Are you sure you want to delete " + deleted.project_name + " from the database?", this.Text, MessageBoxButtons.YesNo) != DialogResult.Yes)
                    {
                        return;
                    }

                    //if project is connected to any grants, make sure user wants to remove it
                    if (deleted.grant_projects.Any())
                    {
                        if (MessageBox.Show(this, "This project is attached to " + deleted.grant_projects.Count() + " grant(s). Is it OK to remove this project from each grant it's attached to?", this.Text, MessageBoxButtons.OKCancel) != DialogResult.OK)
                        {
                            return;
                        }
                    }

                    try
                    {
                        //write to changelog
						var grants = from gp in deleted.grant_projects
									 select gp.grant.grant_name;
						if (Settings.EnableChangelog) {
							changelog log = new changelog {
								username = Login.currentUser,
								object_edited = "project " + deleted.project_name,
								date = DateTime.Now,
								details = "Deleted: " + deleted.ToString() +
								(grants.Any() ? " - was tied to grants: " + string.Join(", ", grants)
											  : " - not tied to any grants")
							};
							db.changelogs.InsertOnSubmit(log);
						}

                        //delete project
                        db.projects.DeleteOnSubmit(deleted);

                        //delete entries in linking table associated with this project
                        db.grant_projects.DeleteAllOnSubmit(deleted.grant_projects);

                        //submit to database
                        db.SubmitChanges();

                        //refresh list
                        RefreshProjects();
                    }
                    catch (SqlException e1)
                    {
                        Console.Error.WriteLine(e1.Message);
                        MessageBox.Show(this, "Could not remove the grant: - a database error occured.",
                            this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Refreshes list of projects.
        /// </summary>
        private void Refresh_Project(object sender, EventArgs e)
        {
            RefreshProjects();
        }

        /// <summary>
        /// Filters the displayed projects based on the search text.
        /// </summary>
        private void Search_Project(object sender, EventArgs e)
        {
            RefreshProjects();
        }

        /// <summary>
        /// Allows filtering projects by hitting enter.
        /// </summary>
        private void search_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                Search_Project(sender, e);
            }
        }
    }
}
