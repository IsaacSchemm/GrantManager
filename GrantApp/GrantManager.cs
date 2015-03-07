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
    /// Displays grants and allows adding, editing, or deleting them.
    /// </summary>
    public partial class GrantManager : Form
    {
        //images for attachments
        private Image paperclip;
        private Image blank;

        /// <summary>
        /// Initializes window.
        /// </summary>
        public GrantManager()
        {
            InitializeComponent();

            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream stream1 = myAssembly.GetManifestResourceStream("GrantApp.20px-attachment.png");
            paperclip = new Bitmap(stream1);
            System.IO.Stream stream2 = myAssembly.GetManifestResourceStream("GrantApp.20px-blank.png");
            blank = new Bitmap(stream2);
            searchBox.KeyDown += new KeyEventHandler(search_Enter);
            RefreshGrants();
        }

        private string shortDate(DateTime? dt) {
            return dt == null
                ? ""
                : dt.Value.ToShortDateString();
        }

        /// <summary>
        /// Reloads the list of grants.
        /// </summary>
        internal void RefreshGrants()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                IEnumerable<dynamic> q;

                //if search box text is empty, load all grants
                if (searchBox.Text == "")
                {
                    q = from g in db.grants
                        select new {
                            ID = g.grant_id,
                            Name = g.grant_name,
                            Status = g.status_type.description,
                            SubmitDate = g.submit_date,
                            DueDate = g.due_date,
                            StartDate = g.start_date,
                            Amount = g.grant_actual_amount,
                            AnyAttachments = db.attachments.Any(a => a.grant_id == g.grant_id),
                        };
                }
                //otherwise only load grants whose names matches the search text
                else
                {
                    q = from g in db.grants
                        where g.grant_name.Contains(searchBox.Text)
                        || g.notes.Contains(searchBox.Text)
                        select new {
                            ID = g.grant_id,
                            Name = g.grant_name,
                            Status = g.status_type.description,
                            SubmitDate = g.submit_date,
                            DueDate = g.due_date,
                            StartDate = g.start_date,
                            Amount = g.grant_actual_amount,
                            AnyAttachments = db.attachments.Any(a => a.grant_id == g.grant_id),
                        };
                }

                grantGrid.DataSource = q.ToList().Select(g => new {
                    g.ID,
                    g.Name,
                    g.Status,
                    SubmitDate = shortDate(g.SubmitDate),
                    DueDate = shortDate(g.DueDate),
                    StartDate = shortDate(g.StartDate),
                    Amount = (g.Amount == null) ? "" : ((decimal)g.Amount).ToString("c"),
                    File = g.AnyAttachments ? paperclip : blank
                }).ToList();
            }

            //hide id column
            grantGrid.Columns[0].Visible = false;
        }

        /// <summary>
        /// Removes a grant from the database.
        /// </summary>
        private void RemoveSelected()
        {
            //only one grant may be selected
            if (grantGrid.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select a single row.");
                return;
            }

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                foreach (DataGridViewRow row in grantGrid.SelectedRows)
                {
                    //find id
                    int id = (int)row.Cells["ID"].Value;
                    var grant = (from g in db.grants
                                   where g.grant_id == id
                                   select g).First();

                    //get user confirmation for delete
                    if (MessageBox.Show(this, "Are you sure you want to delete " + grant.grant_name + " from the database?", this.Text, MessageBoxButtons.YesNo) != DialogResult.Yes)
                    {
                        return;
                    }

                    try
                    {
                        //write to changelog
                        if (Settings.EnableChangelog) {
                            string contact_history_summary = grant.contact_histories.Any()
                                ? Comparison<contact_history>.Compare(null, grant.contact_histories.First())
                                : "none";
                            changelog log = new changelog {
                                username = Login.currentUser,
                                object_edited = "grant " + grant.grant_name,
                                date = DateTime.Now,
                                details = "Deleted: " + Comparison<grant>.Compare(null, grant)
                                    + " // contact history: " + contact_history_summary
                                    + " // attachments: " + string.Join(", ", grant.attachments.Select(s => s.filename).DefaultIfEmpty("none"))
                                    + " // timeline: " + string.Join(", ", grant.timeline_dates.Select(d => d.name + " " + d.date).DefaultIfEmpty("none"))
                                    + " // budget items: " + string.Join(", ", grant.budget_items.Select(b => b.name + " " + b.amount).DefaultIfEmpty("none"))
                            };
                            db.changelogs.InsertOnSubmit(log);
                        }

                        //delete grant
                        db.grants.DeleteOnSubmit(grant);

                        //delete grant's contact history
                        db.contact_histories.DeleteAllOnSubmit(grant.contact_histories);

                        //delete entries from linking tables (programs, projects, doc types)
                        db.grant_programs.DeleteAllOnSubmit(grant.grant_programs);
                        db.documentation_requirements.DeleteAllOnSubmit(grant.documentation_requirements);
                        db.grant_projects.DeleteAllOnSubmit(grant.grant_projects);

                        //submit
                        db.SubmitChanges();
                    }
                    catch (SqlException e)
                    {
                        Console.Error.WriteLine(e.Message);
                        MessageBox.Show(this, "Could not remove the grant: - a database error occured.",
                            this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Deletes a grant.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs args)
        {
            //remove from database
            RemoveSelected();

            //refresh list
            RefreshGrants();
        }

        /// <summary>
        /// Window load.
        /// Creates column at end of list to hold attachment icon.
        /// </summary>
        private void GrantManager_Load(object sender, EventArgs e)
        {
            grantGrid.Columns[7].HeaderText = "";
            if (grantGrid.Rows.Count > 0) { // check in case there are no grants listed
                grantGrid.Columns[7].Width = grantGrid.Rows[0].Height;
            }
        }

        /// <summary>
        /// Add grant.
        /// </summary>
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext()) {
                if (!db.status_types.Any()) {
                    MessageBox.Show(this, "The status_type table in the database is empty. Ask the administrator to add values to this table (e.g. Active, Inactive, Potential...)");
                    return;
                } else if (!db.grantors.Any()) {
                    MessageBox.Show(this, "No grantors are listed in the database. Please add one from the Grantors screen.");
                    return;
                }
            }

            // carry current window state over to next view
            AddGrant ag = new AddGrant();
            ag.WindowState = this.WindowState;
            ag.ShowDialog(this);

            //refresh list
            RefreshGrants();
        }

        /// <summary>
        /// Edit a grant.
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //find id
            int id = 0;
            foreach (DataGridViewRow row in grantGrid.SelectedRows)
            {
                id = (int)row.Cells["ID"].Value;
            }

            // carry current window state over to next view
            AddGrant ag = new AddGrant(id);
            ag.WindowState = this.WindowState;
            ag.ShowDialog(this);

            //refresh list
            RefreshGrants();
        }

        /// <summary>
        /// Filters the displayed grants based on the search text.
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshGrants();
        }

        /// <summary>
        /// Allows searching by pressing enter.
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

        /// <summary>
        /// Opens the window that allows editing contact history.
        /// </summary>
        private void editContactHistory(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext()) {
                if (!db.approaches.Any()) {
                    MessageBox.Show(this, "No possible approaches (e.g. email, phone, in-person...) are available. Please add one from the Administration panel.");
                    return;
                }
            }

            //find id
            int id = 0;
            foreach (DataGridViewRow row in grantGrid.SelectedRows)
            {
                id = (int)row.Cells["ID"].Value;
            }

            //open window
            new ContactHistory(id).ShowDialog(this);
        }

        /// <summary>
        /// Displays window with grant details
        /// Called when double-clicking grant.
        /// </summary>
        public void openGrantDetails(object sender, EventArgs e)
        {
            //find id
            int id = 0;
            foreach (DataGridViewRow row in grantGrid.SelectedRows)
            {
                id = (int)row.Cells["ID"].Value;
            }

            //open window
            new GrantDetails(id).ShowDialog(this);
        }

        private void btnTimeline_Click(object sender, EventArgs e) {
            //find id
            int id = 0;
            foreach (DataGridViewRow row in grantGrid.SelectedRows) {
                id = (int)row.Cells["ID"].Value;
            }

            //open window
            new TimelineManager(id).ShowDialog(this);
        }

        private void btnBudget_Click(object sender, EventArgs e) {
            //find id
            int id = 0;
            foreach (DataGridViewRow row in grantGrid.SelectedRows) {
                id = (int)row.Cells["ID"].Value;
            }

            //open window
            new BudgetManager(id).ShowDialog(this);
        }

    }
}
