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
    /// Window for adding documentation types to database.
    /// Documentation types represent types of forms that may be associated with a grant.
    /// </summary>
    public partial class AddDocumentationType : Form
    {
        private ListBox documentationTypesList;
        private int? currentlyEditingId;

        /// <summary>
        /// Initializes window when adding a new documentation type.
        /// </summary>
        public AddDocumentationType()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes window when editing an old documentation type.
        /// </summary>
        /// <param name="id">The id of the doc type being edited.</param>
        public AddDocumentationType(int id)
            : this()
        {
            currentlyEditingId = id;
        }

        /// <summary>
        /// Initializes window when adding a new documentation type from the AddGrant window.
        /// The listbox represents the list box of doc types in the AddGrant window, and is passed to this window
        ///     so it can be repopulated with an updated list after new doc type is added.
        /// </summary>
        public AddDocumentationType(ListBox pl)
            : this()
        {
            documentationTypesList = pl;
        }

        /// <summary>
        /// Fills in field values if editing an old doc type.
        /// </summary>
        private void AddDoc_Load(object sender, EventArgs e)
        {
            //if adding new doc type
            if (currentlyEditingId == null)
            {
                //nothing selected
            }

            //only fill in other values if editing an old doc type
            if (currentlyEditingId != null)
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    documentation_type currentlyEditing = (from d in db.documentation_types
                                                           where d.documentation_type_id == currentlyEditingId
                                                           select d).First();

                    this.docTypeName.Text = currentlyEditing.name;
                }
            }
        }

        /// <summary>
        /// Submits changes to database.
        /// </summary>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //doc type must have name
            if (docTypeName.Text == "")
            {
                MessageBox.Show("You must enter a name for the documentation type.");
            }
            else
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    //editing
                    if (currentlyEditingId != null)
                    {
                        documentation_type currentlyEditing = (from d in db.documentation_types
                                                              where d.documentation_type_id == currentlyEditingId
                                                              select d).First();

                        currentlyEditing.name = docTypeName.Text;
                    }
                    //adding
                    else
                    {
                        documentation_type d = new documentation_type
                        {
                            name = docTypeName.Text
                        };

                        db.documentation_types.InsertOnSubmit(d);

                        //add to list of doc types if adding doc type from add grant screen
                        if (documentationTypesList != null)
                        {
                            documentationTypesList.Items.Add(d);
                        }
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
