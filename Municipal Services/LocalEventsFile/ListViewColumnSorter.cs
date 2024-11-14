using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Municipal_Services.LocalEventsFile
{
	public class ListViewColumnSorter : IComparer
	{
		private int ColumnToSort;
		private SortOrder OrderOfSort;
		private CaseInsensitiveComparer ObjectCompare;

		public ListViewColumnSorter()
		{
			ColumnToSort = 0;
			OrderOfSort = SortOrder.None;
			ObjectCompare = new CaseInsensitiveComparer();
		}

		public int Compare(object x, object y)
		{
			int compareResult;
			ListViewItem listViewX, listViewY;

			listViewX = (ListViewItem)x;
			listViewY = (ListViewItem)y;

			if (ColumnToSort == 1)
			{
				DateTime dateX = DateTime.Parse(listViewX.SubItems[1].Text);
				DateTime dateY = DateTime.Parse(listViewY.SubItems[1].Text);
				compareResult = DateTime.Compare(dateX, dateY);
			}
			else
			{
				compareResult = ObjectCompare.Compare(listViewX.SubItems[ColumnToSort].Text, listViewY.SubItems[ColumnToSort].Text);
			}

			if (OrderOfSort == SortOrder.Ascending)
			{
				return compareResult;
			}
			else if (OrderOfSort == SortOrder.Descending)
			{
				return -compareResult;
			}
			else
			{
				return 0;
			}
		}

		public int SortColumn
		{
			get { return ColumnToSort; }
			set { ColumnToSort = value; }
		}

		public SortOrder Order
		{
			get { return OrderOfSort; }
			set { OrderOfSort = value; }
		}
		
	}
}
