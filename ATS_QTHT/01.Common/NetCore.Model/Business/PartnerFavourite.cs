using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class PartnerFavourite
    {
        public Guid? customer_id { get; set; }
        public Guid? partner_id { get; set; }
        public int? partner_branch_id { get; set; }
    }
}
