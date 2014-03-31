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
			this.label1.Location = new System.Drawing.Point(23, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Description:";
			// 
			// programNameText
			// 
			this.programNameText.Location = new System.Drawing.Point(99, 37);
			this.programNameText.Name = "programNameText";
			this.programNameText.Size = new System.Drawing.Size(254, 20);
			this.programNameText.TabIndex = 2;
			// 
			// programDescText
			// 
			this.programDescText.Location = new System.Drawing.Point(99, 67);
			this.programDescText.Multiline = true;
			this.programDescText.Name = "programDescText";
			this.programDescText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.programDescText.Size = new System.Drawing.Size(254, 69);
			this.programDescText.TabIndex = 3;
			// 
			// programSubmitButton
			// 
			this.programSubmitButton.Location = new System.Drawing.Point(164, 166);
			this.programSubmitButton.Name = "programSubmitButton";
			this.programSubmitButton.Size = new System.Drawing.Size(75, 23);
			this.programSubmitButton.TabIndex = 4;
			this.programSubmitButton.Text = "Submit";
			this.programSubmitButton.UseVisualStyleBackColor = true;
			// 
			// programCancelButton
			// 
			this.programCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.programCancelButton.Location = new System.Drawing.Point(258, 166);
			this.programCancelButton.Name = "programCancelButton";
			this.programCancelButton.Size = new System.Drawing.Size(75, 23);
			this.programCancelButton.TabIndex = 5;
			this.programCancelButton.Text = "Cancel";
			this.programCancelButton.UseVisualStyleBackColor = true;
			// 
			// AddProgram
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(366, 212);
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