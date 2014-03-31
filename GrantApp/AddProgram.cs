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
    /// Window for adding programs to database.
    /// </summary>
    public partial class AddProgram : Form
    {
        private ListBox programsList;
        private int? currentlyEditingId;

        /// <summary>
        /// Initializes window when adding a new program.
        /// </summary>
        public AddProgram()
        {
            InitializeComponent();

            programSubmitButton.Click += new EventHandler(Add_Program);
        }

        /// <summary>
        /// Initializes window when editing an old program.
        /// </summary>
        /// <param name="id">Id of program being edited.</param>
        public AddProgram(int id)
            : this()
        {
            currentlyEditingId = id;
        }

        /// <summary>
        /// Initializes window when adding a program from AddGrant window.
        /// List box is passed so list can be updated with new program after adding.
        /// </summary>
        public AddProgram(ListBox list)
            : this()
        {
            programsList = list;
        }

        /// <summary>
        /// Fills in values when editing a program.
        /// </summary>
        public void AddProgram_Load(object sender, EventArgs e)
        {
            //only fill in values if editing a program
            if (currentlyEditingId != null)
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    program currentlyEditing = (from p in db.programs
                                                where p.program_id == currentlyEditingId
                                                select p).First();

                    this.programNameText.Text = currentlyEditing.program_name;
                    this.programDescText.Text = currentlyEditing.program_description;
                }
            }
        }

        /// <summary>
        /// Submits changes to database.
        /// </summary>
        /// 
        public void Add_Program(object sender, EventArgs e)
        {
            //can't add unless program has a name
            if (programNameText.Text == "")
            {
                MessageBox.Show("Program must have a name.");
                return;
            }

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                //editing old program
                if (currentlyEditingId != null)
                {
                    program currentlyEditing = (from p in db.programs
                                                where p.program_id == (int)currentlyEditingId
                                                select p).First();

                    currentlyEditing.program_name = this.programNameText.Text;
                    currentlyEditing.program_description = this.programDescText.Text;
                }
                //adding new program
                else
                {
                    program p = new program
                    {
                        program_name = this.programNameText.Text,
                        program_description = this.programDescText.Text
                    };

                    db.programs.InsertOnSubmit(p);

                    if (programsList != null)
                    {
                        programsList.Items.Add(p);
                    }
                }

                //submit changes
                db.SubmitChanges();
            }

            this.Close();
        }

    }
}
