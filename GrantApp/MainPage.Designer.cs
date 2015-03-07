namespace GrantApp
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.grantButton = new System.Windows.Forms.Button();
			this.grantorButton = new System.Windows.Forms.Button();
			this.todayAlerts = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.upcomingAlerts = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.adminButton = new System.Windows.Forms.Button();
			this.monthCalendar2 = new Pabo.Calendar.MonthCalendar();
			this.yearSpinner = new System.Windows.Forms.NumericUpDown();
			this.projectButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.yearSpinner)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(317, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Welcome to Grant Manager 2.0!";
			// 
			// grantButton
			// 
			this.grantButton.Location = new System.Drawing.Point(32, 127);
			this.grantButton.Name = "grantButton";
			this.grantButton.Size = new System.Drawing.Size(75, 23);
			this.grantButton.TabIndex = 1;
			this.grantButton.Text = "Grants";
			this.grantButton.UseVisualStyleBackColor = true;
			this.grantButton.Click += new System.EventHandler(this.grants_Click);
			// 
			// grantorButton
			// 
			this.grantorButton.Location = new System.Drawing.Point(32, 185);
			this.grantorButton.Name = "grantorButton";
			this.grantorButton.Size = new System.Drawing.Size(75, 23);
			this.grantorButton.TabIndex = 2;
			this.grantorButton.Text = "Grantors";
			this.grantorButton.UseVisualStyleBackColor = true;
			this.grantorButton.Click += new System.EventHandler(this.grantors_Click);
			// 
			// todayAlerts
			// 
			this.todayAlerts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.todayAlerts.FormattingEnabled = true;
			this.todayAlerts.Location = new System.Drawing.Point(136, 274);
			this.todayAlerts.Name = "todayAlerts";
			this.todayAlerts.Size = new System.Drawing.Size(227, 69);
			this.todayAlerts.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(133, 253);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Selected Day\'s Alerts:";
			// 
			// upcomingAlerts
			// 
			this.upcomingAlerts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.upcomingAlerts.FormattingEnabled = true;
			this.upcomingAlerts.Location = new System.Drawing.Point(375, 79);
			this.upcomingAlerts.Name = "upcomingAlerts";
			this.upcomingAlerts.Size = new System.Drawing.Size(227, 264);
			this.upcomingAlerts.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(372, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Upcoming alerts:";
			// 
			// adminButton
			// 
			this.adminButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.adminButton.Location = new System.Drawing.Point(12, 320);
			this.adminButton.Name = "adminButton";
			this.adminButton.Size = new System.Drawing.Size(108, 23);
			this.adminButton.TabIndex = 3;
			this.adminButton.Text = "Administration";
			this.adminButton.UseVisualStyleBackColor = true;
			this.adminButton.Click += new System.EventHandler(this.admin_Click);
			// 
			// monthCalendar2
			// 
			this.monthCalendar2.ActiveMonth.Month = 3;
			this.monthCalendar2.ActiveMonth.Year = 2015;
			this.monthCalendar2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.monthCalendar2.Culture = new System.Globalization.CultureInfo("en-US");
			this.monthCalendar2.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.monthCalendar2.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.monthCalendar2.Header.TextColor = System.Drawing.Color.White;
			this.monthCalendar2.ImageList = null;
			this.monthCalendar2.Location = new System.Drawing.Point(136, 90);
			this.monthCalendar2.MaxDate = new System.DateTime(2100, 11, 4, 0, 0, 0, 0);
			this.monthCalendar2.MinDate = new System.DateTime(2003, 11, 4, 11, 52, 47, 841);
			this.monthCalendar2.Month.BackgroundImage = null;
			this.monthCalendar2.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.monthCalendar2.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.monthCalendar2.Name = "monthCalendar2";
			this.monthCalendar2.SelectionMode = Pabo.Calendar.mcSelectionMode.One;
			this.monthCalendar2.Size = new System.Drawing.Size(227, 151);
			this.monthCalendar2.TabIndex = 4;
			this.monthCalendar2.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.monthCalendar2.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			// 
			// yearSpinner
			// 
			this.yearSpinner.Location = new System.Drawing.Point(215, 61);
			this.yearSpinner.Name = "yearSpinner";
			this.yearSpinner.Size = new System.Drawing.Size(69, 20);
			this.yearSpinner.TabIndex = 7;
			// 
			// projectButton
			// 
			this.projectButton.Location = new System.Drawing.Point(32, 243);
			this.projectButton.Name = "projectButton";
			this.projectButton.Size = new System.Drawing.Size(75, 23);
			this.projectButton.TabIndex = 9;
			this.projectButton.Text = "Projects";
			this.projectButton.UseVisualStyleBackColor = true;
			this.projectButton.Click += new System.EventHandler(this.projects_Click);
			// 
			// MainPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 355);
			this.Controls.Add(this.projectButton);
			this.Controls.Add(this.yearSpinner);
			this.Controls.Add(this.monthCalendar2);
			this.Controls.Add(this.adminButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.upcomingAlerts);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.todayAlerts);
			this.Controls.Add(this.grantorButton);
			this.Controls.Add(this.grantButton);
			this.Controls.Add(this.label1);
			this.Name = "MainPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Grant Manager";
			((System.ComponentModel.ISupportInitialize)(this.yearSpinner)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button grantButton;
        private System.Windows.Forms.Button grantorButton;
        private System.Windows.Forms.ListBox todayAlerts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox upcomingAlerts;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button adminButton;
		private Pabo.Calendar.MonthCalendar monthCalendar2;
        private System.Windows.Forms.NumericUpDown yearSpinner;
        private System.Windows.Forms.Button projectButton;
    }
}