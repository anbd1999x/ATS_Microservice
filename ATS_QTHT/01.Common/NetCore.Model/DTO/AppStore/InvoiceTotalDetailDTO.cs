using System;
using System.Collections.Generic;

namespace NetCore.Models.DTO.AppStore
{
    public class InvoiceTotalDetailDTO
    {
        public Guid? id { get; set; }
        public string table_name { get; set; }
        public string invoice_code { get; set; }
        public DateTime created_date { get; set; } 
        public List<ProductDetailDTO> paid_products { get; set; }
        public List<ProductDetailDTO> unpaid_products { get; set; }
        public decimal? total_gross_amount { get; set; }
        public decimal? discount_amount { get; set; }
        public decimal? extra_charge { get; set; }
        public string note_discount { get; set; }
        public string note_extra_charge { get; set; }
        public decimal? sub_total_gross_amount_paid { get; set; }
        public decimal? sub_total_gross_amount_unpaid { get; set; }
        public decimal? total_gross_amount_paid { get; set; }
        public decimal? total_gross_amount_unpaid { get; set; }
        public int? floor { get; set; }
    }

    public class ProductDetailDTO
    {
        public Guid? id { get; set; }
        public string product_name { get; set; }
        public decimal quantity { get; set; }
        public decimal base_price { get; set; }
        public decimal override_price { get; set; }
        public decimal total_amount { get; set; }
        public bool is_paid { get; set; }
        public string avatar { get; set; }
    }
}