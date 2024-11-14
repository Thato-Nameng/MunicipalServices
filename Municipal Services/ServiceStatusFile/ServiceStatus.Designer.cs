namespace Municipal_Services.ServiceStatusFile
{
	partial class ServiceStatus
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
			this.pnlGraphDisplay = new System.Windows.Forms.Panel();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnAddRequest = new System.Windows.Forms.Button();
			this.lblSearchResult = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtSearchRequestId = new System.Windows.Forms.TextBox();
			this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
			this.dgvServiceRequests = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvServiceRequests)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlGraphDisplay
			// 
			this.pnlGraphDisplay.Location = new System.Drawing.Point(12, 278);
			this.pnlGraphDisplay.Name = "pnlGraphDisplay";
			this.pnlGraphDisplay.Size = new System.Drawing.Size(563, 165);
			this.pnlGraphDisplay.TabIndex = 23;
			this.pnlGraphDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGraphDisplay_Paint);
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(316, 63);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(121, 39);
			this.btnClear.TabIndex = 20;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnAddRequest
			// 
			this.btnAddRequest.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddRequest.Location = new System.Drawing.Point(443, 25);
			this.btnAddRequest.Name = "btnAddRequest";
			this.btnAddRequest.Size = new System.Drawing.Size(132, 64);
			this.btnAddRequest.TabIndex = 19;
			this.btnAddRequest.Text = "Add Request";
			this.btnAddRequest.UseVisualStyleBackColor = true;
			this.btnAddRequest.Click += new System.EventHandler(this.btnAddRequest_Click);
			// 
			// lblSearchResult
			// 
			this.lblSearchResult.AutoSize = true;
			this.lblSearchResult.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearchResult.Location = new System.Drawing.Point(651, 69);
			this.lblSearchResult.Name = "lblSearchResult";
			this.lblSearchResult.Size = new System.Drawing.Size(211, 26);
			this.lblSearchResult.TabIndex = 18;
			this.lblSearchResult.Text = "Display search results";
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.Location = new System.Drawing.Point(316, 18);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(121, 39);
			this.btnSearch.TabIndex = 17;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtSearchRequestId
			// 
			this.txtSearchRequestId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearchRequestId.Location = new System.Drawing.Point(12, 18);
			this.txtSearchRequestId.Multiline = true;
			this.txtSearchRequestId.Name = "txtSearchRequestId";
			this.txtSearchRequestId.Size = new System.Drawing.Size(283, 27);
			this.txtSearchRequestId.TabIndex = 16;
			// 
			// cmbStatusFilter
			// 
			this.cmbStatusFilter.FormattingEnabled = true;
			this.cmbStatusFilter.Location = new System.Drawing.Point(12, 51);
			this.cmbStatusFilter.Name = "cmbStatusFilter";
			this.cmbStatusFilter.Size = new System.Drawing.Size(169, 21);
			this.cmbStatusFilter.TabIndex = 15;
			// 
			// dgvServiceRequests
			// 
			this.dgvServiceRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvServiceRequests.Location = new System.Drawing.Point(12, 108);
			this.dgvServiceRequests.Name = "dgvServiceRequests";
			this.dgvServiceRequests.Size = new System.Drawing.Size(563, 150);
			this.dgvServiceRequests.TabIndex = 14;
			this.dgvServiceRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceRequests_CellContentClick);
			// 
			// ServiceStatus
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSlateGray;
			this.ClientSize = new System.Drawing.Size(861, 526);
			this.Controls.Add(this.pnlGraphDisplay);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnAddRequest);
			this.Controls.Add(this.lblSearchResult);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtSearchRequestId);
			this.Controls.Add(this.cmbStatusFilter);
			this.Controls.Add(this.dgvServiceRequests);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "ServiceStatus";
			this.Text = "ServiceStatus";
			this.Load += new System.EventHandler(this.ServiceStatus_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvServiceRequests)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlGraphDisplay;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnAddRequest;
		private System.Windows.Forms.Label lblSearchResult;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtSearchRequestId;
		private System.Windows.Forms.ComboBox cmbStatusFilter;
		private System.Windows.Forms.DataGridView dgvServiceRequests;
	}
}