using System;
using NetCore.Core.Enums;

namespace NetCore.Models.Business.Order
{
    public class PartnerTable
    {
        public Guid id { get; set; }
        public Guid partner_id { get; set; }
        public int? partner_branch_id { get; set; }
        public string? name { get; set; }
        public int floor { get; set; }
        public int? capacity { get; set; }
        public string? area { get; set; }
        public Enums.TableStatus? status { get; set; }
        public DateTime? date_created { get; set; }
        public DateTime? date_updated { get; set; }
        public string? user_created { get; set; }
        public string? user_updated { get; set; }

        public string? qr_code { get; set; }
        public string? current_customer { get; set; }

    }
}