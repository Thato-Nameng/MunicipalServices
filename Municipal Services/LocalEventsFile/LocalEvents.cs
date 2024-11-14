using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Municipal_Services.LocalEventsFile
{
	public partial class LocalEvents : Form
	{
		private SortedDictionary<DateTime, List<string>> eventsByDate;
		private Dictionary<string, List<string>> eventsByCategory;
		private Queue<string> announcements;
		private HashSet<string> uniqueCategories;
		private ListViewColumnSorter lvwColumnSorter;
		public LocalEvents()
		{
			InitializeComponent();
			InitializeDataStructures();
			SetupListView();
			DisplayAllEventsAndAnnouncements();

			dtpSearchDate.Format = DateTimePickerFormat.Custom;
			dtpSearchDate.CustomFormat = "dd/MM/yyyy";

			lvwColumnSorter = new ListViewColumnSorter();
			lvEvents.ListViewItemSorter = lvwColumnSorter;
		}
		
		private void LocalEvents_Load(object sender, EventArgs e)
		{
			
			try
			{
				DisplayAllEventsAndAnnouncements();
				dtpSearchDate.Hide();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred while loading the Local Events form. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void InitializeDataStructures()
		{
			eventsByDate = new SortedDictionary<DateTime, List<string>>();
			eventsByCategory = new Dictionary<string, List<string>>();
			uniqueCategories = new HashSet<string>();
			announcements = new Queue<string>();

			AddEvent(new DateTime(2024, 11, 25), "Public Health Services", "Free vaccination clinics");
			AddEvent(new DateTime(2024, 11, 25), "Public Health Services", "Blood donation");
			AddEvent(new DateTime(2024, 11, 25), "Public Health Services", "Workshops and seminars");
			AddEvent(new DateTime(2024, 11, 25), "Transportation and Infrastructure", "Construction updates");
			AddEvent(new DateTime(2024, 11, 25), "Transportation and Infrastructure", "New transportation paths");
			AddEvent(new DateTime(2024, 11, 25), "Transportation and Infrastructure", "Public meetings on proposed infrastructure projects");
			AddEvent(new DateTime(2024, 11, 10), "Electricity", "Planned electricity outages for maintenance");
		}

		private void SetupListView()
		{
			lvEvents.View = View.Details;
			lvEvents.FullRowSelect = true;

			lvEvents.Columns.Add("Event/Announcement", -2, HorizontalAlignment.Left);
			lvEvents.Columns.Add("Public services", -2, HorizontalAlignment.Left);
			lvEvents.Columns.Add("Date", -2, HorizontalAlignment.Left);

			lvEvents.ColumnClick += new ColumnClickEventHandler(lvEvents_ColumnClick);
		}

		private void DisplayAllEventsAndAnnouncements()
		{
			try
			{
				lvEvents.Items.Clear();

				foreach (var announcement in announcements)
				{
					var item = new ListViewItem(announcement);
					item.SubItems.Add("");
					item.SubItems.Add("");
					lvEvents.Items.Add(item);
				}

				foreach (var eventGroup in eventsByDate)
				{
					foreach (var eventItem in eventGroup.Value)
					{
						var eventCategory = eventsByCategory.FirstOrDefault(c => c.Value.Contains(eventItem)).Key;
						var item = new ListViewItem(eventItem);
						item.SubItems.Add(eventCategory);
						item.SubItems.Add(eventGroup.Key.ToShortDateString());
						lvEvents.Items.Add(item);
					}
				}

				lvEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred while displaying events and announcements. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				string category = txtSearchCategory.Text.Trim().ToLower();
				DateTime? selectedDate = chkEnableDateFilter.Checked ? dtpSearchDate.Value.Date : (DateTime?)null;

				lvEvents.Items.Clear();
				bool hasResults = false;

				foreach (var eventGroup in eventsByDate)
				{
					// Filter by date only if the checkbox is checked
					if (!selectedDate.HasValue || selectedDate.Value == eventGroup.Key)
					{
						foreach (var eventItem in eventGroup.Value)
						{
							string eventCategory = eventsByCategory.FirstOrDefault(c => c.Value.Contains(eventItem)).Key;

							if (string.IsNullOrEmpty(category) || eventCategory.ToLower().Contains(category))
							{
								var item = new ListViewItem(eventItem);
								item.SubItems.Add(eventCategory);
								item.SubItems.Add(eventGroup.Key.ToShortDateString());
								lvEvents.Items.Add(item);
								hasResults = true;
							}
						}
					}
				}

				if (!hasResults)
				{
					MessageBox.Show("No events found matching your search criteria.", "Search Results",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				lvEvents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred while performing the search. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void AddEvent(DateTime date, string eventCategory, string eventName)
		{
			if (!eventsByDate.ContainsKey(date.Date))
			{
				eventsByDate[date.Date] = new List<string>();
			}
			eventsByDate[date.Date].Add(eventName);

			if (!eventsByCategory.ContainsKey(eventCategory))
			{
				eventsByCategory[eventCategory] = new List<string>();
			}
			eventsByCategory[eventCategory].Add(eventName);  // Associate with the category
		}

		private void AddAnnouncement(string announcement)
		{
			announcements.Enqueue(announcement);
		}


		private void txtSearchCategory_TextChanged(object sender, EventArgs e)
		{

		}

		private void dtpSearchDate_ValueChanged(object sender, EventArgs e)
		{

		}

		private void lvEvents_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lvEvents.SelectedItems.Count > 0)
			{
				string selectedEvent = lvEvents.SelectedItems[0].Text;
				MessageBox.Show($"You selected: {selectedEvent}", "Event Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void lvEvents_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			try
			{
				if (e.Column == lvwColumnSorter.SortColumn)
				{
					lvwColumnSorter.Order = lvwColumnSorter.Order == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
				}
				else
				{
					lvwColumnSorter.SortColumn = e.Column;
					lvwColumnSorter.Order = SortOrder.Ascending;
				}

				lvEvents.Sort();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred while sorting the list view. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Back_Click(object sender, EventArgs e)
		{
			this.Hide(); 
			MainMenu mainForm = new MainMenu();
			mainForm.Show(); 
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtSearchCategory.Text = string.Empty;
			chkEnableDateFilter.Checked = false; 
			dtpSearchDate.Value = DateTime.Now; 
			DisplayAllEventsAndAnnouncements();
		}

		private void chkEnableDateFilter_CheckedChanged(object sender, EventArgs e)
		{
			dtpSearchDate.Visible = chkEnableDateFilter.Checked;
		}
	}
	
}
