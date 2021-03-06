namespace GrantApp
{
    partial class GrantManager
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
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.grantGrid = new System.Windows.Forms.DataGridView();
			this.searchBox = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnTimeline = new System.Windows.Forms.Button();
			this.contactButton = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnBudget = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grantGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(12, 6);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(93, 6);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 1;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(174, 6);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// grantGrid
			// 
			this.grantGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grantGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grantGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grantGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.grantGrid.Location = new System.Drawing.Point(12, 74);
			this.grantGrid.MultiSelect = false;
			this.grantGrid.Name = "grantGrid";
			this.grantGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grantGrid.Size = new System.Drawing.Size(561, 474);
			this.grantGrid.TabIndex = 9;
			this.grantGrid.DoubleClick += new System.EventHandler(this.openGrantDetails);
			// 
			// searchBox
			// 
			this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.searchBox.Location = new System.Drawing.Point(12, 48);
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(451, 20);
			this.searchBox.TabIndex = 6;
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSearch.Location = new System.Drawing.Point(498, 45);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 24);
			this.btnSearch.TabIndex = 8;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnTimeline
			// 
			this.btnTimeline.Location = new System.Drawing.Point(348, 6);
			this.btnTimeline.Name = "btnTimeline";
			this.btnTimeline.Size = new System.Drawing.Size(75, 23);
			this.btnTimeline.TabIndex = 4;
			this.btnTimeline.Text = "Timeline";
			this.btnTimeline.UseVisualStyleBackColor = true;
			this.btnTimeline.Click += new System.EventHandler(this.btnTimeline_Click);
			// 
			// contactButton
			// 
			this.contactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.contactButton.Location = new System.Drawing.Point(460, 6);
			this.contactButton.Name = "contactButton";
			this.contactButton.Size = new System.Drawing.Size(113, 23);
			this.contactButton.TabIndex = 5;
			this.contactButton.Text = "Edit Contact History";
			this.contactButton.UseVisualStyleBackColor = true;
			this.contactButton.Click += new System.EventHandler(this.editContactHistory);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(469, 46);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(23, 23);
			this.btnClear.TabIndex = 7;
			this.btnClear.Text = "X";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnBudget
			// 
			this.btnBudget.Location = new System.Drawing.Point(267, 6);
			this.btnBudget.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
			this.btnBudget.Name = "btnBudget";
			this.btnBudget.Size = new System.Drawing.Size(75, 23);
			this.btnBudget.TabIndex = 3;
			this.btnBudget.Text = "Budget";
			this.btnBudget.UseVisualStyleBackColor = true;
			this.btnBudget.Click += new System.EventHandler(this.btnBudget_Click);
			// 
			// GrantManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(585, 560);
			this.Controls.Add(this.btnBudget);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.contactButton);
			this.Controls.Add(this.btnTimeline);
			this.Controls.Add(this.searchBox);
			this.Controls.Add(this.grantGrid);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnSearch);
			this.Name = "GrantManager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Grants";
			this.Load += new System.EventHandler(this.GrantManager_Load);
			((System.ComponentModel.ISupportInitialize)(this.grantGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.DataGridView grantGrid;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnTimeline;
        private System.Windows.Forms.Button contactButton;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnBudget;

    }
}

