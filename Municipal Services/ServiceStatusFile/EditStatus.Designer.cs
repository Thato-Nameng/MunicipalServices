namespace Municipal_Services.ServiceStatusFile
{
	partial class EditStatus
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
			this.lblRequestId = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblDescription = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.cmbStatus = new System.Windows.Forms.ComboBox();
			this.btnBlck = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblRequestId
			// 
			this.lblRequestId.AutoSize = true;
			this.lblRequestId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRequestId.Location = new System.Drawing.Point(84, 9);
			this.lblRequestId.Name = "lblRequestId";
			this.lblRequestId.Size = new System.Drawing.Size(79, 29);
			this.lblRequestId.TabIndex = 0;
			this.lblRequestId.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(1037, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "label2";
			// 
			// lblDescription
			// 
			this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDescription.AutoSize = true;
			this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescription.Location = new System.Drawing.Point(85, 61);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(60, 24);
			this.lblDescription.TabIndex = 2;
			this.lblDescription.Text = "label3";
			this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnSave.BackColor = System.Drawing.Color.Firebrick;
			this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnSave.FlatAppearance.BorderSize = 2;
			this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
			this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSalmon;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.LightGray;
			this.btnSave.Location = new System.Drawing.Point(7, 154);
			this.btnSave.Name = "btnSave";
			this.btnSave.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnSave.Size = new System.Drawing.Size(179, 52);
			this.btnSave.TabIndex = 189;
			this.btnSave.Tag = "";
			this.btnSave.Text = "Submit";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// cmbStatus
			// 
			this.cmbStatus.FormattingEnabled = true;
			this.cmbStatus.Location = new System.Drawing.Point(7, 97);
			this.cmbStatus.Name = "cmbStatus";
			this.cmbStatus.Size = new System.Drawing.Size(374, 21);
			this.cmbStatus.TabIndex = 190;
			// 
			// btnBlck
			// 
			this.btnBlck.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnBlck.BackColor = System.Drawing.Color.Black;
			this.btnBlck.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnBlck.FlatAppearance.BorderSize = 2;
			this.btnBlck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
			this.btnBlck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSalmon;
			this.btnBlck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBlck.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBlck.ForeColor = System.Drawing.Color.LightGray;
			this.btnBlck.Location = new System.Drawing.Point(192, 154);
			this.btnBlck.Name = "btnBlck";
			this.btnBlck.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnBlck.Size = new System.Drawing.Size(198, 52);
			this.btnBlck.TabIndex = 191;
			this.btnBlck.Tag = "";
			this.btnBlck.Text = "Back";
			this.btnBlck.UseVisualStyleBackColor = false;
			this.btnBlck.Click += new System.EventHandler(this.btnBlck_Click);
			// 
			// EditStatus
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSlateGray;
			this.ClientSize = new System.Drawing.Size(393, 209);
			this.Controls.Add(this.btnBlck);
			this.Controls.Add(this.cmbStatus);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblRequestId);
			this.Name = "EditStatus";
			this.Text = "EditStatus";
			this.Load += new System.EventHandler(this.EditStatus_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblRequestId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ComboBox cmbStatus;
		private System.Windows.Forms.Button btnBlck;
	}
}