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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGpl = new System.Windows.Forms.Button();
            this.lblCalendarName = new System.Windows.Forms.Label();
            this.lblCalendarText = new System.Windows.Forms.Label();
            this.btnBsdLicense = new System.Windows.Forms.Button();
            this.btnCodeProject = new System.Windows.Forms.Button();
            this.btnGitHub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grant Manager";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 166);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // btnGpl
            // 
            this.btnGpl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGpl.Location = new System.Drawing.Point(12, 200);
            this.btnGpl.Name = "btnGpl";
            this.btnGpl.Size = new System.Drawing.Size(174, 23);
            this.btnGpl.TabIndex = 3;
            this.btnGpl.Text = "View GPL v3";
            this.btnGpl.UseVisualStyleBackColor = true;
            this.btnGpl.Click += new System.EventHandler(this.btnGpl_Click);
            // 
            // lblCalendarName
            // 
            this.lblCalendarName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCalendarName.AutoSize = true;
            this.lblCalendarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendarName.Location = new System.Drawing.Point(13, 236);
            this.lblCalendarName.Name = "lblCalendarName";
            this.lblCalendarName.Size = new System.Drawing.Size(57, 13);
            this.lblCalendarName.TabIndex = 4;
            this.lblCalendarName.Text = "Calendar";
            // 
            // lblCalendarText
            // 
            this.lblCalendarText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCalendarText.Location = new System.Drawing.Point(12, 253);
            this.lblCalendarText.Name = "lblCalendarText";
            this.lblCalendarText.Size = new System.Drawing.Size(360, 30);
            this.lblCalendarText.TabIndex = 6;
            this.lblCalendarText.Text = "The calendar on the main page uses open-source code written by Patrik Bohman in 2" +
    "005.";
            // 
            // btnBsdLicense
            // 
            this.btnBsdLicense.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBsdLicense.Location = new System.Drawing.Point(16, 287);
            this.btnBsdLicense.Name = "btnBsdLicense";
            this.btnBsdLicense.Size = new System.Drawing.Size(170, 23);
            this.btnBsdLicense.TabIndex = 7;
            this.btnBsdLicense.Text = "View license";
            this.btnBsdLicense.UseVisualStyleBackColor = true;
            this.btnBsdLicense.Click += new System.EventHandler(this.btnBsdLicense_Click);
            // 
            // btnCodeProject
            // 
            this.btnCodeProject.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCodeProject.Location = new System.Drawing.Point(202, 287);
            this.btnCodeProject.Name = "btnCodeProject";
            this.btnCodeProject.Size = new System.Drawing.Size(170, 23);
            this.btnCodeProject.TabIndex = 8;
            this.btnCodeProject.Text = "View code at CodeProject";
            this.btnCodeProject.UseVisualStyleBackColor = true;
            this.btnCodeProject.Click += new System.EventHandler(this.btnCodeProject_Click);
            // 
            // btnGitHub
            // 
            this.btnGitHub.Location = new System.Drawing.Point(202, 200);
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.Size = new System.Drawing.Size(170, 23);
            this.btnGitHub.TabIndex = 9;
            this.btnGitHub.Text = "View code at GitHub";
            this.btnGitHub.UseVisualStyleBackColor = true;
            this.btnGitHub.Click += new System.EventHandler(this.btnGitHub_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 322);
            this.Controls.Add(this.btnGitHub);
            this.Controls.Add(this.btnCodeProject);
            this.Controls.Add(this.btnBsdLicense);
            this.Controls.Add(this.lblCalendarText);
            this.Controls.Add(this.lblCalendarName);
            this.Controls.Add(this.btnGpl);
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
        private System.Windows.Forms.Button btnGpl;
        private System.Windows.Forms.Label lblCalendarName;
        private System.Windows.Forms.Label lblCalendarText;
        private System.Windows.Forms.Button btnBsdLicense;
        private System.Windows.Forms.Button btnCodeProject;
        private System.Windows.Forms.Button btnGitHub;

    }
}