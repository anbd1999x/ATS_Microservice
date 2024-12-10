using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class CmsNotification : MasterCommonModel
    {
        public Guid id { get; set; }
        public Guid? user_id { get; set; }
        public string device_id { get; set; }
        public string type { get; set; } = "WALLET";
        public string title { get; set; }
        public string content { get; set; }
        public string description { get; set; }
        public string user_type { get; set; }
        public string avatar { get; set; }
    }
}
