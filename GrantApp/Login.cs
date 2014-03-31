using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrantApp
{
    /// <summary>
    /// Login window.
    /// </summary>
    public partial class Login : Form
    {
        //keeps track of the currently logged in user so other windows can authenticate
        public static string currentUser { get; set; }

        /// <summary>
        /// Initialize window and set current user to null.
        /// </summary>
        public Login()
        {
            InitializeComponent();

            currentUser = null;

            loginButton.Click += new EventHandler(login);
            passwordText.KeyDown += new KeyEventHandler(login_enter);
        }

        /// <summary>
        /// Authenticates user after login button is clicked.
        /// </summary>
        private void login(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                //find users with given username and password
                var q = (from u in db.users
                        where u.username == usernameText.Text && u.password == passwordText.Text && u.active == true
                        select u);

				bool any = false;

                //determine whether user was found
                try {
					any = q.Any();
				} catch (SqlException) {
					MessageBox.Show(this, "The application could not connect to the database. Please try again.");
					return;
				}

                //if user was found, log them in
                if (any)
                {
                    //set current user
                    currentUser = q.First().username;

                    //hide login screen
                    this.Hide();

                    // carry current window state over to next view
                    MainPage mp = new MainPage();
                    mp.WindowState = this.WindowState;
                    mp.ShowDialog(this);
                    
                    //close login screen after setting window state
                    this.Close();
                }
                //if user was not found, give alert
                else
                {
                    //check if username and password exist
                    //if so, user is inactive
                    q = (from u in db.users
                         where u.username == usernameText.Text && u.password == passwordText.Text
                         select u);

                    //alert inactive user they cannot log in
                    if (q.Any())
                    {
                        MessageBox.Show("Your account is not active, so you are unable to log in.");
                    }
                    //otherwise display invalid password message
                    else
                    {
                        //show error message
                        invalidLoginLabel.Visible = true;

                        //clear password field
                        passwordText.Text = "";
                    }
                }
            }
        }

        //allows hitting enter to log in
        private void login_enter(object sender, KeyEventArgs e)
        {

            if (e.KeyCode.ToString() == "Return") 
            {
                login(sender, e);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

    }
}
