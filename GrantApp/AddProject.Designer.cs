namespace GrantApp
{
    partial class AddProject
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
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.submitButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.nameText = new System.Windows.Forms.TextBox();
			this.objectivesText = new GrantApp.TextBoxWithExpandButton();
			this.outcomesText = new GrantApp.TextBoxWithExpandButton();
			this.notesText = new GrantApp.TextBoxWithExpandButton();
			this.lettersText = new GrantApp.TextBoxWithExpandButton();
			this.overviewText = new GrantApp.TextBoxWithExpandButton();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 27);
			this.label1.Margin = new System.Windows.Forms.Padding(8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 60);
			this.label2.Margin = new System.Windows.Forms.Padding(8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Overview:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(24, 141);
			this.label4.Margin = new System.Windows.Forms.Padding(8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Objectives:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(21, 222);
			this.label5.Margin = new System.Windows.Forms.Padding(8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Outcomes:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(21, 303);
			this.label8.Margin = new System.Windows.Forms.Padding(8);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(94, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "Letters of Support:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(24, 384);
			this.label9.Margin = new System.Windows.Forms.Padding(8);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(38, 13);
			this.label9.TabIndex = 8;
			this.label9.Text = "Notes:";
			// 
			// submitButton
			// 
			this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.submitButton.Location = new System.Drawing.Point(401, 440);
			this.submitButton.Margin = new System.Windows.Forms.Padding(8);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(75, 23);
			this.submitButton.TabIndex = 20;
			this.submitButton.Text = "Submit";
			this.submitButton.UseVisualStyleBackColor = true;
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.CausesValidation = false;
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(492, 440);
			this.cancelButton.Margin = new System.Windows.Forms.Padding(8);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 21;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// nameText
			// 
			this.nameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nameText.Location = new System.Drawing.Point(117, 24);
			this.nameText.Margin = new System.Windows.Forms.Padding(8);
			this.nameText.Name = "nameText";
			this.nameText.Size = new System.Drawing.Size(179, 20);
			this.nameText.TabIndex = 11;
			// 
			// objectivesText
			// 
			this.objectivesText.AcceptsReturn = true;
			this.objectivesText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.objectivesText.Location = new System.Drawing.Point(117, 141);
			this.objectivesText.Margin = new System.Windows.Forms.Padding(8);
			this.objectivesText.Multiline = true;
			this.objectivesText.Name = "objectivesText";
			this.objectivesText.ReadOnly = false;
			this.objectivesText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.objectivesText.Size = new System.Drawing.Size(179, 65);
			this.objectivesText.TabIndex = 14;
			// 
			// outcomesText
			// 
			this.outcomesText.AcceptsReturn = true;
			this.outcomesText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.outcomesText.Location = new System.Drawing.Point(117, 222);
			this.outcomesText.Margin = new System.Windows.Forms.Padding(8);
			this.outcomesText.Multiline = true;
			this.outcomesText.Name = "outcomesText";
			this.outcomesText.ReadOnly = false;
			this.outcomesText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.outcomesText.Size = new System.Drawing.Size(179, 65);
			this.outcomesText.TabIndex = 15;
			// 
			// notesText
			// 
			this.notesText.AcceptsReturn = true;
			this.notesText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.notesText.Location = new System.Drawing.Point(117, 384);
			this.notesText.Margin = new System.Windows.Forms.Padding(8);
			this.notesText.Multiline = true;
			this.notesText.Name = "notesText";
			this.notesText.ReadOnly = false;
			this.notesText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.notesText.Size = new System.Drawing.Size(179, 40);
			this.notesText.TabIndex = 19;
			// 
			// lettersText
			// 
			this.lettersText.AcceptsReturn = true;
			this.lettersText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lettersText.Location = new System.Drawing.Point(117, 303);
			this.lettersText.Margin = new System.Windows.Forms.Padding(8);
			this.lettersText.Multiline = true;
			this.lettersText.Name = "lettersText";
			this.lettersText.ReadOnly = false;
			this.lettersText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.lettersText.Size = new System.Drawing.Size(179, 65);
			this.lettersText.TabIndex = 18;
			// 
			// overviewText
			// 
			this.overviewText.AcceptsReturn = true;
			this.overviewText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.overviewText.Location = new System.Drawing.Point(117, 60);
			this.overviewText.Margin = new System.Windows.Forms.Padding(8);
			this.overviewText.Multiline = true;
			this.overviewText.Name = "overviewText";
			this.overviewText.ReadOnly = false;
			this.overviewText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.overviewText.Size = new System.Drawing.Size(179, 65);
			this.overviewText.TabIndex = 12;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(312, 27);
			this.label3.Margin = new System.Windows.Forms.Padding(8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 13);
			this.label3.TabIndex = 22;
			this.label3.Text = "Organizational Budget:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(315, 56);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(8);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(252, 368);
			this.dataGridView1.TabIndex = 23;
			// 
			// AddProject
			// 
			this.AcceptButton = this.submitButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(584, 480);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lettersText);
			this.Controls.Add(this.notesText);
			this.Controls.Add(this.outcomesText);
			this.Controls.Add(this.objectivesText);
			this.Controls.Add(this.overviewText);
			this.Controls.Add(this.nameText);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.submitButton);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "AddProject";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Project Editor";
			this.Load += new System.EventHandler(this.AddProject_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.TextBox nameText;
		private TextBoxWithExpandButton objectivesText;
		private TextBoxWithExpandButton outcomesText;
		private TextBoxWithExpandButton notesText;
		private TextBoxWithExpandButton lettersText;
		private TextBoxWithExpandButton overviewText;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridView1;
    }
}