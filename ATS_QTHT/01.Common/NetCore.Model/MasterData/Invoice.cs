using System;
using NetCore.Extensions;

namespace NetCore.Models
{
    public class Invoice
    {
        public Guid id { get; set; }

        public decimal? total_gross_amount { get; set; }
        public decimal? total_net_amount { get; set; }
        public decimal? subtotal_gross_amount { get; set; }
        public decimal? subtotal_net_amount { get; set; }
        public decimal? cashback_amount { get; set; }
        public decimal? cashback_percent { get; set; }
        public Enums.InvoiceStatus status { get; set; }
        public Guid? partner_table_id { get; set; }
        public Guid? customer_id { get; set; }
    
        // Đổi độ dài tối đa cho name và created_by
        public string? name { get; set; } // có thể tăng độ dài tối đa, ví dụ: 50 ký tự
        public string? phone { get; set; }
        public string? note { get; set; }
        public DateTime date_created { get; set; }
    
        // Đổi độ dài tối đa cho created_by
        public string? created_by { get; set; } // có thể tăng độ dài tối đa, ví dụ: 50 ký tự
        public string invoice_code { get; set; }
    
        public decimal? discount_amount { get; set; }
        public decimal? extra_charge { get; set; }
        public Guid? invoice_total_id { get; set; }
    }
    public class InvoiceOrder : Invoice
    {
        public Guid? OrderID { get; set; }
    }
    
    
    public class InvoiceAppStore 
    {
        public string invoice_code { get; set; }
        public decimal TransAmount { get; set; }
    }
    
    public class InvoiceDetailDTO 
    {
        public Guid invoiceTotalId { get; set; }
    }
}