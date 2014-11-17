namespace GrantApp {
	partial class TimelineManager {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Save = new System.Windows.Forms.Button();
			this.IDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColorCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.ColorPreview = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCol,
            this.DateCol,
            this.NameCol,
            this.ColorCol,
            this.ColorPreview});
			this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(562, 443);
			this.dataGridView1.TabIndex = 0;
			// 
			// Save
			// 
			this.Save.Location = new System.Drawing.Point(499, 461);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(75, 23);
			this.Save.TabIndex = 1;
			this.Save.Text = "btnSave";
			this.Save.UseVisualStyleBackColor = true;
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// IDCol
			// 
			this.IDCol.HeaderText = "ID";
			this.IDCol.Name = "IDCol";
			this.IDCol.Visible = false;
			// 
			// DateCol
			// 
			this.DateCol.HeaderText = "Date";
			this.DateCol.Name = "DateCol";
			// 
			// NameCol
			// 
			this.NameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NameCol.HeaderText = "Name";
			this.NameCol.Name = "NameCol";
			// 
			// ColorCol
			// 
			this.ColorCol.HeaderText = "Color";
			this.ColorCol.Items.AddRange(new object[] {
            "a",
            "b",
            "c"});
			this.ColorCol.Name = "ColorCol";
			// 
			// ColorPreview
			// 
			this.ColorPreview.HeaderText = "";
			this.ColorPreview.Name = "ColorPreview";
			this.ColorPreview.Width = 50;
			// 
			// TimelineManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(586, 496);
			this.Controls.Add(this.Save);
			this.Controls.Add(this.dataGridView1);
			this.Name = "TimelineManager";
			this.Text = "TimelineManager";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button Save;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
		private System.Windows.Forms.DataGridViewComboBoxColumn ColorCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColorPreview;
	}
}