using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipal_Services.ServiceStatusFile
{
    public class ServiceRequest
    {
        public int RequestId { get; set; }
        public string Description { get; set; }
        public string Status { get; set; } 
        public DateTime DateSubmitted { get; set; }
        
		public ServiceRequest(int requestId, string description, string status, DateTime dateSubmitted)
        {
            RequestId = requestId;
            Description = description;
            Status = status;
            DateSubmitted = dateSubmitted;
        }
    }
}
