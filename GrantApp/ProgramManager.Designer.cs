namespace GrantApp
{
    partial class ProgramManager
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
			this.programGrid = new System.Windows.Forms.DataGridView();
			this.addProgram = new System.Windows.Forms.Button();
			this.editProgram = new System.Windows.Forms.Button();
			this.deleteProgram = new System.Windows.Forms.Button();
			this.searchBox = new System.Windows.Forms.TextBox();
			this.searchProgram = new System.Windows.Forms.Button();
			this.refreshButton = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.programGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// programGrid
			// 
			this.programGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.programGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.programGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.programGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.programGrid.Location = new System.Drawing.Point(12, 64);
			this.programGrid.MultiSelect = false;
			this.programGrid.Name = "programGrid";
			this.programGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.programGrid.Size = new System.Drawing.Size(561, 414);
			this.programGrid.TabIndex = 6;
			// 
			// addProgram
			// 
			this.addProgram.Location = new System.Drawing.Point(12, 9);
			this.addProgram.Name = "addProgram";
			this.addProgram.Size = new System.Drawing.Size(75, 23);
			this.addProgram.TabIndex = 1;
			this.addProgram.Text = "Add";
			this.addProgram.UseVisualStyleBackColor = true;
			// 
			// editProgram
			// 
			this.editProgram.Location = new System.Drawing.Point(93, 9);
			this.editProgram.Name = "editProgram";
			this.editProgram.Size = new System.Drawing.Size(75, 23);
			this.editProgram.TabIndex = 2;
			this.editProgram.Text = "Edit";
			this.editProgram.UseVisualStyleBackColor = true;
			// 
			// deleteProgram
			// 
			this.deleteProgram.Location = new System.Drawing.Point(174, 9);
			this.deleteProgram.Name = "deleteProgram";
			this.deleteProgram.Size = new System.Drawing.Size(75, 23);
			this.deleteProgram.TabIndex = 3;
			this.deleteProgram.Text = "Delete";
			this.deleteProgram.UseVisualStyleBackColor = true;
			// 
			// searchBox
			// 
			this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.searchBox.Location = new System.Drawing.Point(12, 38);
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(451, 20);
			this.searchBox.TabIndex = 4;
			// 
			// searchProgram
			// 
			this.searchProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.searchProgram.Location = new System.Drawing.Point(498, 35);
			this.searchProgram.Name = "searchProgram";
			this.searchProgram.Size = new System.Drawing.Size(75, 23);
			this.searchProgram.TabIndex = 5;
			this.searchProgram.Text = "Search";
			this.searchProgram.UseVisualStyleBackColor = true;
			// 
			// refreshButton
			// 
			this.refreshButton.Location = new System.Drawing.Point(255, 9);
			this.refreshButton.Name = "refreshButton";
			this.refreshButton.Size = new System.Drawing.Size(75, 23);
			this.refreshButton.TabIndex = 7;
			this.refreshButton.Text = "Refresh";
			this.refreshButton.UseVisualStyleBackColor = true;
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(469, 35);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(23, 23);
			this.btnClear.TabIndex = 26;
			this.btnClear.Text = "X";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// ProgramManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(585, 490);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.refreshButton);
			this.Controls.Add(this.searchBox);
			this.Controls.Add(this.searchProgram);
			this.Controls.Add(this.programGrid);
			this.Controls.Add(this.addProgram);
			this.Controls.Add(this.editProgram);
			this.Controls.Add(this.deleteProgram);
			this.Name = "ProgramManager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Programs";
			((System.ComponentModel.ISupportInitialize)(this.programGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView programGrid;
        private System.Windows.Forms.Button addProgram;
        private System.Windows.Forms.Button editProgram;
        private System.Windows.Forms.Button deleteProgram;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchProgram;
        private System.Windows.Forms.Button refreshButton;
		private System.Windows.Forms.Button btnClear;


    }
}