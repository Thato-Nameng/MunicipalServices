using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipal_Services.ServiceStatusFile
{
	public class ServiceStatusGraph
	{

		private Dictionary<string, List<string>> adjacencyList = new Dictionary<string, List<string>>();

		public void AddTransition(string fromStatus, string toStatus)
		{
			if (!adjacencyList.ContainsKey(fromStatus))
				adjacencyList[fromStatus] = new List<string>();

			if (!adjacencyList[fromStatus].Contains(toStatus))
				adjacencyList[fromStatus].Add(toStatus);
		}


		public List<string> DepthFirstTraversal(string startStatus)
		{
			var visited = new HashSet<string>();
			var stack = new Stack<string>();
			var result = new List<string>();

			stack.Push(startStatus);

			while (stack.Count > 0)
			{
				var current = stack.Pop();

				if (!visited.Contains(current))
				{
					visited.Add(current);
					result.Add(current);

					if (adjacencyList.ContainsKey(current))
					{
						foreach (var neighbor in adjacencyList[current])
						{
							stack.Push(neighbor);
						}
					}
				}
			}

			return result;
		}

		public List<string> GetNodes()
		{
			return adjacencyList.Keys.ToList();
		}

		public List<(string, string)> GetEdges()
		{
			var edges = new List<(string, string)>();
			foreach (var from in adjacencyList.Keys)
			{
				foreach (var to in adjacencyList[from])
				{
					edges.Add((from, to));
				}
			}
			return edges;
		}
		



	}
}

