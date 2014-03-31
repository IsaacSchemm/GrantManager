using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace GrantApp
{
    /// <summary>
    /// Window for managing users, programs, doc types, and approaches.
    /// </summary>
    public partial class Administration : Form
    {
        private bool admin;

        /// <summary>
        /// Initializes window.
        /// </summary>
        public Administration()
        {
            InitializeComponent();

            //determine if user is an admin
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                admin = db.users.Where(u => u.username == Login.currentUser).First().admin;
            }

            //if not an admin, the user can only change their password, not manipulate other users
            if (!admin) userButton.Text = "Change Password";

            backButton.Click += new EventHandler(backButton_Click);
            userButton.Click += new EventHandler(userButton_Click);
            docButton.Click += new EventHandler(docButton_Click);
            programsButton.Click += new EventHandler(programsButton_Click);
            approachButton.Click += new EventHandler(approachButton_Click);
            exportChangeLog.Click += new EventHandler(exportChangeLog_Click);
        }

        /// <summary>
        /// Closes window.
        /// </summary>
        public void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Opens user management if user is an admin.
        /// Otherwise allows user to change their password.
        /// </summary>
        public void userButton_Click(object sender, EventArgs e)
        {
            if (admin)
            {
                new Users().ShowDialog(this);
            }
            else
            {
                new AddUser(Login.currentUser).ShowDialog(this);
            }
        }

        /// <summary>
        /// Opens program manager.
        /// </summary>
        public void programsButton_Click(object sender, EventArgs e)
        {
            new ProgramManager().ShowDialog(this);
        }

        /// <summary>
        /// Opens doc type manager.
        /// </summary>
        public void docButton_Click(object sender, EventArgs e)
        {
            new Documentation().ShowDialog(this);
        }

        /// <summary>
        /// Opens approach manager.
        /// </summary>
        public void approachButton_Click(object sender, EventArgs e)
        {
            new ApproachManager().ShowDialog(this);
        }

        public void exportChangeLog_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                //get change log entries
                var logs = (from c in db.changelogs
                            select c);

                //populate columns
                string[,] output = new string[logs.Count()+1,4];

                //column headers
                output[0,0] = "Date";
                output[0,1] = "User";
                output[0,2] = "Table";
                output[0,3] = "Details";

                //data
                int counter = 1;
                foreach (var log in logs)
                {
                    output[counter,0] = log.date.ToString("yyyy-MM-dd hh:mm:ss tt");
                    output[counter,1] = log.username;
                    output[counter,2] = log.object_edited;

                    //handle commas or quotes in details
                    //place "" around entries will separate commas
                    //also need to escape out actual quotes then
                    string details = '"' + log.details.Replace("\"", "\"\"") + '"';

                    output[counter, 3] = details;

                    counter++;
                }

                //add to string builder
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < output.GetLength(0); i++)
                {
                    sb.AppendLine(output[i,0] + "," +
                                  output[i,1] + "," +
                                  output[i,2] + "," +
                                  output[i,3]);
                }

                //open file save window
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = "change_log.csv";
                save.DefaultExt = "csv";
                if (save.ShowDialog() != DialogResult.OK) return;
                File.WriteAllText(save.FileName, sb.ToString());
            }
        }

    }
}
