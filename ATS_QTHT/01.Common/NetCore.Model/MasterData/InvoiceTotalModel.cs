using NetCore.Core.Enums;
using NetCore.Models.Business.Order;
using System;
using System.Collections.Generic;

namespace NetCore.Models.MasterData
{
    public class InvoiceTotalModel
    {
        public Guid id { get; set; }
        public Guid partner_table_id { get; set; }
        public decimal? total_gross_amount { get; set; }
        public decimal? total_net_amount { get; set; }
        public decimal? subtotal_gross_amount { get; set; }
        public decimal? subtotal_net_amount { get; set; }
        public decimal? cashback_amount { get; set; }
        public decimal? cashback_percent { get; set; }
        public decimal? amount_paid { get; set; }
        public decimal? discount { get; set; }
        public Enums.InvoiceStatus status { get; set; }
        public DateTime date_created { get; set; }
        public string invoice_code { get; set; }
        public decimal? extra_charge { get; set; }  
        public string? note { get; set; }
        public string? note_extra_charge { get; set; }
        public Guid? customer_id { get; set; }


    }
    /// <summary>
    /// DiscountInvoiceTotalAppStore
    /// </summary>
    public class DiscountInvoiceTotalAppStore
    {
        public Guid id { get; set; }
        public decimal? discount_amount { get; set; }
        public decimal? extra_charge { get; set; }
        public string note_discount { get; set; }
        public string note_extra_charge { get; set; }

    }
    /// <summary>
    /// CreateInvoice
    /// </summary>
    public class CreateInvoiceModel
    {
        public Order order { get; set; }
        public List<OrderItem> ordersItems { get; set; }
    }
}
