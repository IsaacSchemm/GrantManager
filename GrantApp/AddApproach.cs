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
    /// Used for adding approaches to the database.
    /// Approaches are ways in which employees made contact with potential grantors.
    /// </summary>
    public partial class AddApproach : Form
    {
        int? currentlyEditingId;

        /// <summary>
        /// Initializes AddApproach window when adding a new approach.
        /// </summary>
        public AddApproach()
        {
            InitializeComponent();

            btnSubmit.Click += new EventHandler(btnSubmit_Click);
        }

        /// <summary>
        /// Initializes AddApproach window when editing an old approach.
        /// </summary>
        /// <param name="id">The id of the approach being edited.</param>
        public AddApproach(int id)
            : this()
        {
            currentlyEditingId = id;
        }

        /// <summary>
        /// Fills in field values if editing an old approach.
        /// </summary>
        private void AddApproach_Load(object sender, EventArgs e)
        {
            //if adding new approach
            if (currentlyEditingId == null)
            {
                //nothing selected
            }

            //only fill in other values if editing an old approach
            if (currentlyEditingId != null)
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    approach currentlyEditing = (from a in db.approaches
                                                 where a.approach_id == currentlyEditingId
                                                 select a).First();

                    this.approachType.Text = currentlyEditing.approach_type;
                }
            }
        }

        /// <summary>
        /// Inserts new approach into database or updates an old one.
        /// </summary>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //can't add an apporach without a type
            if (approachType.Text == "")
            {
                MessageBox.Show("You must enter a type for the approach.");
            }
            else
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    //editing old approach
                    if (currentlyEditingId != null)
                    {
                        approach currentlyEditing = (from a in db.approaches
                                                     where a.approach_id == currentlyEditingId
                                                     select a).First();

                        currentlyEditing.approach_type = approachType.Text;
                    }
                    //adding new approach
                    else
                    {
                        approach a = new approach
                        {
                            approach_type = approachType.Text
                        };

                        db.approaches.InsertOnSubmit(a);
                    }

                    //submit changes
                    db.SubmitChanges();
                }

                //close window
                this.Close();
            }
        }

    }
}
