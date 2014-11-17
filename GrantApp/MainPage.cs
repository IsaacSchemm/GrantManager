using Pabo.Calendar;
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
    /// The first page that is displayed after logging in.
    /// Asks as menu for adding / removing database elements and displays upcoming notifications.
    /// </summary>
    public partial class MainPage : Form
    {
        /// <summary>
        /// Class that represents a message and a grant.
        /// Used to display messages for grants.
        /// </summary>
		private class Alert {
			public string message;
			public int grant_id;

			public Alert(string message, int grant_id) {
				this.message = message;
				this.grant_id = grant_id;
			}

			public override string ToString() {
				return message;
			}
		}

        //associates alerts with dates
		private Dictionary<DateTime, List<Alert>> alerts;

        /// <summary>
        /// Loads main page and displays alerts.
        /// </summary>
        public MainPage()
        {
			InitializeComponent();
			this.monthCalendar2.ActiveMonth.Month = DateTime.Today.Month;
			this.monthCalendar2.ActiveMonth.Year = DateTime.Today.Year;
			alerts = new Dictionary<DateTime, List<Alert>>();

            this.Activated += new EventHandler(this.formActivated);
            
            //parameters of year select are max and min of the month calendar object
			yearSpinner.Minimum = monthCalendar2.MinDate.Year;
			yearSpinner.Maximum = monthCalendar2.MaxDate.Year;
			yearSpinner.Value = monthCalendar2.ActiveMonth.Year;

            //when year select is changed, change calendar
			yearSpinner.ValueChanged += delegate(object o, EventArgs e) {
				monthCalendar2.ActiveMonth.Year = (int)yearSpinner.Value;
			};

            //when calendar is changed, rotate year select
			monthCalendar2.MonthChanged += delegate(object o, Pabo.Calendar.MonthChangedEventArgs e) {
				yearSpinner.Value = monthCalendar2.ActiveMonth.Year;
			};

			monthCalendar2.DaySelected += monthCalendar2_DaySelected;

            todayAlerts.DoubleClick += todaysAlerts_DoubleClick;

            //clear old values from changelog
            cleanseChangelog();
        }
        
        /// <summary>
        /// Clears entries in change log that are over 30 days old.
        /// Called on start up when main page is loading.
        /// </summary>
        private void cleanseChangelog()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                //find date on month earlier
                DateTime dateOneMonthEarlier = DateTime.Now.AddDays(-30);

                //remove entries before this date
                var deleteEntries =
                    from dbchangelog in db.changelogs
                    where dbchangelog.date < dateOneMonthEarlier
                    select dbchangelog;

                //delete
                foreach (var log in deleteEntries)
                {
                    db.changelogs.DeleteOnSubmit(log);
                }

                //try submitting changes
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    MessageBox.Show("A database error occured: old changelog values were not removed on start up.");
                    Console.WriteLine(e);
                    // Provide for exceptions.
                }
            }
        }

        /// <summary>
        /// Called when focus returns to main page.
        /// Updates calendar to reflect new upcoming dates.
        /// </summary>
        void formActivated(object sender, EventArgs e)
        {
            PopulateCalendar();
        }

        /// <summary>
        /// Called when a date is selected in the calendar.
        /// Displays alerts for selected date below the calendar.
        /// </summary>
		void monthCalendar2_DaySelected(object sender, DaySelectedEventArgs e)
        {
            List<string> temp = new List<String>();

            //clear old alerts
			todayAlerts.Items.Clear();

            //add alerts for selected date
			var d = monthCalendar2.SelectedDates[0];
			if (alerts.ContainsKey(d)) {
				todayAlerts.Items.AddRange(alerts[d].ToArray());
			}
		}

        /// <summary>
        /// Colors dates in calendar depending on alerts for that date.
        /// </summary>
		private void PopulateCalendar()
        {
            //reset
			monthCalendar2.ResetDateInfo();
			alerts.Clear();
            upcomingAlerts.Items.Clear();

			Dictionary<DateTime, DateItem> list = new Dictionary<DateTime, DateItem>();
			using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                //for every grant
				foreach (var g in (from g in db.grants
								   select new {
									  g.grant_name,
									  g.due_date,
                                      g.grant_id
								   }))
                {
                    //color due date red
					if (g.due_date != null) {
						var d = g.due_date.Value.Date;
						list[d] = new Pabo.Calendar.DateItem() {
							Date = d,
							BackColor1 = Color.Red,
						};

                        //add alert to list
						if (!alerts.ContainsKey(d)) alerts.Add(d, new List<Alert>());
						alerts[d].Add(new Alert("Due date for " + g.grant_name, g.grant_id));
					}
				}

				foreach (var td in db.timeline_dates) {
					var d = td.date.Date;
					list[d] = new DateItem() {
						Date = d,
						BackColor1 = Color.FromName(td.color ?? "Cyan")
					};

					//add alert to list
					if (!alerts.ContainsKey(d)) alerts.Add(d, new List<Alert>());
					alerts[d].Add(new Alert(td.name, td.grant_id));
				}
			}
			monthCalendar2.AddDateInfo(list.Values.ToArray());
			var q = from a in alerts
					where a.Key > DateTime.Today
					&& a.Key <= DateTime.Today.AddMonths(1)
					orderby a.Key
					select a;
			foreach (var pair in q) {
				foreach (Alert s in pair.Value) {
					upcomingAlerts.Items.Add(String.Format("{0} ({1:MMM dd, yyyy})", s.message, pair.Key));
				}
			}
		}

        /// <summary>
        /// Opens the grant manager window.
        /// </summary>
		private void grants_Click(object sender, EventArgs e)
        {
            // carry current window state over to next view
            GrantManager gm = new GrantManager();
			gm.WindowState = this.WindowState;
            gm.ShowDialog(this);

			PopulateCalendar();
		}

        /// <summary>
        /// Opens grantor manager window.
        /// </summary>
		private void grantors_Click(object sender, EventArgs e)
        {
            // carry current window state over to next view
            GrantorManager gm = new GrantorManager();
            gm.WindowState = this.WindowState;
            gm.ShowDialog(this);
		}

        /// <summary>
        /// Opens project manager window.
        /// </summary>
        private void projects_Click(object sender, EventArgs e)
        {
            // carry current window state over to next view
            ProjectManager pm = new ProjectManager();
            pm.WindowState = this.WindowState;
            pm.ShowDialog(this);
        }

        /// <summary>
        /// Opens admin menu.
        /// </summary>
        private void admin_Click(object sender, EventArgs eargs)
        {
			new Administration().ShowDialog(this);
        }
        
        /// <summary>
        /// Called when an alert in the "today" list is double clicked.
        /// Allows editing the grant (to possibly change completion date, etc).
        /// </summary>
        private void todaysAlerts_DoubleClick(object sender, EventArgs e)
        {
            Alert a = todayAlerts.SelectedItem as Alert;
            if (a != null)
            {
                new AddGrant(a.grant_id).ShowDialog(this);
            }
        }
    }
}
