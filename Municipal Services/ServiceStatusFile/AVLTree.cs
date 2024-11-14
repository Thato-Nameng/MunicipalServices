using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipal_Services.ServiceStatusFile
{
	public class AVLNode
	{
		public ServiceRequest Data { get; set; }
		public AVLNode Left { get; set; }
		public AVLNode Right { get; set; }
		public int Height { get; set; }
		
		public AVLNode(ServiceRequest data)
		{
			Data = data;
			Height = 1;
		}
	}
	
	public class AVLTree
	{
		private AVLNode root;

		public void Insert(ServiceRequest data)
		{
			root = Insert(root, data);
		}

		private AVLNode Insert(AVLNode node, ServiceRequest data)
		{
			if (node == null)
				return new AVLNode(data);

			if (data.RequestId < node.Data.RequestId)
				node.Left = Insert(node.Left, data);
			else if (data.RequestId > node.Data.RequestId)
				node.Right = Insert(node.Right, data);
			else
				return node; // Duplicate IDs are not allowed

			node.Height = 1 + Math.Max(Height(node.Left), Height(node.Right));
			return Balance(node);
		}

		private AVLNode Balance(AVLNode node)
		{
			int balance = BalanceFactor(node);

			if (balance > 1 && BalanceFactor(node.Left) >= 0)
				return RotateRight(node);

			if (balance < -1 && BalanceFactor(node.Right) <= 0)
				return RotateLeft(node);

			if (balance > 1 && BalanceFactor(node.Left) < 0)
			{
				node.Left = RotateLeft(node.Left);
				return RotateRight(node);
			}

			if (balance < -1 && BalanceFactor(node.Right) > 0)
			{
				node.Right = RotateRight(node.Right);
				return RotateLeft(node);
			}

			return node;
		}

		private AVLNode RotateRight(AVLNode y)
		{
			AVLNode x = y.Left;
			AVLNode T2 = x.Right;

			x.Right = y;
			y.Left = T2;

			y.Height = Math.Max(Height(y.Left), Height(y.Right)) + 1;
			x.Height = Math.Max(Height(x.Left), Height(x.Right)) + 1;

			return x;
		}

		private AVLNode RotateLeft(AVLNode x)
		{
			AVLNode y = x.Right;
			AVLNode T2 = y.Left;

			y.Left = x;
			x.Right = T2;

			x.Height = Math.Max(Height(x.Left), Height(x.Right)) + 1;
			y.Height = Math.Max(Height(y.Left), Height(y.Right)) + 1;

			return y;
		}

		private int Height(AVLNode node)
		{
			return node?.Height ?? 0;
		}

		private int BalanceFactor(AVLNode node)
		{
			return node == null ? 0 : Height(node.Left) - Height(node.Right);
		}

		public List<ServiceRequest> InOrderTraversal()
		{
			var result = new List<ServiceRequest>();
			InOrderTraversal(root, result);
			return result;
		}

		private void InOrderTraversal(AVLNode node, List<ServiceRequest> result)
		{
			if (node == null) return;
			InOrderTraversal(node.Left, result);
			result.Add(node.Data);
			InOrderTraversal(node.Right, result);
		}
	}
}
