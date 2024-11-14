using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipal_Services.ServiceStatusFile
{
	public class MinHeap
	{
		private List<ServiceRequest> heap = new List<ServiceRequest>();
		
		public void Insert(ServiceRequest request)
		{
			heap.Add(request);
			int currentIndex = heap.Count - 1;

			while (currentIndex > 0)
			{
				int parentIndex = (currentIndex - 1) / 2;

				if (heap[currentIndex].DateSubmitted >= heap[parentIndex].DateSubmitted)
					break;

				Swap(currentIndex, parentIndex);
				currentIndex = parentIndex;
			}
		}

		public ServiceRequest ExtractMin()
		{
			if (heap.Count == 0) return null;

			ServiceRequest min = heap[0];
			heap[0] = heap[heap.Count - 1];
			heap.RemoveAt(heap.Count - 1);
			Heapify(0);
			return min;
		}

		private void Heapify(int index)
		{
			int smallest = index;
			int left = 2 * index + 1;
			int right = 2 * index + 2;

			if (left < heap.Count && heap[left].DateSubmitted < heap[smallest].DateSubmitted)
				smallest = left;

			if (right < heap.Count && heap[right].DateSubmitted < heap[smallest].DateSubmitted)
				smallest = right;

			if (smallest != index)
			{
				Swap(index, smallest);
				Heapify(smallest);
			}
		}

		private void Swap(int i, int j)
		{
			var temp = heap[i];
			heap[i] = heap[j];
			heap[j] = temp;
		}
	}
}
