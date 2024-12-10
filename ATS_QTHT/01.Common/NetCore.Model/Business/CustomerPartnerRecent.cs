using System;

namespace NetCore.Models
{
    public class CustomerPartnerRecent
    {
        public Guid? id { get; set; }
        public Guid? user_id { get; set; }
        public Guid? partner_id { get; set; }
        public int? partner_branch_id { get; set; }
        public DateTime? created_at { get; set; }
    }
}