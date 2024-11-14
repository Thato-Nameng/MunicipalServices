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
	public partial class ServiceStatus : Form
	{
		private AVLTree serviceRequestTree = new AVLTree();
		private MinHeap serviceRequestHeap = new MinHeap();
		private ServiceStatusGraph serviceStatusGraph = new ServiceStatusGraph();
		private bool isFormLoaded = false;

		public ServiceStatus()
		{
			InitializeComponent();
		}

		private void ServiceStatus_Load(object sender, EventArgs e)
		{
			ConfigureDataGridView();
			LoadInitialData();
			PopulateDataGridView(serviceRequestTree.InOrderTraversal());

			cmbStatusFilter.Items.AddRange(new string[] { "All", "Pending", "In Progress", "Completed" });
			cmbStatusFilter.SelectedIndex = 0;

			dgvServiceRequests.RowsAdded += (s, ev) => DisplayGraph();
			dgvServiceRequests.RowsRemoved += (s, ev) => DisplayGraph();

			isFormLoaded = true;
		}




		private void LoadInitialData()
		{
			var sampleRequests = new List<ServiceRequest>
	{
		new ServiceRequest(1, "Fix broken water pipe", "Pending", DateTime.Now.AddDays(-5)),
		new ServiceRequest(2, "Streetlight repair", "In Progress", DateTime.Now.AddDays(-3)),
		new ServiceRequest(3, "Garbage collection", "Completed", DateTime.Now.AddDays(-10))
	};

			foreach (var request in sampleRequests)
			{
				serviceRequestTree.Insert(request);
				serviceRequestHeap.Insert(request);
			}

			serviceStatusGraph.AddTransition("Pending", "In Progress");
			serviceStatusGraph.AddTransition("In Progress", "Completed");
		}


		private void ConfigureDataGridView()
		{
			dgvServiceRequests.Columns.Clear();

			dgvServiceRequests.Columns.Add("RequestId", "Request ID");
			dgvServiceRequests.Columns.Add("Description", "Description");
			dgvServiceRequests.Columns.Add("Status", "Status");
			dgvServiceRequests.Columns.Add("DateSubmitted", "Date Submitted");

			dgvServiceRequests.Columns["DateSubmitted"].DefaultCellStyle.Format = "yyyy-MM-dd";

			var editButton = new DataGridViewButtonColumn
			{
				Name = "EditStatus",
				HeaderText = "Actions",
				Text = "Edit Status",
				UseColumnTextForButtonValue = true
			};
			dgvServiceRequests.Columns.Add(editButton);
		}


		private void PopulateDataGridView(List<ServiceRequest> requests)
		{
			dgvServiceRequests.Rows.Clear();

			foreach (var request in requests)
			{
				dgvServiceRequests.Rows.Add(
					request.RequestId,
					request.Description,
					request.Status,
					request.DateSubmitted.ToString("yyyy-MM-dd")
				);
			}
		}

		private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!isFormLoaded) return;

			ApplyFilters();
		}

		private void ApplyFilters()
		{
			string searchTerm = txtSearchRequestId.Text.Trim().ToLower();
			string selectedStatus = cmbStatusFilter.SelectedItem.ToString();

			var allRequests = serviceRequestTree.InOrderTraversal();

			if (selectedStatus != "All")
			{
				allRequests = allRequests
					.Where(r => r.Status.Equals(selectedStatus, StringComparison.OrdinalIgnoreCase))
					.ToList();
			}

			if (!string.IsNullOrEmpty(searchTerm))
			{
				allRequests = allRequests
					.Where(r => r.Description.ToLower().Contains(searchTerm) || r.RequestId.ToString() == searchTerm)
					.ToList();
			}

			PopulateDataGridView(allRequests);
		}


		private void btnSearch_Click(object sender, EventArgs e)
		{
			ApplyFilters();

		}

		private void btnAddRequest_Click(object sender, EventArgs e)
		{
			AddRequestForm addRequestForm = new AddRequestForm();
			if (addRequestForm.ShowDialog() == DialogResult.OK)
			{
				var newRequest = addRequestForm.NewRequest;
				serviceRequestTree.Insert(newRequest);
				serviceRequestHeap.Insert(newRequest);
				PopulateDataGridView(serviceRequestTree.InOrderTraversal());
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtSearchRequestId.Text = string.Empty;
			cmbStatusFilter.SelectedIndex = 0; 

			dgvServiceRequests.Rows.Clear();

			pnlGraphDisplay.Controls.Clear();
			pnlGraphDisplay.Refresh();

		}

		private void btnGraphTraversal_Click(object sender, EventArgs e)
		{
			DisplayGraph();
			
		}


		private void DisplayGraph()
		{
			pnlGraphDisplay.Controls.Clear();
			pnlGraphDisplay.Refresh();

			Graphics graphics = pnlGraphDisplay.CreateGraphics();
			graphics.Clear(Color.White);

			var statuses = dgvServiceRequests.Rows
				.Cast<DataGridViewRow>()
				.Where(row => row.Cells["Status"].Value != null)
				.Select(row => row.Cells["Status"].Value.ToString())
				.Distinct()
				.ToList();

			var edges = serviceStatusGraph.GetEdges()
				.Where(edge => statuses.Contains(edge.Item1) && statuses.Contains(edge.Item2))
				.ToList();

			var nodePositions = new Dictionary<string, Point>();
			int x = 50, y = 50;
			foreach (var status in statuses)
			{
				var position = new Point(x, y);
				nodePositions[status] = position;
				DrawNode(graphics, position, status);

				x += 150; 
				if (x > pnlGraphDisplay.Width - 100)
				{
					x = 50;
					y += 100;
				}
			}

			foreach (var edge in edges)
			{
				if (nodePositions.ContainsKey(edge.Item1) && nodePositions.ContainsKey(edge.Item2))
				{
					DrawEdge(graphics, nodePositions[edge.Item1], nodePositions[edge.Item2]);
				}
			}
		}


		private void DrawNode(Graphics graphics, Point position, string text)
		{
			int diameter = 50;
			Rectangle rect = new Rectangle(position.X, position.Y, diameter, diameter);
			graphics.FillEllipse(Brushes.LightBlue, rect);
			graphics.DrawEllipse(Pens.Black, rect);

			var textSize = graphics.MeasureString(text, Font);
			graphics.DrawString(text, Font, Brushes.Black,
				position.X + (diameter - textSize.Width) / 2,
				position.Y + (diameter - textSize.Height) / 2);
		}


		private void DrawEdge(Graphics graphics, Point from, Point to)
		{
			Pen pen = new Pen(Color.Black, 2)
			{
				EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor 
			};

			graphics.DrawLine(pen, from.X + 25, from.Y + 25, to.X + 25, to.Y + 25); 
			pen.Dispose();
		}


		private void btnMST_Click(object sender, EventArgs e)
		{
			var mstEdges = GetMinimumSpanningTree();
			foreach (var edge in mstEdges)
			{
				Console.WriteLine($"{edge.Item1} -> {edge.Item2}");
			}

			DisplayGraph();
		}


		private void dgvServiceRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

			if (e.ColumnIndex == dgvServiceRequests.Columns["EditStatus"].Index && e.RowIndex >= 0)
			{
				var requestId = Convert.ToInt32(dgvServiceRequests.Rows[e.RowIndex].Cells["RequestId"].Value);
				var request = serviceRequestTree.InOrderTraversal().FirstOrDefault(r => r.RequestId == requestId);

				if (request != null)
				{
					this.Hide();
					using (var editForm = new EditStatus(request))
					{
						if (editForm.ShowDialog() == DialogResult.OK)
						{
							request.Status = editForm.NewStatus;
							PopulateDataGridView(serviceRequestTree.InOrderTraversal());
						}

					}
				}
			}
		}

		private List<(string, string)> GetMinimumSpanningTree()
		{
			var nodes = serviceStatusGraph.GetNodes();
			var edges = serviceStatusGraph.GetEdges();
			var mstEdges = new List<(string, string)>();

			var visited = new HashSet<string> { nodes.First() };
			while (visited.Count < nodes.Count)
			{
				var validEdges = edges.Where(e => visited.Contains(e.Item1) ^ visited.Contains(e.Item2)).ToList();
				var selectedEdge = validEdges.First();
				mstEdges.Add(selectedEdge);
				visited.Add(selectedEdge.Item1);
				visited.Add(selectedEdge.Item2);
			}

			return mstEdges;
		}
		private void pnlGraphDisplay_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
