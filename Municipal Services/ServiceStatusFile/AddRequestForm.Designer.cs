namespace Municipal_Services.ServiceStatusFile
{
	partial class AddRequestForm
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
			this.dateTimePickerSubmitted = new System.Windows.Forms.DateTimePicker();
			this.cmbStatus = new System.Windows.Forms.ComboBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// dateTimePickerSubmitted
			// 
			this.dateTimePickerSubmitted.Location = new System.Drawing.Point(451, 194);
			this.dateTimePickerSubmitted.Name = "dateTimePickerSubmitted";
			this.dateTimePickerSubmitted.Size = new System.Drawing.Size(200, 20);
			this.dateTimePickerSubmitted.TabIndex = 16;
			// 
			// cmbStatus
			// 
			this.cmbStatus.FormattingEnabled = true;
			this.cmbStatus.Location = new System.Drawing.Point(150, 233);
			this.cmbStatus.Name = "cmbStatus";
			this.cmbStatus.Size = new System.Drawing.Size(203, 21);
			this.cmbStatus.TabIndex = 15;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(150, 197);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(203, 20);
			this.txtDescription.TabIndex = 14;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(488, 233);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 13;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// AddRequestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dateTimePickerSubmitted);
			this.Controls.Add(this.cmbStatus);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.btnSave);
			this.Name = "AddRequestForm";
			this.Text = "AddRequestForm";
			this.Load += new System.EventHandler(this.AddRequestForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePickerSubmitted;
		private System.Windows.Forms.ComboBox cmbStatus;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Button btnSave;
	}
}