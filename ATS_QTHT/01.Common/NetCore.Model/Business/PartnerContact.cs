using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class PartnerContact : MasterCommonModel
    {
        public int? id { get; set; }
        public int? bk_id { get; set; }

        public Guid? partner_id { get; set; }
        public int type { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

    }
}
