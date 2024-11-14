namespace Municipal_Services.ReportIssuesFile
{
	partial class DisplayReports
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colReportType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AttachFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDownload = new System.Windows.Forms.DataGridViewButtonColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.Back = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colSurname,
            this.colLocation,
            this.colReportType,
            this.colDescription,
            this.AttachFile,
            this.colDownload});
			this.dataGridView1.Location = new System.Drawing.Point(0, 60);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(800, 369);
			this.dataGridView1.TabIndex = 158;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// colName
			// 
			this.colName.HeaderText = "Name";
			this.colName.Name = "colName";
			// 
			// colSurname
			// 
			this.colSurname.HeaderText = "Surname";
			this.colSurname.Name = "colSurname";
			// 
			// colLocation
			// 
			this.colLocation.HeaderText = "Location";
			this.colLocation.Name = "colLocation";
			// 
			// colReportType
			// 
			this.colReportType.HeaderText = "Report Type";
			this.colReportType.Name = "colReportType";
			// 
			// colDescription
			// 
			this.colDescription.HeaderText = "Description";
			this.colDescription.Name = "colDescription";
			// 
			// AttachFile
			// 
			this.AttachFile.HeaderText = "Attach File";
			this.AttachFile.Name = "AttachFile";
			// 
			// colDownload
			// 
			this.colDownload.HeaderText = "Download";
			this.colDownload.Name = "colDownload";
			this.colDownload.Text = "Download";
			this.colDownload.UseColumnTextForButtonValue = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(238, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(278, 39);
			this.label2.TabIndex = 160;
			this.label2.Text = "Display Reports";
			// 
			// Back
			// 
			this.Back.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Back.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Back.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.Back.FlatAppearance.BorderSize = 2;
			this.Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
			this.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSalmon;
			this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Back.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Back.ForeColor = System.Drawing.Color.LightGray;
			this.Back.Location = new System.Drawing.Point(0, 430);
			this.Back.Name = "Back";
			this.Back.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.Back.Size = new System.Drawing.Size(800, 66);
			this.Back.TabIndex = 159;
			this.Back.Tag = "";
			this.Back.Text = "Back";
			this.Back.UseVisualStyleBackColor = false;
			this.Back.Click += new System.EventHandler(this.Back_Click);
			// 
			// DisplayReports
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSlateGray;
			this.ClientSize = new System.Drawing.Size(800, 501);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Back);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "DisplayReports";
			this.Text = "Municipal Services";
			this.Load += new System.EventHandler(this.DisplayReports_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSurname;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
		private System.Windows.Forms.DataGridViewTextBoxColumn colReportType;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn AttachFile;
		private System.Windows.Forms.DataGridViewButtonColumn colDownload;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button Back;
	}
}