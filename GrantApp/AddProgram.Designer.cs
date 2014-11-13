namespace GrantApp
{
    partial class AddProgram
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
            this.programNameText = new System.Windows.Forms.TextBox();
            this.programDescText = new System.Windows.Forms.TextBox();
            this.programSubmitButton = new System.Windows.Forms.Button();
            this.programCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // programNameText
            // 
            this.programNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.programNameText.Location = new System.Drawing.Point(81, 6);
            this.programNameText.Name = "programNameText";
            this.programNameText.Size = new System.Drawing.Size(229, 20);
            this.programNameText.TabIndex = 2;
            // 
            // programDescText
            // 
            this.programDescText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.programDescText.Location = new System.Drawing.Point(81, 32);
            this.programDescText.Multiline = true;
            this.programDescText.Name = "programDescText";
            this.programDescText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.programDescText.Size = new System.Drawing.Size(229, 120);
            this.programDescText.TabIndex = 3;
            // 
            // programSubmitButton
            // 
            this.programSubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.programSubmitButton.Location = new System.Drawing.Point(154, 158);
            this.programSubmitButton.Name = "programSubmitButton";
            this.programSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.programSubmitButton.TabIndex = 4;
            this.programSubmitButton.Text = "Submit";
            this.programSubmitButton.UseVisualStyleBackColor = true;
            // 
            // programCancelButton
            // 
            this.programCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.programCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.programCancelButton.Location = new System.Drawing.Point(235, 158);
            this.programCancelButton.Name = "programCancelButton";
            this.programCancelButton.Size = new System.Drawing.Size(75, 23);
            this.programCancelButton.TabIndex = 5;
            this.programCancelButton.Text = "Cancel";
            this.programCancelButton.UseVisualStyleBackColor = true;
            // 
            // AddProgram
            // 
            this.AcceptButton = this.programSubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.programCancelButton;
            this.ClientSize = new System.Drawing.Size(322, 193);
            this.Controls.Add(this.programCancelButton);
            this.Controls.Add(this.programSubmitButton);
            this.Controls.Add(this.programDescText);
            this.Controls.Add(this.programNameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Program Editor";
            this.Load += new System.EventHandler(this.AddProgram_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox programNameText;
        private System.Windows.Forms.TextBox programDescText;
        private System.Windows.Forms.Button programSubmitButton;
        private System.Windows.Forms.Button programCancelButton;
    }
}