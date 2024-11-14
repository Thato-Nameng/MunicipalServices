namespace Municipal_Services
{
	partial class MainMenu
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
			this.btnService = new System.Windows.Forms.Button();
			this.btnEvents = new System.Windows.Forms.Button();
			this.btnReport = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnService
			// 
			this.btnService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnService.BackColor = System.Drawing.Color.DarkSlateGray;
			this.btnService.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnService.FlatAppearance.BorderSize = 8;
			this.btnService.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
			this.btnService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
			this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnService.Font = new System.Drawing.Font("MingLiU-ExtB", 26.25F);
			this.btnService.ForeColor = System.Drawing.Color.LightCoral;
			this.btnService.Location = new System.Drawing.Point(11, 228);
			this.btnService.Name = "btnService";
			this.btnService.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnService.Size = new System.Drawing.Size(476, 77);
			this.btnService.TabIndex = 19;
			this.btnService.Tag = "";
			this.btnService.Text = "Service Request Status";
			this.btnService.UseVisualStyleBackColor = false;
			this.btnService.Click += new System.EventHandler(this.btnService_Click);
			// 
			// btnEvents
			// 
			this.btnEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEvents.BackColor = System.Drawing.Color.DarkSlateGray;
			this.btnEvents.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnEvents.FlatAppearance.BorderSize = 8;
			this.btnEvents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
			this.btnEvents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
			this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEvents.Font = new System.Drawing.Font("MingLiU-ExtB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEvents.ForeColor = System.Drawing.Color.LightCoral;
			this.btnEvents.Location = new System.Drawing.Point(11, 145);
			this.btnEvents.Name = "btnEvents";
			this.btnEvents.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnEvents.Size = new System.Drawing.Size(476, 77);
			this.btnEvents.TabIndex = 18;
			this.btnEvents.Tag = "";
			this.btnEvents.Text = "Local Events";
			this.btnEvents.UseVisualStyleBackColor = false;
			this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
			// 
			// btnReport
			// 
			this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReport.BackColor = System.Drawing.Color.DarkSlateGray;
			this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnReport.FlatAppearance.BorderSize = 8;
			this.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
			this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
			this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnReport.Font = new System.Drawing.Font("MingLiU-ExtB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReport.ForeColor = System.Drawing.Color.LightCoral;
			this.btnReport.Location = new System.Drawing.Point(11, 62);
			this.btnReport.Name = "btnReport";
			this.btnReport.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnReport.Size = new System.Drawing.Size(476, 77);
			this.btnReport.TabIndex = 17;
			this.btnReport.Tag = "";
			this.btnReport.Text = "Report";
			this.btnReport.UseVisualStyleBackColor = false;
			this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(25, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(447, 27);
			this.label1.TabIndex = 16;
			this.label1.Text = "Welcome to Municipal Services";
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(499, 321);
			this.Controls.Add(this.btnService);
			this.Controls.Add(this.btnEvents);
			this.Controls.Add(this.btnReport);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "MainMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Municipal Services";
			this.Load += new System.EventHandler(this.MainMenu_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnService;
		private System.Windows.Forms.Button btnEvents;
		private System.Windows.Forms.Button btnReport;
		private System.Windows.Forms.Label label1;
	}
}

