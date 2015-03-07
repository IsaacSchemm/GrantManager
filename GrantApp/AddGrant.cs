using KellermanSoftware.CompareNetObjects;
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
    /// Window for adding or editing grants.
    /// </summary>
    public partial class AddGrant : Form
    {
        private int? currentlyEditingID;

        /// <summary>
        /// Initializes AddGrant window.
        /// Populates lists of projects, grantors, etc. with the values in the database.
        /// </summary>
        public AddGrant()
        {
            InitializeComponent();

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                //grantor dropdown
                grantorDropdown.DisplayMember = "organization_name";
                grantorDropdown.ValueMember = "grantor_id";
                grantorDropdown.DataSource = db.grantors;

                //status dropdown
                statusDropdown.DisplayMember = "description";
                statusDropdown.ValueMember = "status_id";
                statusDropdown.DataSource = db.status_types;

                //grant writer dropdown
                grantWriterDropdown.DisplayMember = "display_name";
                grantWriterDropdown.ValueMember = "username";
                grantWriterDropdown.DataSource = db.users;

                //programs list
                programsList.DisplayMember = "program_name";
                programsList.ValueMember = "program_id";

                //projects list
                projectsList.DisplayMember = "project_name";
                projectsList.ValueMember = "project_id";

                //doc type list
                requirementsList.DisplayMember = "name";
                requirementsList.ValueMember = "documentation_type_id";
            }

            addGrantorButton.Click += new EventHandler(AddGrantorFromGrant);
            //addProgramButton.Click += new EventHandler(AddProgramFromGrant);

            //validation for adding grants
            //grant must have a name and requested amount, and request/actual amounts must both be numbers
            this.FormClosing += BeforeClose;

            #region validation
            grantNameText.Validating += (o, e) => {
                if (grantNameText.Text.Length == 0) {
                    e.Cancel = true;
                    MessageBox.Show(this, "You must enter a name for the grant.");
                }
            };
            requestedAmountText.Validating += (o, e) => {
                decimal tmp;
                if (!decimal.TryParse(requestedAmountText.Text.Replace("$", ""), out tmp)) {
                    e.Cancel = true;
                    MessageBox.Show(this, "You must enter a valid number for Requested Amount.");
                }
            };
            actualAmountText.Validating += (o, e) => {
                decimal tmp;
                if (actualAmountText.TextLength > 0 && !decimal.TryParse(actualAmountText.Text.Replace("$", ""), out tmp)) {
                    e.Cancel = true;
                    MessageBox.Show(this, "You must enter a valid number for Actual Amount, or leave the field empty.");
                }
            };
            #endregion
        }

        /// <summary>
        /// Initializes window when editing an old grant.
        /// </summary>
        /// <param name="id">Id of the grant being edited.</param>
        public AddGrant(int id) : this() {
            currentlyEditingID = id;
        }

        /// <summary>
        /// Loads values into fields if an old grant is being edited.
        /// Some fields are also manipulated when adding a new grant.
        /// </summary>
        private void AddGrant_Load(object sender, EventArgs e)
        {
            //if adding new grant
            if (currentlyEditingID == null)
            {
                //default grant writer to current user
                this.grantWriterDropdown.SelectedValue = Login.currentUser;

                //don't select any programs, projects, or doc types
                //first item in list box is selected by default
                this.programsList.ClearSelected();
                this.projectsList.ClearSelected();
                this.requirementsList.ClearSelected();

                addAttachmentButton.Enabled = false;
            }

            //only fill in other values if editing an old grant
            if (currentlyEditingID != null)
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    grant currentlyEditing = (from g in db.grants
                                                where g.grant_id == currentlyEditingID
                                                select g).First();
                   
                    this.grantNameText.Text = currentlyEditing.grant_name;
                    this.grantDescText.Text = currentlyEditing.grant_description;
                    this.grantorDropdown.SelectedValue = currentlyEditing.grantor_id;

                    //if dates are not null, check the boxes and enable the date pickers initially
                    if (currentlyEditing.submit_date.HasValue) { 
                        this.cbSubmit.Checked = true; 
                        this.submitDatePicker.Value = (DateTime)currentlyEditing.submit_date;
                        this.submitDatePicker.Enabled = true; }
                    if (currentlyEditing.due_date.HasValue) { 
                        this.cbDue.Checked = true;
                        this.dueDatePicker.Value = (DateTime)currentlyEditing.due_date;
                        this.dueDatePicker.Enabled = true; }
                    if (currentlyEditing.turnaround_time.HasValue) { 
                        this.cbTurnAround.Checked = true;
                        this.turnaroundPicker.Value = (DateTime)currentlyEditing.turnaround_time;
                        this.turnaroundPicker.Enabled = true; }
                    if (currentlyEditing.start_date.HasValue) { 
                        this.cbStart.Checked = true; 
                        this.startDatePicker.Value = (DateTime)currentlyEditing.start_date;
                        this.startDatePicker.Enabled = true; }
                    if (currentlyEditing.payment_date.HasValue) { 
                        this.cbPayment.Checked = true; 
                        this.paymentDatePicker.Value = (DateTime)currentlyEditing.payment_date;
                        this.paymentDatePicker.Enabled = true; }
                    this.requestedAmountText.Text = currentlyEditing.grant_requested_amount.ToString("$0.00");
                    this.actualAmountText.Text = currentlyEditing.grant_actual_amount == null ? "" : currentlyEditing.grant_actual_amount.Value.ToString("$0.00");
                    this.statusDropdown.SelectedValue = currentlyEditing.status;
                    this.grantorWebsiteText.Text = currentlyEditing.grantor_website;
                    this.grantorUsernameText.Text = currentlyEditing.grantor_username;
                    this.grantorPasswordText.Text = currentlyEditing.grantor_password;
                    this.emphasisText.Text = currentlyEditing.program_emphasis;

                    // if there is no grant writer, default to logged in user - fixes bug with listbox not clearing
                    this.grantWriterDropdown.SelectedValue = currentlyEditing.grant_writer ?? Login.currentUser;
                    this.grantNotesText.Text = currentlyEditing.notes;

                    //read programs list from linking table
                    var programs = (from gp in db.grant_programs
                                    join p in db.programs on gp.program_id equals p.program_id
                                    where gp.grant_id == currentlyEditingID
                                    select p);

                    //add programs to list box that are connected to this grant
                    programsList.Items.AddRange(programs.ToArray());

                    //read projects list from linking table
                    var projects = (from gp in db.grant_projects
                                    join p in db.projects on gp.project_id equals p.project_id
                                    where gp.grant_id == currentlyEditingID
                                    select p);

                    this.projectsList.Items.Clear();
                    this.projectsList.Items.AddRange(projects.ToArray());

                    //read documentation types list from linking table
                    var doctypes = (from dr in db.documentation_requirements
                                    join d in db.documentation_types on dr.documentation_type_id equals d.documentation_type_id
                                    where dr.grant_id == currentlyEditingID
                                    select d);

                    //add doc types to list box that are connected to this grant
                    requirementsList.Items.AddRange(doctypes.ToArray());
                }
            }

            UpdateAttachmentsList();
        }

        /// <summary>
        /// Submits changes to database.
        /// Part of "before close" event so that validation is automatically called.
        /// </summary>
        private void BeforeClose(object sender, FormClosingEventArgs e)
        {
            //if not closing window because OK was clicked, don't update database
            if (DialogResult != DialogResult.OK) {
                return;
            }
            //likewise don't update database if validation doesn't pass
            else if (!ValidateChildren()) {
                e.Cancel = true;
                return;
            }

            // error checking for money inputs - parse to decimal number
            decimal requested;
            if (!Decimal.TryParse(this.requestedAmountText.Text.Replace("$", ""), out requested))
            {
                requested = 0;
            }

            decimal? actual;
            decimal tmp;
            if (Decimal.TryParse(this.actualAmountText.Text.Replace("$", ""), out tmp)) {
                actual = tmp;
            } else {
                actual = null;
            }

            int grant_id_added_or_edited;

            //summary of old grant - used to write to change log
            grant oldGrant;
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                oldGrant = (from g in db.grants
                            where g.grant_id == currentlyEditingID
                            select g).FirstOrDefault();
            }

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                //editing old grant
                if (currentlyEditingID != null)
                {
                    //find grant
                    grant currentlyEditing = (from g in db.grants
                                                where g.grant_id == currentlyEditingID
                                                select g).First();

                    //change values
                    currentlyEditing.grant_name = this.grantNameText.Text;
                    currentlyEditing.grant_description = this.grantDescText.Text;

                    //look up grantor based on id to reassign foreign key
                    //cannot just change int value or error will occur (ForeignKeyReferenceAlreadyHasValueException)
                    currentlyEditing.grantor = db.grantors.Single(g => g.grantor_id == (int)this.grantorDropdown.SelectedValue);

                    //record null for dates if checkboxes were not checked
                    if (!cbSubmit.Checked) { currentlyEditing.submit_date = null; }
                    else { currentlyEditing.submit_date = this.submitDatePicker.Value.Date; }
                    if (!cbDue.Checked) { currentlyEditing.due_date = null; }
                    else{currentlyEditing.due_date = this.dueDatePicker.Value.Date;}
                    if (!cbTurnAround.Checked) { currentlyEditing.turnaround_time = null; }
                    else { currentlyEditing.turnaround_time = this.turnaroundPicker.Value.Date; }
                    if (!cbStart.Checked) { currentlyEditing.start_date = null; }
                    else { currentlyEditing.start_date = this.startDatePicker.Value.Date; }
                    if (!cbPayment.Checked) { currentlyEditing.payment_date = null; }
                    else { currentlyEditing.payment_date = this.paymentDatePicker.Value.Date; }
                    currentlyEditing.grant_requested_amount = requested;
                    currentlyEditing.grant_actual_amount = actual;

                    //must look up status value as with grantor
                    currentlyEditing.status_type = db.status_types.Single(s => s.status_id == (int)this.statusDropdown.SelectedValue);

                    currentlyEditing.grantor_website = this.grantorWebsiteText.Text;
                    currentlyEditing.grantor_username = this.grantorUsernameText.Text;
                    currentlyEditing.grantor_password = this.grantorPasswordText.Text;
                    currentlyEditing.program_emphasis = this.emphasisText.Text;

                    //user is also foreign key, so look it up
                    currentlyEditing.user = db.users.Single(u => u.username == (string)this.grantWriterDropdown.SelectedValue);

                    currentlyEditing.notes = this.grantNotesText.Text;

                    //remove old values in grant_programs table corresponding to this grant
                    var deleteOldProgramLinks = from gp in db.grant_programs
                                         where gp.grant_id == currentlyEditingID
                                         select gp;

                    foreach (var gp in deleteOldProgramLinks)
                    {
                        db.grant_programs.DeleteOnSubmit(gp);
                    }

                    //remove old values in project linking table corresponding to this grant
                    var deleteOldProjectLinks = from gp in db.grant_projects
                                                where gp.grant_id == currentlyEditingID
                                                select gp;

                    foreach (var gp in deleteOldProjectLinks)
                    {
                        db.grant_projects.DeleteOnSubmit(gp);
                    }

                    //remove old values in documentation_requirements corresponding to this grant
                    var deleteOldDocLinks = from dr in db.documentation_requirements
                                         where dr.grant_id == currentlyEditingID
                                         select dr;

                    foreach (var gp in deleteOldDocLinks)
                    {
                        db.documentation_requirements.DeleteOnSubmit(gp);
                    }

                    //submit changes
                    db.SubmitChanges();

                    grant_id_added_or_edited = currentlyEditingID.Value;
                }
                //add new grant
                else
                {
                    grant g = new grant
                    {
                        grant_name = this.grantNameText.Text,
                        grant_description = this.grantDescText.Text,
                        grantor_id = (int)this.grantorDropdown.SelectedValue,
                        submit_date = this.getSubmit(),
                        due_date = this.getDueDate(),
                        turnaround_time = this.getTurnaround(),
                        start_date = this.getStart(),
                        payment_date = this.getPayment(),
                        grant_requested_amount = requested,
                        grant_actual_amount = actual,
                        status = (int)this.statusDropdown.SelectedValue,
                        grantor_website = this.grantorWebsiteText.Text,
                        grantor_username = this.grantorUsernameText.Text,
                        grantor_password = this.grantorPasswordText.Text,
                        program_emphasis = this.emphasisText.Text,
                        grant_writer = (string)this.grantWriterDropdown.SelectedValue,
                        notes = this.grantNotesText.Text,
                    };

                    db.grants.InsertOnSubmit(g);

                    //submit grant here so it has an id to put in linking table
                    db.SubmitChanges();

                    grant_id_added_or_edited = g.grant_id;
                }

                //add entry in grant-program linking table for every program in the list
                foreach (program p in this.programsList.Items)
                {
                    grant_program gp = new grant_program
                    {
                        grant_id = grant_id_added_or_edited,
                        program_id = p.program_id
                    };

                    db.grant_programs.InsertOnSubmit(gp);
                }

                //add entry in grant-documentation linking table for every doc type in the list
                foreach (documentation_type d in this.requirementsList.Items)
                {
                    documentation_requirement dr = new documentation_requirement
                    {
                        grant_id = grant_id_added_or_edited,
                        documentation_type_id = d.documentation_type_id
                    };

                    db.documentation_requirements.InsertOnSubmit(dr);
                }

                //add entry in grant-project linking table for every project in the list
                foreach (project p in this.projectsList.Items)
                {
                    grant_project gp = new grant_project
                    {
                        grant_id = grant_id_added_or_edited,
                        project_id = p.project_id
                    };

                    db.grant_projects.InsertOnSubmit(gp);
                }

                //submit linking table updates
                db.SubmitChanges();
            }

            //write to change log
            // This needs to be in a new DataContext because the linking tables have been updated.
            if (Settings.EnableChangelog) {
                using (DataClasses1DataContext db = new DataClasses1DataContext()) {
                    var newGrant = (from g in db.grants
                                    where g.grant_id == grant_id_added_or_edited
                                    select g).First();
                    changelog log = new changelog() {
                        object_edited = "grant " + this.grantNameText.Text,
                        username = Login.currentUser,
                        date = DateTime.Now,
                    };
                    //write old and new summaries if editing, otherwise just write new summary
                    log.details = "Add/edit: " + Comparison<grant>.Compare(oldGrant, newGrant);
                    db.changelogs.InsertOnSubmit(log);

                    //update database
                    db.SubmitChanges();
                }
            }
        }

        /// <summary>
        /// Opens AddGrantor window.
        /// Allows adding a new grantor to database while editing a grant.
        /// </summary>
        private void AddGrantorFromGrant(object sender, EventArgs e)
        {
            new AddGrantor().ShowDialog(this);
            // refresh grantors
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                //grantor dropdown
                grantorDropdown.DisplayMember = "organization_name";
                grantorDropdown.ValueMember = "grantor_id";
                grantorDropdown.DataSource = db.grantors;
            }
           // MessageBox.Show("testing");
        }

        /// <summary>
        /// Opens AddProgram window.
        /// Allows adding a new program to database while editing a grant.
        /// </summary>
        private void AddProgramFromGrant(object sender, EventArgs e)
        {
            new AddProgram(programsList).ShowDialog(this);
        }

        /*/// <summary>
        /// Opens AddProject window.
        /// Allows adding a new project to database while editing a grant.
        /// </summary>
        private void AddProjectFromGrant(object sender, EventArgs e)
        {
            new AddProject().ShowDialog(this);
            //projects list
            projectsList.Items.Clear();
            projectsList.DisplayMember = "project_name";
            projectsList.ValueMember = "project_id";
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var q2 = from p in db.projects
                         select p;

                foreach (project p in q2)
                {
                    projectsList.Items.Add(p);
                }
            }
        }*/

        /// <summary>
        /// Opens AddDocumentation window.
        /// Allows adding a new doc type to database while editing a grant.
        /// </summary>
        private void docButton_Click(object sender, EventArgs e)
        {
            new AddDocumentationType(requirementsList).ShowDialog(this);
        }

        //getters for date fields
        //return null if the associated checkbox is not checked
        //dates are not submitted to database unless associated checkbox is selected
        private Nullable<DateTime> getSubmit()
        {
            if (!cbSubmit.Checked) { return null; }
            else { return this.submitDatePicker.Value.Date; }
        }
        private Nullable<DateTime> getDueDate()
        {
            if (!cbDue.Checked) { return null; }
            else { return this.dueDatePicker.Value.Date; }
        }
        private Nullable<DateTime> getTurnaround()
        {
            if (!cbTurnAround.Checked) { return null; }
            else { return this.turnaroundPicker.Value.Date; }
        }
        private Nullable<DateTime> getStart()
        {
            if (!cbStart.Checked) { return null; }
            else { return this.startDatePicker.Value.Date; }
        }
        private Nullable<DateTime> getPayment()
        {
            if (!cbPayment.Checked) { return null; }
            else { return this.paymentDatePicker.Value.Date; }
        }

        private void UpdateAttachmentsList() {
            using (DataClasses1DataContext db = new DataClasses1DataContext()) {
                attachmentsList.Items.Clear();
                attachmentsList.DisplayMember = "filename";
                foreach (var a in db.attachments.Where(a => a.grant_id == currentlyEditingID)) {
                    attachmentsList.Items.Add(a);
                }
            }
            editAttachmentButton.Enabled = (attachmentsList.SelectedIndex > -1);
        }

        //submit button for form
        //currently does nothing, as submitting is handled by "before close" event
        private void grantSubmitButton_Click(object sender, EventArgs e)
        {
            
        }

        //returns whether the checkboxes for each date picker are checked
        private void cbSubmit_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSubmit.Checked)
            {
                submitDatePicker.Enabled = true;
            }
            else
            {
                submitDatePicker.Enabled = false;
            }
        }
        private void cbDue_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDue.Checked)
            {
                dueDatePicker.Enabled = true;
            }
            else
            {
                dueDatePicker.Enabled = false;
            }
        }
        private void cbTurnAround_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTurnAround.Checked)
            {
                turnaroundPicker.Enabled = true;
            }
            else
            {
                turnaroundPicker.Enabled = false;
            }
        }
        private void cbStart_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStart.Checked)
            {
                startDatePicker.Enabled = true;
            }
            else
            {
                startDatePicker.Enabled = false;
            }
        }
        private void cbPayment_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPayment.Checked)
            {
                paymentDatePicker.Enabled = true;
            }
            else
            {
                paymentDatePicker.Enabled = false;
            }
        }

        private void addAttachmentButton_Click(object sender, EventArgs e) {
            if (currentlyEditingID == null) {
                MessageBox.Show("You must add a grant to the database before uploading attachments.");
            } else {
                new AttachmentForm(currentlyEditingID.Value).ShowDialog(this);
                UpdateAttachmentsList();
            }
        }

        private void editAttachmentButton_Click(object sender, EventArgs e) {
            if (currentlyEditingID == null) {
                MessageBox.Show("You must add a grant to the database before uploading attachments.");
            } else {
                attachment a = attachmentsList.SelectedItem as attachment;
                if (a == null) {
                    MessageBox.Show("No attachment is selected.");
                } else {
                    new AttachmentForm(currentlyEditingID.Value, a.attachment_id).ShowDialog(this);
                    UpdateAttachmentsList();
                }
            }
        }

        private void attachmentsList_SelectedIndexChanged(object sender, EventArgs e) {
            editAttachmentButton.Enabled = (attachmentsList.SelectedIndex > -1);
        }

        private void addProjectButton_Click(object sender, EventArgs e) {
            project p = SelectItemToAddDialog.SelectProject();
            if (p != null) {
                foreach (project item in projectsList.Items) {
                    if (item.project_id == p.project_id) return; // already in list
                }
                projectsList.Items.Add(p);
            }
        }

        private void deleteProjectButton_Click(object sender, EventArgs e) {
            projectsList.Items.Remove(projectsList.SelectedItem);
        }

        private void projectsList_SelectedIndexChanged(object sender, EventArgs e) {
            deleteProjectButton.Enabled = (projectsList.SelectedIndex > -1);
        }

        private void addProgramButton_Click(object sender, EventArgs e) {
            program p = SelectItemToAddDialog.SelectProgram();
            if (p != null) {
                foreach (program item in programsList.Items) {
                    if (item.program_id == p.program_id) return; // already in list
                }
                programsList.Items.Add(p);
            }
        }

        private void deleteProgramButton_Click(object sender, EventArgs e) {
            programsList.Items.Remove(programsList.SelectedItem);
        }

        private void programsList_SelectedIndexChanged(object sender, EventArgs e) {
            deleteProgramButton.Enabled = (programsList.SelectedIndex > -1);
        }

        private void addDocTypeButton_Click(object sender, EventArgs e) {
            documentation_type d = SelectItemToAddDialog.SelectDocumentationType();
            if (d != null) {
                foreach (documentation_type item in requirementsList.Items) {
                    if (item.documentation_type_id == d.documentation_type_id) return; // already in list
                }
                requirementsList.Items.Add(d);
            }
        }

        private void deleteDocTypeButton_Click(object sender, EventArgs e) {
            requirementsList.Items.Remove(requirementsList.SelectedItem);
        }

        private void documentationList_SelectedIndexChanged(object sender, EventArgs e) {
            deleteDocTypeButton.Enabled = (requirementsList.SelectedIndex > -1);
        }

    }
}
