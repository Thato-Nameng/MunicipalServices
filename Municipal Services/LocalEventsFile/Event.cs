using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipal_Services.LocalEventsFile
{
	public class Event
	{
		public string Name { get; set; }
		public string Category { get; set; }
		public DateTime Date { get; set; }
		public string Announcement { get; set; }

		public Event(string name, string category, DateTime date, string announcement)
		{
			Name = name;
			Category = category;
			Date = date;
			Announcement = announcement;
		}
	}
}