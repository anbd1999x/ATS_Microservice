using System;

namespace NetCore.Models.Business.Order
{
    public class Menu
    {
        public Guid id { get; set; }
        public Guid? partner_id { get; set; }
        public int? partner_branch_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string detail_info { get; set; }
    }
}