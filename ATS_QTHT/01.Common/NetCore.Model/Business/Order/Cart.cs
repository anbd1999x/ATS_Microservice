using System;
using NetCore.Core.Enums;

namespace NetCore.Models.Business.Order
{
    public class Cart
    {
        public Guid id { get; set; }
        public Guid? customer_id { get; set; }
        public Guid? partner_table_id { get; set; }
        public string? name { get; set; }
        public string? phone { get; set; }
        public decimal? total_gross_amount { get; set; }
        public decimal? total_net_amount { get; set; }
        public decimal? subtotal_gross_amount { get; set; }
        public decimal? subtotal_net_amount { get; set; }
        public decimal? extra_charge_amount { get; set; }
        public string? note { get; set; }
        public bool? is_ordered { get; set; }
        public DateTime? date_created { get; set; }
        public string? created_by { get; set; }
        public Enums.CartStatus status { get; set; }
    }
}