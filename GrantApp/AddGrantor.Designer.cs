namespace GrantApp
{
    partial class AddGrantor
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
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.txtZip = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtFax = new System.Windows.Forms.TextBox();
			this.txtContactName = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtContactTitle = new System.Windows.Forms.TextBox();
			this.btnOkay = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtAvgGift = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.txtTypeOfSupport = new GrantApp.TextBoxWithExpandButton();
			this.txtGivingHistory = new GrantApp.TextBoxWithExpandButton();
			this.txtBuzzwords = new GrantApp.TextBoxWithExpandButton();
			this.txtNotes = new GrantApp.TextBoxWithExpandButton();
			this.txtError = new System.Windows.Forms.Label();
			this.dropState = new GrantApp.BetterComboBox();
			this.SuspendLayout();
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(66, 12);
			this.txtName.MaxLength = 50;
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(242, 20);
			this.txtName.TabIndex = 0;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(12, 15);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(38, 13);
			this.lblName.TabIndex = 5;
			this.lblName.Text = "Name:";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(66, 39);
			this.txtAddress.MaxLength = 100;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(242, 20);
			this.txtAddress.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Address:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "State:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(27, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "City:";
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(66, 185);
			this.txtPhone.MaxLength = 50;
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(242, 20);
			this.txtPhone.TabIndex = 6;
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(66, 71);
			this.txtCity.MaxLength = 50;
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(242, 20);
			this.txtCity.TabIndex = 2;
			// 
			// txtZip
			// 
			this.txtZip.Location = new System.Drawing.Point(66, 133);
			this.txtZip.MaxLength = 15;
			this.txtZip.Name = "txtZip";
			this.txtZip.Size = new System.Drawing.Size(242, 20);
			this.txtZip.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(25, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "Zip:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 192);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 13);
			this.label5.TabIndex = 16;
			this.label5.Text = "Phone:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 166);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 17;
			this.label6.Text = "Email:";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(66, 159);
			this.txtEmail.MaxLength = 50;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(242, 20);
			this.txtEmail.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 220);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(27, 13);
			this.label7.TabIndex = 20;
			this.label7.Text = "Fax:";
			// 
			// txtFax
			// 
			this.txtFax.Location = new System.Drawing.Point(66, 213);
			this.txtFax.MaxLength = 20;
			this.txtFax.Name = "txtFax";
			this.txtFax.Size = new System.Drawing.Size(242, 20);
			this.txtFax.TabIndex = 7;
			// 
			// txtContactName
			// 
			this.txtContactName.Location = new System.Drawing.Point(98, 254);
			this.txtContactName.MaxLength = 50;
			this.txtContactName.Name = "txtContactName";
			this.txtContactName.Size = new System.Drawing.Size(210, 20);
			this.txtContactName.TabIndex = 8;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Cursor = System.Windows.Forms.Cursors.Default;
			this.label8.Location = new System.Drawing.Point(12, 254);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(78, 13);
			this.label8.TabIndex = 22;
			this.label8.Text = "Contact Name:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Cursor = System.Windows.Forms.Cursors.Default;
			this.label9.Location = new System.Drawing.Point(12, 288);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(70, 13);
			this.label9.TabIndex = 24;
			this.label9.Text = "Contact Title:";
			// 
			// txtContactTitle
			// 
			this.txtContactTitle.Location = new System.Drawing.Point(98, 285);
			this.txtContactTitle.MaxLength = 50;
			this.txtContactTitle.Name = "txtContactTitle";
			this.txtContactTitle.Size = new System.Drawing.Size(210, 20);
			this.txtContactTitle.TabIndex = 9;
			// 
			// btnOkay
			// 
			this.btnOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOkay.Location = new System.Drawing.Point(482, 409);
			this.btnOkay.Name = "btnOkay";
			this.btnOkay.Size = new System.Drawing.Size(75, 23);
			this.btnOkay.TabIndex = 15;
			this.btnOkay.Text = "OK";
			this.btnOkay.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.CausesValidation = false;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(563, 409);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 16;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(314, 15);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(66, 13);
			this.label10.TabIndex = 25;
			this.label10.Text = "Average Gift";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(12, 316);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(86, 13);
			this.label11.TabIndex = 26;
			this.label11.Text = "Type of Support:";
			// 
			// txtAvgGift
			// 
			this.txtAvgGift.Location = new System.Drawing.Point(392, 12);
			this.txtAvgGift.Name = "txtAvgGift";
			this.txtAvgGift.Size = new System.Drawing.Size(165, 20);
			this.txtAvgGift.TabIndex = 11;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(314, 162);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(58, 13);
			this.label12.TabIndex = 30;
			this.label12.Text = "Buzzwords";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(314, 285);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(35, 13);
			this.label13.TabIndex = 32;
			this.label13.Text = "Notes";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(314, 42);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(72, 13);
			this.label14.TabIndex = 34;
			this.label14.Text = "Giving History";
			// 
			// txtTypeOfSupport
			// 
			this.txtTypeOfSupport.AcceptsReturn = true;
			this.txtTypeOfSupport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.txtTypeOfSupport.Location = new System.Drawing.Point(98, 316);
			this.txtTypeOfSupport.Multiline = true;
			this.txtTypeOfSupport.Name = "txtTypeOfSupport";
			this.txtTypeOfSupport.ReadOnly = false;
			this.txtTypeOfSupport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtTypeOfSupport.Size = new System.Drawing.Size(210, 116);
			this.txtTypeOfSupport.TabIndex = 10;
			// 
			// txtGivingHistory
			// 
			this.txtGivingHistory.AcceptsReturn = true;
			this.txtGivingHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtGivingHistory.Location = new System.Drawing.Point(392, 42);
			this.txtGivingHistory.Multiline = true;
			this.txtGivingHistory.Name = "txtGivingHistory";
			this.txtGivingHistory.ReadOnly = false;
			this.txtGivingHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtGivingHistory.Size = new System.Drawing.Size(246, 114);
			this.txtGivingHistory.TabIndex = 12;
			// 
			// txtBuzzwords
			// 
			this.txtBuzzwords.AcceptsReturn = true;
			this.txtBuzzwords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBuzzwords.Location = new System.Drawing.Point(392, 162);
			this.txtBuzzwords.Multiline = true;
			this.txtBuzzwords.Name = "txtBuzzwords";
			this.txtBuzzwords.ReadOnly = false;
			this.txtBuzzwords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtBuzzwords.Size = new System.Drawing.Size(246, 112);
			this.txtBuzzwords.TabIndex = 13;
			// 
			// txtNotes
			// 
			this.txtNotes.AcceptsReturn = true;
			this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNotes.Location = new System.Drawing.Point(392, 285);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.ReadOnly = false;
			this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtNotes.Size = new System.Drawing.Size(246, 118);
			this.txtNotes.TabIndex = 14;
			// 
			// txtError
			// 
			this.txtError.AutoSize = true;
			this.txtError.ForeColor = System.Drawing.Color.DarkRed;
			this.txtError.Location = new System.Drawing.Point(100, 9);
			this.txtError.Name = "txtError";
			this.txtError.Size = new System.Drawing.Size(0, 13);
			this.txtError.TabIndex = 35;
			// 
			// dropState
			// 
			this.dropState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.dropState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.dropState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.dropState.FormattingEnabled = true;
			this.dropState.Location = new System.Drawing.Point(66, 99);
			this.dropState.Name = "dropState";
			this.dropState.Size = new System.Drawing.Size(242, 21);
			this.dropState.TabIndex = 3;
			// 
			// AddGrantor
			// 
			this.AcceptButton = this.btnOkay;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(650, 444);
			this.Controls.Add(this.txtError);
			this.Controls.Add(this.txtNotes);
			this.Controls.Add(this.txtBuzzwords);
			this.Controls.Add(this.txtGivingHistory);
			this.Controls.Add(this.txtTypeOfSupport);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtAvgGift);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.btnOkay);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtContactTitle);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtContactName);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtFax);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtZip);
			this.Controls.Add(this.txtCity);
			this.Controls.Add(this.dropState);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtName);
			this.Name = "AddGrantor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Grantor Editor";
			this.Load += new System.EventHandler(this.AddGrantor_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtZip;
        protected System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtContactTitle;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAvgGift;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private GrantApp.TextBoxWithExpandButton txtTypeOfSupport;
		private GrantApp.TextBoxWithExpandButton txtGivingHistory;
		private GrantApp.TextBoxWithExpandButton txtBuzzwords;
		private GrantApp.TextBoxWithExpandButton txtNotes;
        private System.Windows.Forms.Label txtError;
        private BetterComboBox dropState;
        //private Database1DataSet database1DataSet;
    }
}