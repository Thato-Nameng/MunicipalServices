using Municipal_Services.LocalEventsFile;
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
	public partial class EditStatus : Form
	{
		public string NewStatus { get; private set; }

		public EditStatus()
		{
			InitializeComponent();


		}

		public EditStatus(ServiceRequest request)
		{
			InitializeComponent();

			lblRequestId.Text = $"Request ID: {request.RequestId}";
			lblDescription.Text = $"Description: {request.Description}";
			cmbStatus.Items.AddRange(new string[] { "Pending", "In Progress", "Completed" });
			cmbStatus.SelectedItem = request.Status;
		}

		private void EditStatus_Load(object sender, EventArgs e)
		{

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (cmbStatus.SelectedIndex >= 0)
			{
				NewStatus = cmbStatus.SelectedItem.ToString();
				DialogResult = DialogResult.OK;
				btnBlck_Click(sender, e); 
			}
			else
			{
				MessageBox.Show("Please select a status before saving.");
			}
		}

		private void btnBlck_Click(object sender, EventArgs e)
		{
			ServiceStatus serviceStatus  = new ServiceStatus();
			this.Hide();
			serviceStatus.Show();
		}
	}
}
