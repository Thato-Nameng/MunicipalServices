namespace Municipal_Services.LocalEventsFile
{
	partial class LocalEvents
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
			this.Back = new System.Windows.Forms.Button();
			this.lvEvents = new System.Windows.Forms.ListView();
			this.dtpSearchDate = new System.Windows.Forms.DateTimePicker();
			this.txtSearchCategory = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.btnClear = new System.Windows.Forms.Button();
			this.chkEnableDateFilter = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
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
			this.Back.Location = new System.Drawing.Point(1, 246);
			this.Back.Name = "Back";
			this.Back.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.Back.Size = new System.Drawing.Size(517, 42);
			this.Back.TabIndex = 108;
			this.Back.Tag = "";
			this.Back.Text = "Back";
			this.Back.UseVisualStyleBackColor = false;
			this.Back.Click += new System.EventHandler(this.Back_Click);
			// 
			// lvEvents
			// 
			this.lvEvents.HideSelection = false;
			this.lvEvents.Location = new System.Drawing.Point(1, 84);
			this.lvEvents.Name = "lvEvents";
			this.lvEvents.Size = new System.Drawing.Size(517, 172);
			this.lvEvents.TabIndex = 107;
			this.lvEvents.UseCompatibleStateImageBehavior = false;
			this.lvEvents.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvEvents_ColumnClick);
			this.lvEvents.SelectedIndexChanged += new System.EventHandler(this.lvEvents_SelectedIndexChanged);
			// 
			// dtpSearchDate
			// 
			this.dtpSearchDate.Location = new System.Drawing.Point(142, 59);
			this.dtpSearchDate.Name = "dtpSearchDate";
			this.dtpSearchDate.Size = new System.Drawing.Size(258, 20);
			this.dtpSearchDate.TabIndex = 106;
			this.dtpSearchDate.ValueChanged += new System.EventHandler(this.dtpSearchDate_ValueChanged);
			// 
			// txtSearchCategory
			// 
			this.txtSearchCategory.Location = new System.Drawing.Point(22, 23);
			this.txtSearchCategory.Name = "txtSearchCategory";
			this.txtSearchCategory.Size = new System.Drawing.Size(298, 20);
			this.txtSearchCategory.TabIndex = 105;
			this.txtSearchCategory.TextChanged += new System.EventHandler(this.txtSearchCategory_TextChanged);
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.Lime;
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.Location = new System.Drawing.Point(326, 10);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(97, 43);
			this.btnSearch.TabIndex = 104;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.Red;
			this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(421, 9);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(97, 43);
			this.btnClear.TabIndex = 109;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// chkEnableDateFilter
			// 
			this.chkEnableDateFilter.AutoSize = true;
			this.chkEnableDateFilter.Location = new System.Drawing.Point(22, 61);
			this.chkEnableDateFilter.Name = "chkEnableDateFilter";
			this.chkEnableDateFilter.Size = new System.Drawing.Size(114, 17);
			this.chkEnableDateFilter.TabIndex = 110;
			this.chkEnableDateFilter.Text = "Select to filter date";
			this.chkEnableDateFilter.UseVisualStyleBackColor = true;
			this.chkEnableDateFilter.CheckedChanged += new System.EventHandler(this.chkEnableDateFilter_CheckedChanged);
			// 
			// LocalEvents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSlateGray;
			this.ClientSize = new System.Drawing.Size(518, 290);
			this.Controls.Add(this.chkEnableDateFilter);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.Back);
			this.Controls.Add(this.lvEvents);
			this.Controls.Add(this.dtpSearchDate);
			this.Controls.Add(this.txtSearchCategory);
			this.Controls.Add(this.btnSearch);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "LocalEvents";
			this.Text = "Municipal Services";
			this.Load += new System.EventHandler(this.LocalEvents_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Back;
		private System.Windows.Forms.ListView lvEvents;
		private System.Windows.Forms.DateTimePicker dtpSearchDate;
		private System.Windows.Forms.TextBox txtSearchCategory;
		private System.Windows.Forms.Button btnSearch;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.CheckBox chkEnableDateFilter;
	}
}