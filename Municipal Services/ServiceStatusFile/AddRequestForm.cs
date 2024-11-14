using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Municipal_Services.ServiceStatusFile
{
	public partial class AddRequestForm : Form
	{
		public ServiceRequest NewRequest { get; private set; }

		public AddRequestForm()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(txtDescription.Text) && cmbStatus.SelectedIndex >= 0)
			{
				int requestId = new Random().Next(1000, 9999); // Generate a unique ID
				string description = txtDescription.Text;
				string status = cmbStatus.SelectedItem.ToString();
				DateTime dateSubmitted = dateTimePickerSubmitted.Value;

				NewRequest = new ServiceRequest(requestId, description, status, dateSubmitted);
				DialogResult = DialogResult.OK;
				Close();
			}
			else
			{
				MessageBox.Show("Please fill in all fields.");
			}
		}

		private void AddRequestForm_Load(object sender, EventArgs e)
		{
			cmbStatus.Items.AddRange(new string[] { "Pending", "In Progress", "Completed" });
			cmbStatus.SelectedIndex = 0; // Default to Pending

		}
	}
}
