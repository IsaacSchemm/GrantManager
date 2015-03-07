namespace GrantApp
{
    partial class About
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
			this.label2 = new System.Windows.Forms.Label();
			this.btnLicense = new System.Windows.Forms.Button();
			this.lblCalendarName = new System.Windows.Forms.Label();
			this.lblCalendarText = new System.Windows.Forms.Label();
			this.btnMonthCalendarLicense = new System.Windows.Forms.Button();
			this.btnMonthCalendarSite = new System.Windows.Forms.Button();
			this.btnGitHub = new System.Windows.Forms.Button();
			this.lblCompareName = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCompareLicense = new System.Windows.Forms.Button();
			this.btnCompareSite = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(11, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Grant Manager 2.0.1";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.Location = new System.Drawing.Point(12, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(360, 40);
			this.label2.TabIndex = 1;
			this.label2.Text = "© 2013-2014 Kelsey Burns, Spencer Grande, Dave Moss, Isaac Schemm, Conor Sherman," +
    " and Matt Wisby\r\n© 2015 Isaac Schemm";
			// 
			// btnLicense
			// 
			this.btnLicense.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnLicense.Location = new System.Drawing.Point(12, 75);
			this.btnLicense.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
			this.btnLicense.Name = "btnLicense";
			this.btnLicense.Size = new System.Drawing.Size(174, 23);
			this.btnLicense.TabIndex = 3;
			this.btnLicense.Text = "View license";
			this.btnLicense.UseVisualStyleBackColor = true;
			this.btnLicense.Click += new System.EventHandler(this.btnGpl_Click);
			// 
			// lblCalendarName
			// 
			this.lblCalendarName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblCalendarName.AutoSize = true;
			this.lblCalendarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCalendarName.Location = new System.Drawing.Point(12, 133);
			this.lblCalendarName.Name = "lblCalendarName";
			this.lblCalendarName.Size = new System.Drawing.Size(57, 13);
			this.lblCalendarName.TabIndex = 4;
			this.lblCalendarName.Text = "Calendar";
			// 
			// lblCalendarText
			// 
			this.lblCalendarText.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblCalendarText.Location = new System.Drawing.Point(12, 146);
			this.lblCalendarText.Name = "lblCalendarText";
			this.lblCalendarText.Size = new System.Drawing.Size(177, 48);
			this.lblCalendarText.TabIndex = 6;
			this.lblCalendarText.Text = "The calendar on the main page uses open-source code written by Patrik Bohman in 2" +
    "005.";
			// 
			// btnMonthCalendarLicense
			// 
			this.btnMonthCalendarLicense.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnMonthCalendarLicense.Location = new System.Drawing.Point(12, 197);
			this.btnMonthCalendarLicense.Name = "btnMonthCalendarLicense";
			this.btnMonthCalendarLicense.Size = new System.Drawing.Size(174, 23);
			this.btnMonthCalendarLicense.TabIndex = 7;
			this.btnMonthCalendarLicense.Text = "View license";
			this.btnMonthCalendarLicense.UseVisualStyleBackColor = true;
			this.btnMonthCalendarLicense.Click += new System.EventHandler(this.btnMonthCalendarLicense_Click);
			// 
			// btnMonthCalendarSite
			// 
			this.btnMonthCalendarSite.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnMonthCalendarSite.Location = new System.Drawing.Point(12, 226);
			this.btnMonthCalendarSite.Name = "btnMonthCalendarSite";
			this.btnMonthCalendarSite.Size = new System.Drawing.Size(174, 23);
			this.btnMonthCalendarSite.TabIndex = 8;
			this.btnMonthCalendarSite.Text = "View code at CodeProject";
			this.btnMonthCalendarSite.UseVisualStyleBackColor = true;
			this.btnMonthCalendarSite.Click += new System.EventHandler(this.btnMonthCalendarSite_Click);
			// 
			// btnGitHub
			// 
			this.btnGitHub.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnGitHub.Location = new System.Drawing.Point(202, 75);
			this.btnGitHub.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
			this.btnGitHub.Name = "btnGitHub";
			this.btnGitHub.Size = new System.Drawing.Size(170, 23);
			this.btnGitHub.TabIndex = 9;
			this.btnGitHub.Text = "View code at GitHub";
			this.btnGitHub.UseVisualStyleBackColor = true;
			this.btnGitHub.Click += new System.EventHandler(this.btnGitHub_Click);
			// 
			// lblCompareName
			// 
			this.lblCompareName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblCompareName.AutoSize = true;
			this.lblCompareName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCompareName.Location = new System.Drawing.Point(199, 133);
			this.lblCompareName.Name = "lblCompareName";
			this.lblCompareName.Size = new System.Drawing.Size(136, 13);
			this.lblCompareName.TabIndex = 10;
			this.lblCompareName.Text = "Compare .NET Objects";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.Location = new System.Drawing.Point(199, 146);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(177, 48);
			this.label3.TabIndex = 11;
			this.label3.Text = "The changelog uses the Compare .NET Objects library from Kellerman Software.";
			// 
			// btnCompareLicense
			// 
			this.btnCompareLicense.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnCompareLicense.Location = new System.Drawing.Point(202, 197);
			this.btnCompareLicense.Name = "btnCompareLicense";
			this.btnCompareLicense.Size = new System.Drawing.Size(174, 23);
			this.btnCompareLicense.TabIndex = 12;
			this.btnCompareLicense.Text = "View license";
			this.btnCompareLicense.UseVisualStyleBackColor = true;
			this.btnCompareLicense.Click += new System.EventHandler(this.btnCompareLicense_Click);
			// 
			// btnCompareSite
			// 
			this.btnCompareSite.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnCompareSite.Location = new System.Drawing.Point(202, 226);
			this.btnCompareSite.Name = "btnCompareSite";
			this.btnCompareSite.Size = new System.Drawing.Size(174, 23);
			this.btnCompareSite.TabIndex = 13;
			this.btnCompareSite.Text = "View code at CodePlex";
			this.btnCompareSite.UseVisualStyleBackColor = true;
			this.btnCompareSite.Click += new System.EventHandler(this.btnCompareSite_Click);
			// 
			// About
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 261);
			this.Controls.Add(this.btnCompareSite);
			this.Controls.Add(this.btnCompareLicense);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblCompareName);
			this.Controls.Add(this.btnGitHub);
			this.Controls.Add(this.btnMonthCalendarSite);
			this.Controls.Add(this.btnMonthCalendarLicense);
			this.Controls.Add(this.lblCalendarText);
			this.Controls.Add(this.lblCalendarName);
			this.Controls.Add(this.btnLicense);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "About";
			this.Text = "About";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLicense;
        private System.Windows.Forms.Label lblCalendarName;
        private System.Windows.Forms.Label lblCalendarText;
        private System.Windows.Forms.Button btnMonthCalendarLicense;
        private System.Windows.Forms.Button btnMonthCalendarSite;
        private System.Windows.Forms.Button btnGitHub;
		private System.Windows.Forms.Label lblCompareName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnCompareLicense;
		private System.Windows.Forms.Button btnCompareSite;

    }
}