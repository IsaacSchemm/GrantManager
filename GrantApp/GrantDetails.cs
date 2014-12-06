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
    /// Displays all the details of a grant.
    /// </summary>
    public partial class GrantDetails : Form
    {
        /// <summary>
        /// Initializes window.
        /// </summary>
        public GrantDetails()
        {
            InitializeComponent();

            backButton.Click += new EventHandler(backButton_Click);
        }

        /// <summary>
        /// Initializes window for particular grant.
        /// </summary>
        /// <param name="id">Id of grant whose details will be displayed.</param>
        public GrantDetails(int id)
            : this()
        {
            //fill in grant information
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                grant currentGrant = (from g in db.grants
                                      where g.grant_id == id
                                      select g).First();

                nameLabel.Text = currentGrant.grant_name;
                descLabel.Text = currentGrant.grant_description;

                //get grantor's name
                grantor currentGrantor = (from g in db.grantors
                                          where g.grantor_id == currentGrant.grantor_id
                                          select g).First();

                grantorLabel.Text = currentGrantor.organization_name;
                
                //only display dates if they are not null
                if (currentGrant.submit_date != null) submitLabel.Text = currentGrant.submit_date.Value.Date.ToShortDateString();
                if (currentGrant.due_date != null) duedateLabel.Text = currentGrant.due_date.Value.Date.ToShortDateString();
                if (currentGrant.turnaround_time != null) turnaroundLabel.Text = currentGrant.turnaround_time.Value.Date.ToShortDateString();
                if (currentGrant.start_date != null) startLabel.Text = currentGrant.start_date.Value.Date.ToShortDateString();
                if (currentGrant.payment_date != null) paymentLabel.Text = currentGrant.payment_date.Value.Date.ToShortDateString();
                
                //dollar signs in front of money values
                requestedLabel.Text = "$" + currentGrant.grant_requested_amount.ToString("0.00");
				actualLabel.Text = currentGrant.grant_actual_amount == null ? "" : ("$" + currentGrant.grant_actual_amount.Value.ToString("0.00"));

                //get status name
                status_type status = (from s in db.status_types
                                      where s.status_id == currentGrant.status
                                      select s).First();

                statusLabel.Text = status.description;
                usernameLabel.Text = currentGrant.grantor_username;
                websiteLabel.Text = currentGrant.grantor_website;
                passwordLabel.Text = currentGrant.grantor_password;

                //get writer's name
                writerLabel.Text = (from u in db.users
                               where u.username == currentGrant.grant_writer
                               select u.display_name).FirstOrDefault() ?? "(none)";

                //get programs connected to grant
                var programs = (from gp in db.grant_programs
                                join p in db.programs on gp.program_id equals p.program_id
                                where gp.grant_id == currentGrant.grant_id
                                select p);

                programLabel.Text = "";
                int count = 0;
                foreach (program p in programs)
                {
                    programLabel.Text += p.program_name;

                    if (count < programs.Count() - 1)
                    {
                        programLabel.Text += ", ";
                    }

                    count++;
                }

                emphasisLabel.Text = currentGrant.program_emphasis;

                //get projects connected to grant
                var projects = (from gp in db.grant_projects
                                join p in db.projects on gp.project_id equals p.project_id
                                where gp.grant_id == currentGrant.grant_id
                                select p);

                projectLabel.Text = "";
                count = 0;
                foreach (project p in projects)
                {
                    projectLabel.Text += p.project_name;

                    if (count < projects.Count() - 1)
                    {
                        projectLabel.Text += ", ";
                    }

                    count++;
                }

                //get doc types connected to grant
                var docTypes = (from dr in db.documentation_requirements
                                join dt in db.documentation_types on dr.documentation_type_id equals dt.documentation_type_id
                                where dr.grant_id == currentGrant.grant_id
                                select dt);

                requirementsLabel.Text = "";
                count = 0;
                foreach (documentation_type dt in docTypes)
                {
                    requirementsLabel.Text += dt.name;

                    if (count < docTypes.Count() - 1)
                    {
                        requirementsLabel.Text += ", ";
                    }

                    count++;
                }

                notesLabel.Text = currentGrant.notes;

				var attachments = from a in db.attachments
								  where a.grant_id == currentGrant.grant_id
								  select new { a.attachment_id, a.filename, a.grant_id };
				foreach (var a in attachments) {
					LinkLabel l = new LinkLabel();
					l.Text = a.filename;
					l.AutoSize = true;
					l.Click += (o, e) => {
						using (var form = new AttachmentForm(a.grant_id, a.attachment_id)) {
							form.ShowDialog(this);
						}
					};
					flowLayoutPanel1.Controls.Add(l);
				}
            }
        }

        /// <summary>
        /// Closes the window.
        /// </summary>
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
