using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Municipal_Services.ReportIssuesFile;
using Municipal_Services.LocalEventsFile;
using Municipal_Services.ServiceStatusFile;
namespace Municipal_Services
{
	public partial class MainMenu : Form
	{

		public MainMenu()
		{
			InitializeComponent();

			CreateReportsDirectory();

		}

		private void btnReport_Click(object sender, EventArgs e)
		{
			try
			{
				ReportIssues reportForm = new ReportIssues();
				this.Hide();
				reportForm.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred while opening the Report Issues form. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void MainMenu_Load(object sender, EventArgs e)
		{

		}

		private void CreateReportsDirectory()
		{
			try
			{
				string reportsDirectory = Path.Combine(Application.StartupPath, "Reports");
				if (!Directory.Exists(reportsDirectory))
				{
					Directory.CreateDirectory(reportsDirectory);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Failed to create the reports directory. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void btnEvents_Click(object sender, EventArgs e)
		{
			try
			{
				LocalEvents localEvents = new LocalEvents();
				this.Hide();
				localEvents.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred while opening the Report Issues form. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnService_Click(object sender, EventArgs e)
		{
			try
			{
				ServiceStatus serviceStatus = new ServiceStatus();
				this.Hide();
				serviceStatus.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred while opening the Report Issues form. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
