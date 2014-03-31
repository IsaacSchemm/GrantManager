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
    /// Allows editing the contact history of a grant.
    /// This information includes who contacted the grantor, when, and how.
    /// </summary>
    public partial class ContactHistory : Form
    {
        private int? currentlyEditingId;

        /// <summary>
        /// Initializes window.
        /// </summary>
        /// <param name="id">Id of the grant whose contact history is being edited.</param>
        public ContactHistory(int id)
        {
            InitializeComponent();

            currentlyEditingId = id;

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                //appraoches dropdown
                approachDropdown.DisplayMember = "approach_type";
                approachDropdown.ValueMember = "approach_id";
                approachDropdown.DataSource = db.approaches;

                //user dropdown
                contactedByDropdown.DisplayMember = "display_name";
                contactedByDropdown.ValueMember = "username";
                contactedByDropdown.DataSource = db.users;

            }

            submitButton.Click += new EventHandler(EditContactHistory);
        }

        /// <summary>
        /// Called on window load.
        /// Fills in old values if they exist. 
        /// </summary>
        public void ContactHistory_Load(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                contact_history ch = (from c in db.contact_histories
                                      where c.grant_id == currentlyEditingId
                                      select c).FirstOrDefault();
				
                //if contact history was not previously edited, one will not exist
                if (ch != null)
                {
                    this.approachDropdown.SelectedValue = ch.initial_approach_id;
                    this.contactNameText.Text = ch.contact_name;
                    this.callDatePicker.Value = (DateTime)ch.call_date;
                    this.outcomeText.Text = ch.outcome;
                    this.contactedByDropdown.SelectedValue = ch.contacted_by;
                    this.notesText.Text = ch.notes;
                }
				else
				{
					this.contactedByDropdown.SelectedValue = Login.currentUser;
				}
            }
        }

        /// <summary>
        /// Submits changes to contact history to database.
        /// </summary>
        public void EditContactHistory(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                //find contact history for grant
                var ch = (from c in db.contact_histories
                          where c.grant_id == currentlyEditingId
                          select c).FirstOrDefault();

                //summary of old history
                string oldContactHistorySummary;

                //if this grant didn't have a contact history, add it here
                if (ch == null)
                {
                    oldContactHistorySummary = null;
                    ch = new contact_history
                    {
                        grant_id = (int)currentlyEditingId,
                        initial_approach_id = (int)this.approachDropdown.SelectedValue,
                        contact_name = this.contactNameText.Text,
                        call_date = this.callDatePicker.Value,
                        outcome = this.outcomeText.Text,
                        contacted_by = (string)this.contactedByDropdown.SelectedValue,
                        notes = this.notesText.Text
                    };

                    db.contact_histories.InsertOnSubmit(ch);
                }
                //otherwise just edit values
                else
                {
                    oldContactHistorySummary = ch.ToString();

                    //approach id is foreign key, so must reassign object and not value
                    //otherwise error will be thrown (ForeignKeyReferenceAlreadyHasValueException)
                    ch.approach = db.approaches.Single(a => a.approach_id == (int)this.approachDropdown.SelectedValue);
                    
                    ch.contact_name = this.contactNameText.Text;
                    ch.call_date = this.callDatePicker.Value;
                    ch.outcome = this.outcomeText.Text;

                    //contacted by user is also a foreign key
                    ch.user = db.users.Single(u => u.username == (string)this.contactedByDropdown.SelectedValue);

                    ch.notes = this.notesText.Text;
				}

				//submit changes here to update "approach" field, so changelog is rendered correctly
				db.SubmitChanges();

                //write to change log
				if (Settings.EnableChangelog) {
					string newContactHistorySummary = ch.ToString();
					changelog log = new changelog() {
						object_edited = "contact history for " + db.grants.Where(g => g.grant_id == currentlyEditingId).First().grant_name,
						username = Login.currentUser,
						date = DateTime.Now,
					};
					if (oldContactHistorySummary != null) {
						log.details = oldContactHistorySummary + " => " + newContactHistorySummary;
					} else {
						log.details = "Added: " + newContactHistorySummary;
					}
					db.changelogs.InsertOnSubmit(log);
				}

                //submit changelog and contact history changes to database
                db.SubmitChanges();
            }

            //close window
            this.Close();
        }

    }
}
