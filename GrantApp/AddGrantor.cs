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
    /// Window that allows editing and adding grantors.
    /// </summary>
    public partial class AddGrantor : Form
    {
        private int? currentlyEditingID;
        private ComboBox grantorDropdown;

        /// <summary>
        /// Initializes window if adding new grantor.
        /// Populates state dropdown.
        /// </summary>
        public AddGrantor()
        {
            InitializeComponent();
            
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                //state dropdown list
                dropState.DisplayMember = "state_name";
                dropState.ValueMember = "state_id";
                dropState.DataSource = db.states;
            }

            //validation for adding grantors
            //must have a name, and average gift field must be a number or null
            this.FormClosing += BeforeClose;

            #region validation
            txtName.Validating += (o, e) => {
                if (txtName.Text.Length == 0) {
                    e.Cancel = true;
                    MessageBox.Show(this, "You must enter a name for the grantor.");
                }
            };
            txtAvgGift.Validating += (o, e) => {
                decimal tmp;
                if (txtAvgGift.Text.Length > 0 && !decimal.TryParse(txtAvgGift.Text, out tmp)) {
                    e.Cancel = true;
                    MessageBox.Show(this, "You must enter a valid number for Average Gift, or leave the field blank.");
                }
            };
            #endregion
        }

        /// <summary>
        /// Opens window when editing old grantor.
        /// </summary>
        /// <param name="id">Id of the grantor being edited.</param>
        public AddGrantor(int id) : this() {
            currentlyEditingID = id;
        }

        /// <summary>
        /// Opens window when adding grantor from AddGrant window.
        /// Dropdown list is passed so list can be updated with newly added grantor.
        /// </summary>
        public AddGrantor(ComboBox dropdown)
            : this()
        {
            grantorDropdown = dropdown;
        }

        /// <summary>
        /// Fills in fields if editing old grantor.
        /// </summary>
        private void AddGrantor_Load(object sender, EventArgs e)
        {
            if (currentlyEditingID != null) {
                using (DataClasses1DataContext db = new DataClasses1DataContext()) {
                    grantor currentlyEditing = (from g in db.grantors
                                                where g.grantor_id == currentlyEditingID
                                                select g).First();

                    this.txtAddress.Text = currentlyEditing.address;
                    this.txtCity.Text = currentlyEditing.city;
                    this.txtContactName.Text = currentlyEditing.contact_name;
                    this.txtContactTitle.Text = currentlyEditing.contact_title;
                    this.txtEmail.Text = currentlyEditing.email;
                    this.txtFax.Text = currentlyEditing.fax;
                    this.txtName.Text = currentlyEditing.organization_name;
                    this.txtPhone.Text = currentlyEditing.phone;
                    this.dropState.SelectedValue = currentlyEditing.state_id;
                    this.txtZip.Text = currentlyEditing.zipcode;
                    this.txtTypeOfSupport.Text = currentlyEditing.types_of_support;
                    this.txtAvgGift.Text = currentlyEditing.average_gift.ToString();
                    this.txtGivingHistory.Text = currentlyEditing.giving_history;
                    this.txtBuzzwords.Text = currentlyEditing.buzzwords;
                    this.txtNotes.Text = currentlyEditing.notes;
                }
            }
        }

        /// <summary>
        /// Submits changes to database.
        /// Called from "before close" so that validation is called automatically.
        /// </summary>
        private void BeforeClose(object sender, FormClosingEventArgs e)
        {
            //if window was not closed from OK button, don't update database
            if (DialogResult != DialogResult.OK) {
                return;
            }
            //don't update database if validation doesn't pass
            else if (!ValidateChildren()) {
                e.Cancel = true;
                return;
            }

            // error checking for inputs
            //average gift must be a number
            decimal tmp;
            decimal? avggift;
            if (Decimal.TryParse(this.txtAvgGift.Text, out tmp)) {
                avggift = tmp;
            } else {
                avggift = null;
            }

            int grantor_id_added_or_edited;

            //summary of old grantor
            grantor oldGrantor;
            using (DataClasses1DataContext db = new DataClasses1DataContext()) {
                oldGrantor = (from g in db.grantors
                              where g.grantor_id == currentlyEditingID
                              select g).FirstOrDefault();
            }
            using (DataClasses1DataContext db = new DataClasses1DataContext()) {

                //editing old grantor
                if (currentlyEditingID != null) {

                    //find grantor
                    grantor currentlyEditing = (from g in db.grantors
                                                where g.grantor_id == currentlyEditingID
                                                select g).First();

                    //update values
                    currentlyEditing.address = this.txtAddress.Text;
                    currentlyEditing.city = this.txtCity.Text;
                    currentlyEditing.contact_name = this.txtContactName.Text;
                    currentlyEditing.contact_title = this.txtContactTitle.Text;
                    currentlyEditing.email = this.txtEmail.Text;
                    currentlyEditing.fax = this.txtFax.Text;
                    currentlyEditing.organization_name = this.txtName.Text;
                    currentlyEditing.phone = this.txtPhone.Text;
                    currentlyEditing.state_id = (string)this.dropState.SelectedValue;
                    currentlyEditing.zipcode = this.txtZip.Text;
                    currentlyEditing.types_of_support = this.txtTypeOfSupport.Text;
                    currentlyEditing.average_gift = avggift;
                    currentlyEditing.giving_history = this.txtGivingHistory.Text;
                    currentlyEditing.buzzwords = this.txtBuzzwords.Text;
                    currentlyEditing.notes = this.txtNotes.Text;

                    grantor_id_added_or_edited = currentlyEditingID.Value;
                }
                //adding new grantor
                else {
                    grantor g = new grantor {
                        address = this.txtAddress.Text,
                        city = this.txtCity.Text,
                        contact_name = this.txtContactName.Text,
                        contact_title = this.txtContactTitle.Text,
                        email = this.txtEmail.Text,
                        fax = this.txtFax.Text,
                        organization_name = this.txtName.Text,
                        phone = this.txtPhone.Text,
                        state_id = ((state)this.dropState.SelectedItem).state_id,
                        zipcode = this.txtZip.Text,
                        types_of_support = this.txtTypeOfSupport.Text,
                        average_gift = avggift,
                        giving_history = this.txtGivingHistory.Text,
                        buzzwords = this.txtBuzzwords.Text,
                        notes = this.txtNotes.Text,
                    };
                    db.grantors.InsertOnSubmit(g);

                    //submit grantor here so it has an id to put in linking table
                    db.SubmitChanges();

                    grantor_id_added_or_edited = g.grantor_id;
                }

                //write to change log
                if (Settings.EnableChangelog) {
                    var newGrantor = (from g in db.grantors
                                      where g.grantor_id == grantor_id_added_or_edited
                                      select g).First();
                    changelog log = new changelog() {
                        object_edited = "grantor " + this.txtName.Text,
                        username = Login.currentUser,
                        date = DateTime.Now,
                    };
                    log.details = "Add/edit: " + Comparison<grantor>.Compare(oldGrantor, newGrantor);
                    db.changelogs.InsertOnSubmit(log);
                }

                db.SubmitChanges();
            }

            //if add grantor panel was opened from add grant, refresh the list of grantors in add grant
            if (grantorDropdown != null)
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    grantorDropdown.DisplayMember = "organization_name";
                    grantorDropdown.ValueMember = "grantor_id";
                    grantorDropdown.DataSource = db.grantors;
                }
            }
        }

    }
}
