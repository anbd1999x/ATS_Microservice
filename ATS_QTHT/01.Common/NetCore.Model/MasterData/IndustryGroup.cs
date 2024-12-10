using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class IndustryGroup : MasterCommonModel
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
    }
}
