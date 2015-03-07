namespace GrantApp
{
    partial class ContactHistory
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
            this.callDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.contactNameText = new System.Windows.Forms.TextBox();
			this.outcomeText = new TextBoxWithExpandButton();
			this.notesText = new TextBoxWithExpandButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.contactedByDropdown = new GrantApp.BetterComboBox();
            this.approachDropdown = new GrantApp.BetterComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact Name:";
            // 
            // callDatePicker
            // 
            this.callDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.callDatePicker.Location = new System.Drawing.Point(112, 90);
            this.callDatePicker.Name = "callDatePicker";
            this.callDatePicker.Size = new System.Drawing.Size(200, 20);
            this.callDatePicker.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Call Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Outcome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contacted By:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Notes:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Initial Approach:";
            // 
            // contactNameText
            // 
            this.contactNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactNameText.Location = new System.Drawing.Point(112, 54);
            this.contactNameText.Name = "contactNameText";
            this.contactNameText.Size = new System.Drawing.Size(200, 20);
            this.contactNameText.TabIndex = 10;
            // 
            // outcomeText
            // 
            this.outcomeText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outcomeText.Location = new System.Drawing.Point(112, 125);
            this.outcomeText.Multiline = true;
            this.outcomeText.Name = "outcomeText";
            this.outcomeText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outcomeText.Size = new System.Drawing.Size(200, 56);
            this.outcomeText.TabIndex = 12;
            // 
            // notesText
            // 
            this.notesText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesText.Location = new System.Drawing.Point(112, 231);
            this.notesText.Multiline = true;
            this.notesText.Name = "notesText";
            this.notesText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notesText.Size = new System.Drawing.Size(200, 56);
            this.notesText.TabIndex = 14;
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.Location = new System.Drawing.Point(157, 308);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 15;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(250, 308);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // contactedByDropdown
            // 
            this.contactedByDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactedByDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contactedByDropdown.FormattingEnabled = true;
            this.contactedByDropdown.Location = new System.Drawing.Point(112, 192);
            this.contactedByDropdown.Name = "contactedByDropdown";
            this.contactedByDropdown.Size = new System.Drawing.Size(200, 21);
            this.contactedByDropdown.TabIndex = 13;
            // 
            // approachDropdown
            // 
            this.approachDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.approachDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.approachDropdown.FormattingEnabled = true;
            this.approachDropdown.Location = new System.Drawing.Point(112, 17);
            this.approachDropdown.Name = "approachDropdown";
            this.approachDropdown.Size = new System.Drawing.Size(200, 21);
            this.approachDropdown.TabIndex = 9;
            // 
            // ContactHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 343);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.contactedByDropdown);
            this.Controls.Add(this.notesText);
            this.Controls.Add(this.outcomeText);
            this.Controls.Add(this.approachDropdown);
            this.Controls.Add(this.contactNameText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.callDatePicker);
            this.Controls.Add(this.label1);
            this.Name = "ContactHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contact History";
            this.Load += new System.EventHandler(this.ContactHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker callDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox contactNameText;
        private BetterComboBox approachDropdown;
		private TextBoxWithExpandButton outcomeText;
		private TextBoxWithExpandButton notesText;
        private BetterComboBox contactedByDropdown;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
    }
}