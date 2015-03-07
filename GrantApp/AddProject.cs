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
    /// Window for adding projects to database.
    /// </summary>
    public partial class AddProject : Form
    {
        private int? currentlyEditingId;
        private ListBox projectsList;

        /// <summary>
        /// Initializes window when adding a new project.
        /// </summary>
        public AddProject()
        {
            InitializeComponent();

            submitButton.Click += new EventHandler(Add_Project);
        }

        /// <summary>
        /// Initializes window when editing an old project.
        /// </summary>
        /// <param name="id">Id of project being edited.</param>
        public AddProject(int id)
            : this()
        {
            currentlyEditingId = id;
        }

        /// <summary>
        /// Initializes window when adding new project from AddGrant window.
        /// List box is passed so list can be updated with new project after adding.
        /// </summary>
        public AddProject(ListBox pl) : this()
        {
            projectsList = pl;
        }

        /// <summary>
        /// Fills in values if editing an old project.
        /// </summary>
        public void AddProject_Load(object sender, EventArgs e)
        {
            //only fill in values if editing a program
            if (currentlyEditingId != null)
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    project currentlyEditing = (from p in db.projects
                                                where p.project_id == currentlyEditingId
                                                select p).First();

                    this.nameText.Text = currentlyEditing.project_name;
                    this.overviewText.Text = currentlyEditing.project_overview;
                    //this.needStatementText.Text = currentlyEditing.project_need_statement;
                    this.objectivesText.Text = currentlyEditing.project_objectives;
                    this.outcomesText.Text = currentlyEditing.project_outcomes;
                    //this.budgetText.Text = currentlyEditing.organizational_budget;
                    //this.timelineText.Text = currentlyEditing.project_timeline;
                    this.lettersText.Text = currentlyEditing.project_letters_support;
                    this.notesText.Text = currentlyEditing.notes;
                }
            }
        }

        /// <summary>
        /// Submits changes to database.
        /// </summary>
        public void Add_Project(object sender, EventArgs e)
        {
            //project must have a name
            if (nameText.Text == "")
            {
                MessageBox.Show("Project must have a name.");
                return;
            }
            // ensures budgetText is a number or blank(0)
            //if (budgetText.Text == "")
            //{
            //    budgetText.Text = "0";
            //}

            //double Num;
            //bool isNum = double.TryParse(budgetText.Text.Trim(), out Num);
            //if (!isNum)
            //{
            //    MessageBox.Show("Budget must be numeric, or left blank");
            //    return;
            //}
            int project_id_added_or_edited;

            //summary of old project
            project oldProject;
            using (DataClasses1DataContext db = new DataClasses1DataContext()) {
                oldProject = (from p in db.projects
                              where p.project_id == currentlyEditingId
                              select p).FirstOrDefault();
            }
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                //editing old project
                if (currentlyEditingId != null)
                {
                    //find project
                    project currentlyEditing = (from p in db.projects
                                                where p.project_id == (int)currentlyEditingId
                                                select p).First();

                    //change values
                    currentlyEditing.project_name = this.nameText.Text;
                    currentlyEditing.project_overview = this.overviewText.Text;
                    //currentlyEditing.project_need_statement = this.needStatementText.Text;
                    currentlyEditing.project_objectives = this.objectivesText.Text;
                    currentlyEditing.project_outcomes = this.outcomesText.Text;
                    //currentlyEditing.organizational_budget = this.budgetText.Text;
                    //currentlyEditing.project_timeline = this.timelineText.Text;
                    currentlyEditing.project_letters_support = this.lettersText.Text;
                    currentlyEditing.notes = this.notesText.Text;

                    project_id_added_or_edited = currentlyEditingId.Value;
                }
                //adding new project
                else
                {
                    project p = new project
                    {
                        project_name = this.nameText.Text,
                        project_overview = this.overviewText.Text,
                        //project_need_statement = this.needStatementText.Text,
                        project_objectives = this.objectivesText.Text,
                        project_outcomes = this.outcomesText.Text,
                        //organizational_budget = this.budgetText.Text,
                        //project_timeline = this.timelineText.Text,
                        project_letters_support = this.lettersText.Text,
                        notes = this.notesText.Text
                    };

                    db.projects.InsertOnSubmit(p);

                    //add to projects list if opened from AddGrant window
                    if (projectsList != null)
                    {
                        projectsList.Items.Add(p);
                    }

                    //submit project here so it has an id to put in linking table
                    db.SubmitChanges();

                    project_id_added_or_edited = p.project_id;
                }

                //write to change log
                if (Settings.EnableChangelog)
                {
                    var newProject = (from p in db.projects
                                      where p.project_id == project_id_added_or_edited
                                      select p).First();
                    changelog log = new changelog()
                    {
                        object_edited = "project " + this.nameText.Text,
                        username = Login.currentUser,
                        date = DateTime.Now,
                    };
                    log.details = "Add/edit: " + Comparison<project>.Compare(oldProject, newProject);
                    db.changelogs.InsertOnSubmit(log);
                }

                db.SubmitChanges();
            }

            this.Close();
        }

    }
}
