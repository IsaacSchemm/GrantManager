namespace GrantApp
{
    partial class AddGrant
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
			this.lblGrantor = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.grantSubmitButton = new System.Windows.Forms.Button();
			this.lblName = new System.Windows.Forms.Label();
			this.grantNameText = new System.Windows.Forms.TextBox();
			this.addGrantorButton = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.requestedAmountText = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.actualAmountText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.grantDescText = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.submitDatePicker = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.dueDatePicker = new System.Windows.Forms.DateTimePicker();
			this.turnaroundPicker = new System.Windows.Forms.DateTimePicker();
			this.startDatePicker = new System.Windows.Forms.DateTimePicker();
			this.paymentDatePicker = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.grantorUsernameText = new System.Windows.Forms.TextBox();
			this.grantorPasswordText = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.programsList = new System.Windows.Forms.ListBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.projectsList = new System.Windows.Forms.ListBox();
			this.requirementsList = new System.Windows.Forms.ListBox();
			this.label17 = new System.Windows.Forms.Label();
			this.cbSubmit = new System.Windows.Forms.CheckBox();
			this.cbDue = new System.Windows.Forms.CheckBox();
			this.cbTurnAround = new System.Windows.Forms.CheckBox();
			this.cbStart = new System.Windows.Forms.CheckBox();
			this.cbPayment = new System.Windows.Forms.CheckBox();
			this.grantorWebsiteText = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.attachmentsList = new System.Windows.Forms.ListBox();
			this.addAttachmentButton = new System.Windows.Forms.Button();
			this.editAttachmentButton = new System.Windows.Forms.Button();
			this.addProjectButton = new System.Windows.Forms.Button();
			this.deleteProjectButton = new System.Windows.Forms.Button();
			this.deleteProgramButton = new System.Windows.Forms.Button();
			this.addProgramButton = new System.Windows.Forms.Button();
			this.deleteDocTypeButton = new System.Windows.Forms.Button();
			this.addDocTypeButton = new System.Windows.Forms.Button();
			this.grantNotesText = new GrantApp.TextBoxWithExpandButton();
			this.emphasisText = new GrantApp.TextBoxWithExpandButton();
			this.statusDropdown = new GrantApp.BetterComboBox();
			this.grantWriterDropdown = new GrantApp.BetterComboBox();
			this.grantorDropdown = new GrantApp.BetterComboBox();
			this.SuspendLayout();
			// 
			// lblGrantor
			// 
			this.lblGrantor.AutoSize = true;
			this.lblGrantor.Location = new System.Drawing.Point(12, 72);
			this.lblGrantor.Name = "lblGrantor";
			this.lblGrantor.Size = new System.Drawing.Size(45, 13);
			this.lblGrantor.TabIndex = 4;
			this.lblGrantor.Text = "Grantor:";
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.CausesValidation = false;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(742, 582);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(80, 23);
			this.btnCancel.TabIndex = 57;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// grantSubmitButton
			// 
			this.grantSubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.grantSubmitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.grantSubmitButton.Location = new System.Drawing.Point(656, 582);
			this.grantSubmitButton.Name = "grantSubmitButton";
			this.grantSubmitButton.Size = new System.Drawing.Size(80, 23);
			this.grantSubmitButton.TabIndex = 56;
			this.grantSubmitButton.Text = "Submit";
			this.grantSubmitButton.UseVisualStyleBackColor = true;
			this.grantSubmitButton.Click += new System.EventHandler(this.grantSubmitButton_Click);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(12, 9);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(38, 13);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name:";
			// 
			// grantNameText
			// 
			this.grantNameText.Location = new System.Drawing.Point(78, 6);
			this.grantNameText.Name = "grantNameText";
			this.grantNameText.Size = new System.Drawing.Size(241, 20);
			this.grantNameText.TabIndex = 1;
			// 
			// addGrantorButton
			// 
			this.addGrantorButton.Location = new System.Drawing.Point(216, 105);
			this.addGrantorButton.Name = "addGrantorButton";
			this.addGrantorButton.Size = new System.Drawing.Size(103, 23);
			this.addGrantorButton.TabIndex = 6;
			this.addGrantorButton.Text = "Add New Grantor";
			this.addGrantorButton.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 335);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(101, 13);
			this.label5.TabIndex = 22;
			this.label5.Text = "Requested Amount:";
			// 
			// requestedAmountText
			// 
			this.requestedAmountText.Location = new System.Drawing.Point(119, 332);
			this.requestedAmountText.Name = "requestedAmountText";
			this.requestedAmountText.Size = new System.Drawing.Size(200, 20);
			this.requestedAmountText.TabIndex = 23;
			this.requestedAmountText.Text = "0.00";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 362);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 13);
			this.label6.TabIndex = 24;
			this.label6.Text = "Actual Amount";
			// 
			// actualAmountText
			// 
			this.actualAmountText.Location = new System.Drawing.Point(119, 359);
			this.actualAmountText.Name = "actualAmountText";
			this.actualAmountText.Size = new System.Drawing.Size(200, 20);
			this.actualAmountText.TabIndex = 25;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Description:";
			// 
			// grantDescText
			// 
			this.grantDescText.Location = new System.Drawing.Point(78, 39);
			this.grantDescText.Name = "grantDescText";
			this.grantDescText.Size = new System.Drawing.Size(241, 20);
			this.grantDescText.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 147);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Submit Date:";
			// 
			// submitDatePicker
			// 
			this.submitDatePicker.Enabled = false;
			this.submitDatePicker.Location = new System.Drawing.Point(108, 147);
			this.submitDatePicker.Name = "submitDatePicker";
			this.submitDatePicker.Size = new System.Drawing.Size(211, 20);
			this.submitDatePicker.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 182);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Due Date:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 213);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "Turnaround Date:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 244);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(58, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "Start Date:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 277);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(77, 13);
			this.label8.TabIndex = 19;
			this.label8.Text = "Payment Date:";
			// 
			// dueDatePicker
			// 
			this.dueDatePicker.Enabled = false;
			this.dueDatePicker.Location = new System.Drawing.Point(108, 182);
			this.dueDatePicker.Name = "dueDatePicker";
			this.dueDatePicker.Size = new System.Drawing.Size(211, 20);
			this.dueDatePicker.TabIndex = 11;
			// 
			// turnaroundPicker
			// 
			this.turnaroundPicker.Enabled = false;
			this.turnaroundPicker.Location = new System.Drawing.Point(109, 213);
			this.turnaroundPicker.Name = "turnaroundPicker";
			this.turnaroundPicker.Size = new System.Drawing.Size(210, 20);
			this.turnaroundPicker.TabIndex = 14;
			// 
			// startDatePicker
			// 
			this.startDatePicker.Enabled = false;
			this.startDatePicker.Location = new System.Drawing.Point(108, 244);
			this.startDatePicker.Name = "startDatePicker";
			this.startDatePicker.Size = new System.Drawing.Size(211, 20);
			this.startDatePicker.TabIndex = 17;
			// 
			// paymentDatePicker
			// 
			this.paymentDatePicker.Enabled = false;
			this.paymentDatePicker.Location = new System.Drawing.Point(108, 277);
			this.paymentDatePicker.Name = "paymentDatePicker";
			this.paymentDatePicker.Size = new System.Drawing.Size(211, 20);
			this.paymentDatePicker.TabIndex = 20;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(15, 492);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 13);
			this.label9.TabIndex = 30;
			this.label9.Text = "Website Username:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(15, 517);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(98, 13);
			this.label10.TabIndex = 32;
			this.label10.Text = "Website Password:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(592, 147);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(97, 13);
			this.label14.TabIndex = 48;
			this.label14.Text = "Program Emphasis:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(347, 362);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(38, 13);
			this.label13.TabIndex = 54;
			this.label13.Text = "Notes:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(15, 555);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(67, 13);
			this.label12.TabIndex = 34;
			this.label12.Text = "Grant Writer:";
			// 
			// grantorUsernameText
			// 
			this.grantorUsernameText.Location = new System.Drawing.Point(119, 489);
			this.grantorUsernameText.Name = "grantorUsernameText";
			this.grantorUsernameText.Size = new System.Drawing.Size(200, 20);
			this.grantorUsernameText.TabIndex = 31;
			// 
			// grantorPasswordText
			// 
			this.grantorPasswordText.Location = new System.Drawing.Point(119, 514);
			this.grantorPasswordText.Name = "grantorPasswordText";
			this.grantorPasswordText.Size = new System.Drawing.Size(200, 20);
			this.grantorPasswordText.TabIndex = 33;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(15, 410);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(40, 13);
			this.label15.TabIndex = 26;
			this.label15.Text = "Status:";
			// 
			// programsList
			// 
			this.programsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.programsList.FormattingEnabled = true;
			this.programsList.Location = new System.Drawing.Point(595, 26);
			this.programsList.Name = "programsList";
			this.programsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.programsList.Size = new System.Drawing.Size(227, 82);
			this.programsList.Sorted = true;
			this.programsList.TabIndex = 45;
			this.programsList.SelectedIndexChanged += new System.EventHandler(this.programsList_SelectedIndexChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(592, 9);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(54, 13);
			this.label11.TabIndex = 44;
			this.label11.Text = "Programs:";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(347, 9);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(48, 13);
			this.label16.TabIndex = 36;
			this.label16.Text = "Projects:";
			// 
			// projectsList
			// 
			this.projectsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.projectsList.FormattingEnabled = true;
			this.projectsList.Location = new System.Drawing.Point(350, 26);
			this.projectsList.Name = "projectsList";
			this.projectsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.projectsList.Size = new System.Drawing.Size(229, 121);
			this.projectsList.Sorted = true;
			this.projectsList.TabIndex = 37;
			this.projectsList.SelectedIndexChanged += new System.EventHandler(this.projectsList_SelectedIndexChanged);
			// 
			// requirementsList
			// 
			this.requirementsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.requirementsList.FormattingEnabled = true;
			this.requirementsList.Location = new System.Drawing.Point(595, 241);
			this.requirementsList.Name = "requirementsList";
			this.requirementsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.requirementsList.Size = new System.Drawing.Size(227, 95);
			this.requirementsList.Sorted = true;
			this.requirementsList.TabIndex = 51;
			this.requirementsList.SelectedIndexChanged += new System.EventHandler(this.documentationList_SelectedIndexChanged);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(592, 225);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(75, 13);
			this.label17.TabIndex = 50;
			this.label17.Text = "Requirements:";
			// 
			// cbSubmit
			// 
			this.cbSubmit.AutoSize = true;
			this.cbSubmit.Location = new System.Drawing.Point(326, 149);
			this.cbSubmit.Name = "cbSubmit";
			this.cbSubmit.Size = new System.Drawing.Size(15, 14);
			this.cbSubmit.TabIndex = 9;
			this.cbSubmit.UseVisualStyleBackColor = true;
			this.cbSubmit.CheckedChanged += new System.EventHandler(this.cbSubmit_CheckedChanged);
			// 
			// cbDue
			// 
			this.cbDue.AutoSize = true;
			this.cbDue.Location = new System.Drawing.Point(325, 185);
			this.cbDue.Name = "cbDue";
			this.cbDue.Size = new System.Drawing.Size(15, 14);
			this.cbDue.TabIndex = 12;
			this.cbDue.UseVisualStyleBackColor = true;
			this.cbDue.CheckedChanged += new System.EventHandler(this.cbDue_CheckedChanged);
			// 
			// cbTurnAround
			// 
			this.cbTurnAround.AutoSize = true;
			this.cbTurnAround.Location = new System.Drawing.Point(326, 216);
			this.cbTurnAround.Name = "cbTurnAround";
			this.cbTurnAround.Size = new System.Drawing.Size(15, 14);
			this.cbTurnAround.TabIndex = 15;
			this.cbTurnAround.UseVisualStyleBackColor = true;
			this.cbTurnAround.CheckedChanged += new System.EventHandler(this.cbTurnAround_CheckedChanged);
			// 
			// cbStart
			// 
			this.cbStart.AutoSize = true;
			this.cbStart.Location = new System.Drawing.Point(325, 247);
			this.cbStart.Name = "cbStart";
			this.cbStart.Size = new System.Drawing.Size(15, 14);
			this.cbStart.TabIndex = 18;
			this.cbStart.UseVisualStyleBackColor = true;
			this.cbStart.CheckedChanged += new System.EventHandler(this.cbStart_CheckedChanged);
			// 
			// cbPayment
			// 
			this.cbPayment.AutoSize = true;
			this.cbPayment.Location = new System.Drawing.Point(326, 280);
			this.cbPayment.Name = "cbPayment";
			this.cbPayment.Size = new System.Drawing.Size(15, 14);
			this.cbPayment.TabIndex = 21;
			this.cbPayment.UseVisualStyleBackColor = true;
			this.cbPayment.CheckedChanged += new System.EventHandler(this.cbPayment_CheckedChanged);
			// 
			// grantorWebsiteText
			// 
			this.grantorWebsiteText.Location = new System.Drawing.Point(119, 463);
			this.grantorWebsiteText.Name = "grantorWebsiteText";
			this.grantorWebsiteText.Size = new System.Drawing.Size(200, 20);
			this.grantorWebsiteText.TabIndex = 29;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(15, 466);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(49, 13);
			this.label18.TabIndex = 28;
			this.label18.Text = "Website:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(348, 186);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(69, 13);
			this.label19.TabIndex = 40;
			this.label19.Text = "Attachments:";
			// 
			// attachmentsList
			// 
			this.attachmentsList.FormattingEnabled = true;
			this.attachmentsList.Location = new System.Drawing.Point(351, 202);
			this.attachmentsList.Name = "attachmentsList";
			this.attachmentsList.Size = new System.Drawing.Size(229, 134);
			this.attachmentsList.Sorted = true;
			this.attachmentsList.TabIndex = 41;
			this.attachmentsList.SelectedIndexChanged += new System.EventHandler(this.attachmentsList_SelectedIndexChanged);
			// 
			// addAttachmentButton
			// 
			this.addAttachmentButton.Location = new System.Drawing.Point(532, 342);
			this.addAttachmentButton.Name = "addAttachmentButton";
			this.addAttachmentButton.Size = new System.Drawing.Size(48, 23);
			this.addAttachmentButton.TabIndex = 43;
			this.addAttachmentButton.Text = "Add";
			this.addAttachmentButton.UseVisualStyleBackColor = true;
			this.addAttachmentButton.Click += new System.EventHandler(this.addAttachmentButton_Click);
			// 
			// editAttachmentButton
			// 
			this.editAttachmentButton.Enabled = false;
			this.editAttachmentButton.Location = new System.Drawing.Point(478, 342);
			this.editAttachmentButton.Name = "editAttachmentButton";
			this.editAttachmentButton.Size = new System.Drawing.Size(48, 23);
			this.editAttachmentButton.TabIndex = 42;
			this.editAttachmentButton.Text = "Edit";
			this.editAttachmentButton.UseVisualStyleBackColor = true;
			this.editAttachmentButton.Click += new System.EventHandler(this.editAttachmentButton_Click);
			// 
			// addProjectButton
			// 
			this.addProjectButton.Location = new System.Drawing.Point(531, 153);
			this.addProjectButton.Name = "addProjectButton";
			this.addProjectButton.Size = new System.Drawing.Size(48, 23);
			this.addProjectButton.TabIndex = 39;
			this.addProjectButton.Text = "Add";
			this.addProjectButton.UseVisualStyleBackColor = true;
			this.addProjectButton.Click += new System.EventHandler(this.addProjectButton_Click);
			// 
			// deleteProjectButton
			// 
			this.deleteProjectButton.Enabled = false;
			this.deleteProjectButton.Location = new System.Drawing.Point(477, 153);
			this.deleteProjectButton.Name = "deleteProjectButton";
			this.deleteProjectButton.Size = new System.Drawing.Size(48, 23);
			this.deleteProjectButton.TabIndex = 38;
			this.deleteProjectButton.Text = "Delete";
			this.deleteProjectButton.UseVisualStyleBackColor = true;
			this.deleteProjectButton.Click += new System.EventHandler(this.deleteProjectButton_Click);
			// 
			// deleteProgramButton
			// 
			this.deleteProgramButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.deleteProgramButton.Enabled = false;
			this.deleteProgramButton.Location = new System.Drawing.Point(720, 114);
			this.deleteProgramButton.Name = "deleteProgramButton";
			this.deleteProgramButton.Size = new System.Drawing.Size(48, 23);
			this.deleteProgramButton.TabIndex = 46;
			this.deleteProgramButton.Text = "Delete";
			this.deleteProgramButton.UseVisualStyleBackColor = true;
			this.deleteProgramButton.Click += new System.EventHandler(this.deleteProgramButton_Click);
			// 
			// addProgramButton
			// 
			this.addProgramButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addProgramButton.Location = new System.Drawing.Point(774, 114);
			this.addProgramButton.Name = "addProgramButton";
			this.addProgramButton.Size = new System.Drawing.Size(48, 23);
			this.addProgramButton.TabIndex = 47;
			this.addProgramButton.Text = "Add";
			this.addProgramButton.UseVisualStyleBackColor = true;
			this.addProgramButton.Click += new System.EventHandler(this.addProgramButton_Click);
			// 
			// deleteDocTypeButton
			// 
			this.deleteDocTypeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.deleteDocTypeButton.Enabled = false;
			this.deleteDocTypeButton.Location = new System.Drawing.Point(720, 342);
			this.deleteDocTypeButton.Name = "deleteDocTypeButton";
			this.deleteDocTypeButton.Size = new System.Drawing.Size(48, 23);
			this.deleteDocTypeButton.TabIndex = 52;
			this.deleteDocTypeButton.Text = "Delete";
			this.deleteDocTypeButton.UseVisualStyleBackColor = true;
			this.deleteDocTypeButton.Click += new System.EventHandler(this.deleteDocTypeButton_Click);
			// 
			// addDocTypeButton
			// 
			this.addDocTypeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addDocTypeButton.Location = new System.Drawing.Point(774, 342);
			this.addDocTypeButton.Name = "addDocTypeButton";
			this.addDocTypeButton.Size = new System.Drawing.Size(48, 23);
			this.addDocTypeButton.TabIndex = 53;
			this.addDocTypeButton.Text = "Add";
			this.addDocTypeButton.UseVisualStyleBackColor = true;
			this.addDocTypeButton.Click += new System.EventHandler(this.addDocTypeButton_Click);
			// 
			// grantNotesText
			// 
			this.grantNotesText.AcceptsReturn = false;
			this.grantNotesText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grantNotesText.Location = new System.Drawing.Point(351, 378);
			this.grantNotesText.Multiline = true;
			this.grantNotesText.Name = "grantNotesText";
			this.grantNotesText.ReadOnly = false;
			this.grantNotesText.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.grantNotesText.Size = new System.Drawing.Size(471, 198);
			this.grantNotesText.TabIndex = 55;
			// 
			// emphasisText
			// 
			this.emphasisText.AcceptsReturn = false;
			this.emphasisText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.emphasisText.Location = new System.Drawing.Point(595, 163);
			this.emphasisText.Multiline = true;
			this.emphasisText.Name = "emphasisText";
			this.emphasisText.ReadOnly = false;
			this.emphasisText.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.emphasisText.Size = new System.Drawing.Size(227, 59);
			this.emphasisText.TabIndex = 49;
			// 
			// statusDropdown
			// 
			this.statusDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.statusDropdown.FormattingEnabled = true;
			this.statusDropdown.Location = new System.Drawing.Point(119, 407);
			this.statusDropdown.Name = "statusDropdown";
			this.statusDropdown.Size = new System.Drawing.Size(200, 21);
			this.statusDropdown.TabIndex = 27;
			// 
			// grantWriterDropdown
			// 
			this.grantWriterDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.grantWriterDropdown.FormattingEnabled = true;
			this.grantWriterDropdown.Location = new System.Drawing.Point(119, 552);
			this.grantWriterDropdown.Name = "grantWriterDropdown";
			this.grantWriterDropdown.Size = new System.Drawing.Size(200, 21);
			this.grantWriterDropdown.TabIndex = 35;
			// 
			// grantorDropdown
			// 
			this.grantorDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.grantorDropdown.FormattingEnabled = true;
			this.grantorDropdown.Items.AddRange(new object[] {
            "\tAlben Barkley (1949-1953)",
            "\tAndrew Johnson (1865)",
            "\tCharles Dawes (1925-1929)",
            "\tCharles Fairbanks (1905-1909)",
            "\tElbridge Gerry (1813-1814)",
            "\tGeorge Clinton (1805-1809)",
            "\tGerald Ford (1973-1974)",
            "\tHarry S Truman (1945)",
            "\tHenry A. Wallace (1941-1945)",
            "\tHenry Wilson (1873-1875)",
            "\tHubert Humphrey (1965-1969)",
            "\tMartin Van Buren (1833-1837)",
            "\tNelson Rockefeller (1974-1977)",
            "\tnone (1812-1813)",
            "\tnone (1814-1817)",
            "\tnone (1832-1833)",
            "\tnone (1853-1857)",
            "\tnone (1875-1877)",
            "\tnone (1885-1889)",
            "\tnone (1899-1901)",
            "\tnone (1912-1913)",
            "\tnone (1973)",
            "\tTheodore Roosevelt (1901)",
            "Abraham Lincoln (1861-1865)\tHannibal Hamlin (1861-1865)",
            "Andrew Jackson (1829-1837)\tJohn C. Calhoun (1829-1832)",
            "Andrew Johnson (1865-1869)\tnone (1865-1869)",
            "Barack Obama (2009-present)\tJoe Biden (2009-present)",
            "Benjamin Harrison (1889-1893)\tLevi P. Morton (1889-1893)",
            "Bill Clinton (1993-2001)\tAl Gore (1993-2001)",
            "Calvin Coolidge (1923-1929)\tnone (1923-1925)",
            "Chester Arthur (1881-1885)\tnone (1881-1885)",
            "Dwight D. Eisenhower (1953-1961)\tRichard Nixon (1953-1961)",
            "Franklin D. Roosevelt (1933-1945)\tJohn Nance Garner (1933-1941)",
            "Franklin Pierce (1853-1857)\tWilliam King (1853)",
            "George Bush (1989-1993)\tDan Quayle (1989-1993)",
            "George W. Bush (2001-2009)\tDick Cheney (2001-2009)",
            "George Washington (1789-1797)\tJohn Adams (1789-1797)",
            "Gerald Ford (1974-1977)\tnone (1974)",
            "Grover Cleveland (1885-1889)\tThomas Hendricks (1885)",
            "Grover Cleveland (1893-1897)\tAdlai E. Stevenson (1893-1897)",
            "Harry S Truman (1945-1953)\tnone (1945-1949)",
            "Herbert Hoover (1929-1933)\tCharles Curtis (1929-1933)",
            "James A. Garfield (1881)\tChester Arthur (1881)",
            "James Buchanan (1857-1861)\tJohn C. Breckinridge (1857-1861)",
            "James K. Polk (1845-1849)\tGeorge M. Dallas (1845-1849)",
            "James Madison (1809-1817)\tGeorge Clinton (1809-1812)",
            "James Monroe (1817-1825)\tDaniel D. Tompkins (1817-1825)",
            "Jimmy Carter (1977-1981)\tWalter Mondale (1977-1981)",
            "John Adams (1797-1801)\tThomas Jefferson (1797-1801)",
            "John F. Kennedy (1961-1963)\tLyndon B. Johnson (1961-1963)",
            "John Quincy Adams (1825-1829)\tJohn C. Calhoun (1825-1829)",
            "John Tyler (1841-1845)\tnone (1841-1845)",
            "Lyndon B. Johnson (1963-1969)\tnone (1963-1965)",
            "Martin Van Buren (1837-1841)\tRichard M. Johnson (1837-1841)",
            "Millard Fillmore (1850-1853)\tnone (1850-1853)",
            "Richard Nixon (1969-1974)\tSpiro Agnew (1969-1973)",
            "Ronald Reagan (1981-1989)\tGeorge Bush (1981-1989)",
            "Rutherford B. Hayes (1877-1881)\tWilliam Wheeler (1877-1881)",
            "Theodore Roosevelt (1901-1909)\tnone (1901-1905)",
            "Thomas Jefferson (1801-1809)\tAaron Burr (1801-1805)",
            "Ulysses S. Grant (1869-1877)\tSchuyler Colfax (1869-1873)",
            "Warren G. Harding (1921-1923)\tCalvin Coolidge (1921-1923)",
            "William Henry Harrison (1841)\tJohn Tyler (1841)",
            "William Howard Taft (1909-1913)\tJames S. Sherman (1909-1912)",
            "William McKinley (1897-1901)\tGarret Hobart (1897-1899)",
            "Woodrow Wilson (1913-1921)\tThomas R. Marshall (1913-1921)",
            "Zachary Taylor (1849-1850)\tMillard Fillmore (1849-1850)"});
			this.grantorDropdown.Location = new System.Drawing.Point(78, 69);
			this.grantorDropdown.Name = "grantorDropdown";
			this.grantorDropdown.Size = new System.Drawing.Size(241, 21);
			this.grantorDropdown.TabIndex = 5;
			// 
			// AddGrant
			// 
			this.AcceptButton = this.grantSubmitButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(834, 617);
			this.Controls.Add(this.grantNotesText);
			this.Controls.Add(this.emphasisText);
			this.Controls.Add(this.deleteDocTypeButton);
			this.Controls.Add(this.addDocTypeButton);
			this.Controls.Add(this.deleteProgramButton);
			this.Controls.Add(this.addProgramButton);
			this.Controls.Add(this.deleteProjectButton);
			this.Controls.Add(this.addProjectButton);
			this.Controls.Add(this.editAttachmentButton);
			this.Controls.Add(this.addAttachmentButton);
			this.Controls.Add(this.attachmentsList);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.grantSubmitButton);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.grantorWebsiteText);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.cbPayment);
			this.Controls.Add(this.cbStart);
			this.Controls.Add(this.cbTurnAround);
			this.Controls.Add(this.cbDue);
			this.Controls.Add(this.cbSubmit);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.requirementsList);
			this.Controls.Add(this.projectsList);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.programsList);
			this.Controls.Add(this.statusDropdown);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.grantWriterDropdown);
			this.Controls.Add(this.grantorPasswordText);
			this.Controls.Add(this.grantorUsernameText);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.paymentDatePicker);
			this.Controls.Add(this.startDatePicker);
			this.Controls.Add(this.turnaroundPicker);
			this.Controls.Add(this.dueDatePicker);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.submitDatePicker);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.grantDescText);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.actualAmountText);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.requestedAmountText);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.addGrantorButton);
			this.Controls.Add(this.grantNameText);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblGrantor);
			this.Controls.Add(this.grantorDropdown);
			this.Name = "AddGrant";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Grant Editor";
			this.Load += new System.EventHandler(this.AddGrant_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrantor;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button grantSubmitButton;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox grantNameText;
        private System.Windows.Forms.Button addGrantorButton;
        private BetterComboBox grantorDropdown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox requestedAmountText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox actualAmountText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox grantDescText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker submitDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dueDatePicker;
        private System.Windows.Forms.DateTimePicker turnaroundPicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker paymentDatePicker;
        private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox grantorUsernameText;
        private System.Windows.Forms.TextBox grantorPasswordText;
        private BetterComboBox grantWriterDropdown;
        private System.Windows.Forms.Label label15;
        private BetterComboBox statusDropdown;
        private System.Windows.Forms.ListBox programsList;
		private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ListBox projectsList;
		private System.Windows.Forms.ListBox requirementsList;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox cbSubmit;
        private System.Windows.Forms.CheckBox cbDue;
        private System.Windows.Forms.CheckBox cbTurnAround;
        private System.Windows.Forms.CheckBox cbStart;
        private System.Windows.Forms.CheckBox cbPayment;
        private System.Windows.Forms.TextBox grantorWebsiteText;
        private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.ListBox attachmentsList;
		private System.Windows.Forms.Button addAttachmentButton;
		private System.Windows.Forms.Button editAttachmentButton;
		private System.Windows.Forms.Button addProjectButton;
		private System.Windows.Forms.Button deleteProjectButton;
		private System.Windows.Forms.Button deleteProgramButton;
		private System.Windows.Forms.Button addProgramButton;
		private System.Windows.Forms.Button deleteDocTypeButton;
		private System.Windows.Forms.Button addDocTypeButton;
		private TextBoxWithExpandButton emphasisText;
		private TextBoxWithExpandButton grantNotesText;
    }
}