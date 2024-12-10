using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class Industry : MasterCommonModel
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public int group_id { get; set; }
        public string definition_desc { get; set; }
        public string service_desc { get; set; }
    }
}
