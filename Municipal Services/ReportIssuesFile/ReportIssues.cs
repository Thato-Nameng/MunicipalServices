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

namespace Municipal_Services.ReportIssuesFile
{
	public partial class ReportIssues : Form
	{
		List<List<string>> Report = new List<List<string>>();
		private string attachedFilePath = string.Empty;

		public ReportIssues()
		{
			InitializeComponent();

			progressBar1.Minimum = 0;
			progressBar1.Maximum = 6;
			progressBar1.Value = 0;
			UpdateProgressBar();
		}

		private void ReportIssues_Load(object sender, EventArgs e)
		{
			Clear();
			lbxReport.Items.Add("Sanitation");
			lbxReport.Items.Add("Roads");
			lbxReport.Items.Add("Utilities");
			lbxReport.Items.Add("Fire");
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			if (ValidateFields())
			{
				ReportArray();
			}
			else
			{
				MessageBox.Show("Please complete all required fields before saving.");
			}
		}

		private void ReportArray()
		{
			List<string> newReport = new List<string>
			 {
				 txtName.Text,
				 txtSurname.Text,
				 txtLocation.Text,
				 lbxReport.Text,
				 rtxtDescription.Text,
				 attachedFilePath
			 };
			Report.Add(newReport);
			MessageBox.Show("Report saved successfully!");
			Clear();

		}

		private void Clear()
		{
			txtName.Clear();
			txtSurname.Clear();
			txtLocation.Clear();
			lbxReport.ClearSelected();
			rtxtDescription.Clear();
			lblAttach.Text = "No file attached";
			attachedFilePath = string.Empty;
			UpdateProgressBar();

		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void UpdateProgressBar()
		{
			int filledFields = 0;

			if (!string.IsNullOrWhiteSpace(txtName.Text))
			{
				filledFields++;
			}
			if (!string.IsNullOrWhiteSpace(txtSurname.Text))
			{
				filledFields++;
			}
			if (!string.IsNullOrWhiteSpace(txtLocation.Text))
			{
				filledFields++;
			}
			if (lbxReport.SelectedItem != null)
			{
				filledFields++;
			}
			if (!string.IsNullOrWhiteSpace(rtxtDescription.Text))
			{
				filledFields++;
			}
			if (!string.IsNullOrWhiteSpace(attachedFilePath))
			{
				filledFields++;
			}

			progressBar1.Value = filledFields;
			btnSubmit.Enabled = filledFields == progressBar1.Maximum;


			if (filledFields == 0)
			{
				lblEngagement.Text = "Let’s start! Fill in the required fields.";
			}
			else if (filledFields < 3)
			{
				lblEngagement.Text = "You're getting there, keep going!";
			}
			else if (filledFields < 6)
			{
				lblEngagement.Text = "Almost done, just a few more steps!";
			}
			else
			{
				lblEngagement.Text = "All fields completed. Ready to submit!";
			}

		}

		private bool ValidateFields()
		{
			return !string.IsNullOrWhiteSpace(txtName.Text) &&
				   !string.IsNullOrWhiteSpace(txtSurname.Text) &&
				   !string.IsNullOrWhiteSpace(txtLocation.Text) &&
				   lbxReport.SelectedItem != null &&
				   !string.IsNullOrWhiteSpace(rtxtDescription.Text) &&
				   !string.IsNullOrWhiteSpace(attachedFilePath);
		}

		private void txtName_TextChanged(object sender, EventArgs e)
		{
			UpdateProgressBar();
		}

		private void txtSurname_TextChanged(object sender, EventArgs e)
		{
			UpdateProgressBar();
		}

		private void txtLocation_TextChanged(object sender, EventArgs e)
		{
			UpdateProgressBar();
		}

		private void lbxReport_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateProgressBar();
		}

		private void rtxtDescription_TextChanged(object sender, EventArgs e)
		{
			UpdateProgressBar();
		}

		private void Back_Click(object sender, EventArgs e)
		{
			MainMenu mainMenu = new MainMenu();
			this.Hide();
			mainMenu.Show();
		}

		private void btnDisplay_Click(object sender, EventArgs e)
		{
			DisplayReports displayReport = new DisplayReports();
			displayReport.LoadReports(Report);
			this.Hide();
			displayReport.Show();
		}

		private void btnMedia_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.InitialDirectory = "c:\\";
				openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
				openFileDialog.FilterIndex = 2;
				openFileDialog.RestoreDirectory = true;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					attachedFilePath = openFileDialog.FileName;

					lblAttach.Text = $"File attached: {Path.GetFileName(attachedFilePath)}";

					using (var fileStream = openFileDialog.OpenFile())
					using (StreamReader reader = new StreamReader(fileStream))
					{
						string fileContent = reader.ReadToEnd();
						UpdateProgressBar();
					}

				}
			}
		}
	}
}
