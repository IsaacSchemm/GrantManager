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
			this.grantNotesText = new System.Windows.Forms.TextBox();
			this.emphasisText = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.grantorUsernameText = new System.Windows.Forms.TextBox();
			this.grantorPasswordText = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.programsList = new System.Windows.Forms.ListBox();
			this.label11 = new System.Windows.Forms.Label();
			this.addProgramButton = new System.Windows.Forms.Button();
			this.label16 = new System.Windows.Forms.Label();
			this.projectsList = new System.Windows.Forms.ListBox();
			this.addProjectButton = new System.Windows.Forms.Button();
			this.documentationList = new System.Windows.Forms.ListBox();
			this.docButton = new System.Windows.Forms.Button();
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
			this.statusDropdown = new GrantApp.BetterComboBox();
			this.grantWriterDropdown = new GrantApp.BetterComboBox();
			this.grantorDropdown = new GrantApp.BetterComboBox();
			this.SuspendLayout();
			// 
			// lblGrantor
			// 
			this.lblGrantor.AutoSize = true;
			this.lblGrantor.Location = new System.Drawing.Point(16, 89);
			this.lblGrantor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblGrantor.Name = "lblGrantor";
			this.lblGrantor.Size = new System.Drawing.Size(61, 17);
			this.lblGrantor.TabIndex = 1;
			this.lblGrantor.Text = "Grantor:";
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(1123, 716);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(107, 28);
			this.btnCancel.TabIndex = 38;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// grantSubmitButton
			// 
			this.grantSubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.grantSubmitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.grantSubmitButton.Location = new System.Drawing.Point(1008, 716);
			this.grantSubmitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.grantSubmitButton.Name = "grantSubmitButton";
			this.grantSubmitButton.Size = new System.Drawing.Size(107, 28);
			this.grantSubmitButton.TabIndex = 36;
			this.grantSubmitButton.Text = "Submit";
			this.grantSubmitButton.UseVisualStyleBackColor = true;
			this.grantSubmitButton.Click += new System.EventHandler(this.grantSubmitButton_Click);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(16, 11);
			this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(49, 17);
			this.lblName.TabIndex = 4;
			this.lblName.Text = "Name:";
			// 
			// grantNameText
			// 
			this.grantNameText.Location = new System.Drawing.Point(104, 7);
			this.grantNameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.grantNameText.Name = "grantNameText";
			this.grantNameText.Size = new System.Drawing.Size(320, 22);
			this.grantNameText.TabIndex = 1;
			// 
			// addGrantorButton
			// 
			this.addGrantorButton.Location = new System.Drawing.Point(288, 129);
			this.addGrantorButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addGrantorButton.Name = "addGrantorButton";
			this.addGrantorButton.Size = new System.Drawing.Size(137, 28);
			this.addGrantorButton.TabIndex = 4;
			this.addGrantorButton.Text = "Add New Grantor";
			this.addGrantorButton.UseVisualStyleBackColor = true;
			this.addGrantorButton.Click += new System.EventHandler(this.addGrantorButton_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 412);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(133, 17);
			this.label5.TabIndex = 17;
			this.label5.Text = "Requested Amount:";
			// 
			// requestedAmountText
			// 
			this.requestedAmountText.Location = new System.Drawing.Point(159, 409);
			this.requestedAmountText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.requestedAmountText.Name = "requestedAmountText";
			this.requestedAmountText.Size = new System.Drawing.Size(265, 22);
			this.requestedAmountText.TabIndex = 15;
			this.requestedAmountText.Text = "0.00";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(16, 446);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(99, 17);
			this.label6.TabIndex = 19;
			this.label6.Text = "Actual Amount";
			// 
			// actualAmountText
			// 
			this.actualAmountText.Location = new System.Drawing.Point(159, 442);
			this.actualAmountText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.actualAmountText.Name = "actualAmountText";
			this.actualAmountText.Size = new System.Drawing.Size(265, 22);
			this.actualAmountText.TabIndex = 16;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 52);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 17);
			this.label1.TabIndex = 21;
			this.label1.Text = "Description:";
			// 
			// grantDescText
			// 
			this.grantDescText.Location = new System.Drawing.Point(104, 48);
			this.grantDescText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.grantDescText.Name = "grantDescText";
			this.grantDescText.Size = new System.Drawing.Size(320, 22);
			this.grantDescText.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 181);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 17);
			this.label2.TabIndex = 23;
			this.label2.Text = "Submit Date:";
			// 
			// submitDatePicker
			// 
			this.submitDatePicker.Enabled = false;
			this.submitDatePicker.Location = new System.Drawing.Point(144, 181);
			this.submitDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.submitDatePicker.Name = "submitDatePicker";
			this.submitDatePicker.Size = new System.Drawing.Size(280, 22);
			this.submitDatePicker.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 224);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 17);
			this.label3.TabIndex = 25;
			this.label3.Text = "Due Date:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 262);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(121, 17);
			this.label4.TabIndex = 26;
			this.label4.Text = "Turnaround Date:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(16, 300);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 17);
			this.label7.TabIndex = 27;
			this.label7.Text = "Start Date:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(16, 341);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(101, 17);
			this.label8.TabIndex = 28;
			this.label8.Text = "Payment Date:";
			// 
			// dueDatePicker
			// 
			this.dueDatePicker.Enabled = false;
			this.dueDatePicker.Location = new System.Drawing.Point(144, 224);
			this.dueDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dueDatePicker.Name = "dueDatePicker";
			this.dueDatePicker.Size = new System.Drawing.Size(280, 22);
			this.dueDatePicker.TabIndex = 7;
			// 
			// turnaroundPicker
			// 
			this.turnaroundPicker.Enabled = false;
			this.turnaroundPicker.Location = new System.Drawing.Point(145, 262);
			this.turnaroundPicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.turnaroundPicker.Name = "turnaroundPicker";
			this.turnaroundPicker.Size = new System.Drawing.Size(279, 22);
			this.turnaroundPicker.TabIndex = 9;
			// 
			// startDatePicker
			// 
			this.startDatePicker.Enabled = false;
			this.startDatePicker.Location = new System.Drawing.Point(144, 300);
			this.startDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.startDatePicker.Name = "startDatePicker";
			this.startDatePicker.Size = new System.Drawing.Size(280, 22);
			this.startDatePicker.TabIndex = 11;
			// 
			// paymentDatePicker
			// 
			this.paymentDatePicker.Enabled = false;
			this.paymentDatePicker.Location = new System.Drawing.Point(144, 341);
			this.paymentDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.paymentDatePicker.Name = "paymentDatePicker";
			this.paymentDatePicker.Size = new System.Drawing.Size(280, 22);
			this.paymentDatePicker.TabIndex = 13;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(16, 606);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(132, 17);
			this.label9.TabIndex = 33;
			this.label9.Text = "Website Username:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(16, 636);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(128, 17);
			this.label10.TabIndex = 34;
			this.label10.Text = "Website Password:";
			// 
			// grantNotesText
			// 
			this.grantNotesText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grantNotesText.Location = new System.Drawing.Point(839, 426);
			this.grantNotesText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.grantNotesText.Multiline = true;
			this.grantNotesText.Name = "grantNotesText";
			this.grantNotesText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.grantNotesText.Size = new System.Drawing.Size(389, 278);
			this.grantNotesText.TabIndex = 34;
			// 
			// emphasisText
			// 
			this.emphasisText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.emphasisText.Location = new System.Drawing.Point(933, 181);
			this.emphasisText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.emphasisText.Multiline = true;
			this.emphasisText.Name = "emphasisText";
			this.emphasisText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.emphasisText.Size = new System.Drawing.Size(297, 70);
			this.emphasisText.TabIndex = 28;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(780, 181);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(131, 17);
			this.label14.TabIndex = 40;
			this.label14.Text = "Program Emphasis:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(780, 430);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(49, 17);
			this.label13.TabIndex = 39;
			this.label13.Text = "Notes:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(16, 683);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(90, 17);
			this.label12.TabIndex = 38;
			this.label12.Text = "Grant Writer:";
			// 
			// grantorUsernameText
			// 
			this.grantorUsernameText.Location = new System.Drawing.Point(155, 602);
			this.grantorUsernameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.grantorUsernameText.Name = "grantorUsernameText";
			this.grantorUsernameText.Size = new System.Drawing.Size(269, 22);
			this.grantorUsernameText.TabIndex = 19;
			// 
			// grantorPasswordText
			// 
			this.grantorPasswordText.Location = new System.Drawing.Point(155, 633);
			this.grantorPasswordText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.grantorPasswordText.Name = "grantorPasswordText";
			this.grantorPasswordText.Size = new System.Drawing.Size(269, 22);
			this.grantorPasswordText.TabIndex = 20;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(20, 505);
			this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(52, 17);
			this.label15.TabIndex = 47;
			this.label15.Text = "Status:";
			// 
			// programsList
			// 
			this.programsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.programsList.FormattingEnabled = true;
			this.programsList.ItemHeight = 16;
			this.programsList.Location = new System.Drawing.Point(932, 11);
			this.programsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.programsList.Name = "programsList";
			this.programsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.programsList.Size = new System.Drawing.Size(297, 116);
			this.programsList.Sorted = true;
			this.programsList.TabIndex = 24;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(780, 11);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(73, 17);
			this.label11.TabIndex = 49;
			this.label11.Text = "Programs:";
			// 
			// addProgramButton
			// 
			this.addProgramButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addProgramButton.Location = new System.Drawing.Point(1001, 135);
			this.addProgramButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addProgramButton.Name = "addProgramButton";
			this.addProgramButton.Size = new System.Drawing.Size(229, 28);
			this.addProgramButton.TabIndex = 26;
			this.addProgramButton.Text = "Add New Program";
			this.addProgramButton.UseVisualStyleBackColor = true;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(463, 11);
			this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(63, 17);
			this.label16.TabIndex = 51;
			this.label16.Text = "Projects:";
			// 
			// projectsList
			// 
			this.projectsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.projectsList.FormattingEnabled = true;
			this.projectsList.ItemHeight = 16;
			this.projectsList.Location = new System.Drawing.Point(466, 32);
			this.projectsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.projectsList.Name = "projectsList";
			this.projectsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.projectsList.Size = new System.Drawing.Size(304, 100);
			this.projectsList.Sorted = true;
			this.projectsList.TabIndex = 22;
			// 
			// addProjectButton
			// 
			this.addProjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.addProjectButton.Location = new System.Drawing.Point(614, 140);
			this.addProjectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addProjectButton.Name = "addProjectButton";
			this.addProjectButton.Size = new System.Drawing.Size(157, 28);
			this.addProjectButton.TabIndex = 23;
			this.addProjectButton.Text = "Add New Project";
			this.addProjectButton.UseVisualStyleBackColor = true;
			// 
			// documentationList
			// 
			this.documentationList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.documentationList.FormattingEnabled = true;
			this.documentationList.ItemHeight = 16;
			this.documentationList.Location = new System.Drawing.Point(933, 266);
			this.documentationList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.documentationList.Name = "documentationList";
			this.documentationList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.documentationList.Size = new System.Drawing.Size(297, 116);
			this.documentationList.Sorted = true;
			this.documentationList.TabIndex = 30;
			// 
			// docButton
			// 
			this.docButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.docButton.Location = new System.Drawing.Point(1003, 390);
			this.docButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.docButton.Name = "docButton";
			this.docButton.Size = new System.Drawing.Size(229, 28);
			this.docButton.TabIndex = 32;
			this.docButton.Text = "Add Documentation Type";
			this.docButton.UseVisualStyleBackColor = true;
			this.docButton.Click += new System.EventHandler(this.docButton_Click);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(780, 270);
			this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(143, 17);
			this.label17.TabIndex = 56;
			this.label17.Text = "Documentation Type:";
			// 
			// cbSubmit
			// 
			this.cbSubmit.AutoSize = true;
			this.cbSubmit.Location = new System.Drawing.Point(435, 183);
			this.cbSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbSubmit.Name = "cbSubmit";
			this.cbSubmit.Size = new System.Drawing.Size(18, 17);
			this.cbSubmit.TabIndex = 6;
			this.cbSubmit.UseVisualStyleBackColor = true;
			this.cbSubmit.CheckedChanged += new System.EventHandler(this.cbSubmit_CheckedChanged);
			// 
			// cbDue
			// 
			this.cbDue.AutoSize = true;
			this.cbDue.Location = new System.Drawing.Point(433, 228);
			this.cbDue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbDue.Name = "cbDue";
			this.cbDue.Size = new System.Drawing.Size(18, 17);
			this.cbDue.TabIndex = 8;
			this.cbDue.UseVisualStyleBackColor = true;
			this.cbDue.CheckedChanged += new System.EventHandler(this.cbDue_CheckedChanged);
			// 
			// cbTurnAround
			// 
			this.cbTurnAround.AutoSize = true;
			this.cbTurnAround.Location = new System.Drawing.Point(435, 266);
			this.cbTurnAround.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbTurnAround.Name = "cbTurnAround";
			this.cbTurnAround.Size = new System.Drawing.Size(18, 17);
			this.cbTurnAround.TabIndex = 10;
			this.cbTurnAround.UseVisualStyleBackColor = true;
			this.cbTurnAround.CheckedChanged += new System.EventHandler(this.cbTurnAround_CheckedChanged);
			// 
			// cbStart
			// 
			this.cbStart.AutoSize = true;
			this.cbStart.Location = new System.Drawing.Point(433, 304);
			this.cbStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbStart.Name = "cbStart";
			this.cbStart.Size = new System.Drawing.Size(18, 17);
			this.cbStart.TabIndex = 12;
			this.cbStart.UseVisualStyleBackColor = true;
			this.cbStart.CheckedChanged += new System.EventHandler(this.cbStart_CheckedChanged);
			// 
			// cbPayment
			// 
			this.cbPayment.AutoSize = true;
			this.cbPayment.Location = new System.Drawing.Point(435, 345);
			this.cbPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbPayment.Name = "cbPayment";
			this.cbPayment.Size = new System.Drawing.Size(18, 17);
			this.cbPayment.TabIndex = 14;
			this.cbPayment.UseVisualStyleBackColor = true;
			this.cbPayment.CheckedChanged += new System.EventHandler(this.cbPayment_CheckedChanged);
			// 
			// grantorWebsiteText
			// 
			this.grantorWebsiteText.Location = new System.Drawing.Point(155, 570);
			this.grantorWebsiteText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.grantorWebsiteText.Name = "grantorWebsiteText";
			this.grantorWebsiteText.Size = new System.Drawing.Size(269, 22);
			this.grantorWebsiteText.TabIndex = 18;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(16, 574);
			this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(63, 17);
			this.label18.TabIndex = 58;
			this.label18.Text = "Website:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(464, 207);
			this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(90, 17);
			this.label19.TabIndex = 59;
			this.label19.Text = "Attachments:";
			// 
			// attachmentsList
			// 
			this.attachmentsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.attachmentsList.FormattingEnabled = true;
			this.attachmentsList.ItemHeight = 16;
			this.attachmentsList.Location = new System.Drawing.Point(467, 228);
			this.attachmentsList.Margin = new System.Windows.Forms.Padding(4);
			this.attachmentsList.Name = "attachmentsList";
			this.attachmentsList.Size = new System.Drawing.Size(304, 148);
			this.attachmentsList.Sorted = true;
			this.attachmentsList.TabIndex = 60;
			// 
			// addAttachmentButton
			// 
			this.addAttachmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.addAttachmentButton.Location = new System.Drawing.Point(706, 384);
			this.addAttachmentButton.Margin = new System.Windows.Forms.Padding(4);
			this.addAttachmentButton.Name = "addAttachmentButton";
			this.addAttachmentButton.Size = new System.Drawing.Size(64, 28);
			this.addAttachmentButton.TabIndex = 61;
			this.addAttachmentButton.Text = "Add";
			this.addAttachmentButton.UseVisualStyleBackColor = true;
			this.addAttachmentButton.Click += new System.EventHandler(this.addAttachmentButton_Click);
			// 
			// editAttachmentButton
			// 
			this.editAttachmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.editAttachmentButton.Location = new System.Drawing.Point(634, 384);
			this.editAttachmentButton.Margin = new System.Windows.Forms.Padding(4);
			this.editAttachmentButton.Name = "editAttachmentButton";
			this.editAttachmentButton.Size = new System.Drawing.Size(64, 28);
			this.editAttachmentButton.TabIndex = 62;
			this.editAttachmentButton.Text = "Edit";
			this.editAttachmentButton.UseVisualStyleBackColor = true;
			this.editAttachmentButton.Click += new System.EventHandler(this.editAttachmentButton_Click);
			// 
			// statusDropdown
			// 
			this.statusDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.statusDropdown.FormattingEnabled = true;
			this.statusDropdown.Location = new System.Drawing.Point(159, 501);
			this.statusDropdown.Margin = new System.Windows.Forms.Padding(4);
			this.statusDropdown.Name = "statusDropdown";
			this.statusDropdown.Size = new System.Drawing.Size(265, 24);
			this.statusDropdown.TabIndex = 17;
			// 
			// grantWriterDropdown
			// 
			this.grantWriterDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.grantWriterDropdown.FormattingEnabled = true;
			this.grantWriterDropdown.Location = new System.Drawing.Point(159, 679);
			this.grantWriterDropdown.Margin = new System.Windows.Forms.Padding(4);
			this.grantWriterDropdown.Name = "grantWriterDropdown";
			this.grantWriterDropdown.Size = new System.Drawing.Size(265, 24);
			this.grantWriterDropdown.TabIndex = 21;
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
			this.grantorDropdown.Location = new System.Drawing.Point(104, 85);
			this.grantorDropdown.Margin = new System.Windows.Forms.Padding(4);
			this.grantorDropdown.Name = "grantorDropdown";
			this.grantorDropdown.Size = new System.Drawing.Size(320, 24);
			this.grantorDropdown.TabIndex = 3;
			// 
			// AddGrant
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(1245, 759);
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
			this.Controls.Add(this.documentationList);
			this.Controls.Add(this.addProjectButton);
			this.Controls.Add(this.projectsList);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.programsList);
			this.Controls.Add(this.statusDropdown);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.grantWriterDropdown);
			this.Controls.Add(this.grantorPasswordText);
			this.Controls.Add(this.grantorUsernameText);
			this.Controls.Add(this.grantNotesText);
			this.Controls.Add(this.emphasisText);
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
			this.Controls.Add(this.docButton);
			this.Controls.Add(this.addProgramButton);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox grantNotesText;
        private System.Windows.Forms.TextBox emphasisText;
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
        private System.Windows.Forms.Button addProgramButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox projectsList;
        private System.Windows.Forms.Button addProjectButton;
        private System.Windows.Forms.ListBox documentationList;
        private System.Windows.Forms.Button docButton;
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
    }
}