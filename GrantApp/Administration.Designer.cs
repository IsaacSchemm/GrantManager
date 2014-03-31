namespace GrantApp
{
    partial class Administration
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
            this.userButton = new System.Windows.Forms.Button();
            this.programsButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.docButton = new System.Windows.Forms.Button();
            this.approachButton = new System.Windows.Forms.Button();
            this.exportChangeLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userButton
            // 
            this.userButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userButton.Location = new System.Drawing.Point(81, 68);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(123, 23);
            this.userButton.TabIndex = 0;
            this.userButton.Text = "User Management";
            this.userButton.UseVisualStyleBackColor = true;
            // 
            // programsButton
            // 
            this.programsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.programsButton.Location = new System.Drawing.Point(81, 118);
            this.programsButton.Name = "programsButton";
            this.programsButton.Size = new System.Drawing.Size(123, 23);
            this.programsButton.TabIndex = 1;
            this.programsButton.Text = "Programs";
            this.programsButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // docButton
            // 
            this.docButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.docButton.Location = new System.Drawing.Point(81, 167);
            this.docButton.Name = "docButton";
            this.docButton.Size = new System.Drawing.Size(123, 23);
            this.docButton.TabIndex = 3;
            this.docButton.Text = "Documentation";
            this.docButton.UseVisualStyleBackColor = true;
            // 
            // approachButton
            // 
            this.approachButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.approachButton.Location = new System.Drawing.Point(81, 216);
            this.approachButton.Name = "approachButton";
            this.approachButton.Size = new System.Drawing.Size(123, 23);
            this.approachButton.TabIndex = 5;
            this.approachButton.Text = "Approaches";
            this.approachButton.UseVisualStyleBackColor = true;
            // 
            // exportChangeLog
            // 
            this.exportChangeLog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.exportChangeLog.Location = new System.Drawing.Point(81, 266);
            this.exportChangeLog.Name = "exportChangeLog";
            this.exportChangeLog.Size = new System.Drawing.Size(123, 23);
            this.exportChangeLog.TabIndex = 6;
            this.exportChangeLog.Text = "Export Change Log";
            this.exportChangeLog.UseVisualStyleBackColor = true;
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 310);
            this.Controls.Add(this.exportChangeLog);
            this.Controls.Add(this.approachButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.programsButton);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.docButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Administration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administration Controls";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Button programsButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button docButton;
        private System.Windows.Forms.Button approachButton;
        private System.Windows.Forms.Button exportChangeLog;
    }
}