using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class ScheduleJobs
    {
        public Guid? id { get; set; }
        public string name { get; set; }
        public string types { get; set; }
        public DateTime? date_created { get; set; }
    }
}
