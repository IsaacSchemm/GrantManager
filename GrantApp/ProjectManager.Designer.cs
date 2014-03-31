namespace GrantApp
{
    partial class ProjectManager
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
            this.projectGrid = new System.Windows.Forms.DataGridView();
            this.addProject = new System.Windows.Forms.Button();
            this.editProject = new System.Windows.Forms.Button();
            this.deleteProject = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchProject = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.projectGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // projectGrid
            // 
            this.projectGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.projectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.projectGrid.Location = new System.Drawing.Point(12, 67);
            this.projectGrid.MultiSelect = false;
            this.projectGrid.Name = "projectGrid";
            this.projectGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.projectGrid.Size = new System.Drawing.Size(562, 417);
            this.projectGrid.TabIndex = 36;
            // 
            // addProject
            // 
            this.addProject.Location = new System.Drawing.Point(12, 12);
            this.addProject.Name = "addProject";
            this.addProject.Size = new System.Drawing.Size(75, 23);
            this.addProject.TabIndex = 1;
            this.addProject.Text = "Add";
            this.addProject.UseVisualStyleBackColor = true;
            // 
            // editProject
            // 
            this.editProject.Location = new System.Drawing.Point(93, 12);
            this.editProject.Name = "editProject";
            this.editProject.Size = new System.Drawing.Size(75, 23);
            this.editProject.TabIndex = 2;
            this.editProject.Text = "Edit";
            this.editProject.UseVisualStyleBackColor = true;
            // 
            // deleteProject
            // 
            this.deleteProject.Location = new System.Drawing.Point(174, 12);
            this.deleteProject.Name = "deleteProject";
            this.deleteProject.Size = new System.Drawing.Size(75, 23);
            this.deleteProject.TabIndex = 3;
            this.deleteProject.Text = "Delete";
            this.deleteProject.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(12, 41);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(480, 20);
            this.searchBox.TabIndex = 4;
            // 
            // searchProject
            // 
            this.searchProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchProject.Location = new System.Drawing.Point(498, 38);
            this.searchProject.Name = "searchProject";
            this.searchProject.Size = new System.Drawing.Size(75, 23);
            this.searchProject.TabIndex = 5;
            this.searchProject.Text = "Search";
            this.searchProject.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(255, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 37;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            // 
            // ProjectManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 496);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchProject);
            this.Controls.Add(this.projectGrid);
            this.Controls.Add(this.addProject);
            this.Controls.Add(this.editProject);
            this.Controls.Add(this.deleteProject);
            this.Name = "ProjectManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Projects";
            ((System.ComponentModel.ISupportInitialize)(this.projectGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView projectGrid;
        private System.Windows.Forms.Button addProject;
        private System.Windows.Forms.Button editProject;
        private System.Windows.Forms.Button deleteProject;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchProject;
        private System.Windows.Forms.Button refreshButton;

    }
}