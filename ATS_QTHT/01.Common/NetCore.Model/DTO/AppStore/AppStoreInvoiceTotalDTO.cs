using System;
using System.Collections.Generic;
using NetCore.Core.Enums;

namespace NetCore.Models.DTO.AppStore
{
    public class AppStoreInvoiceTotalDTO
    {
        public Guid id;
        public string tableName;
        public DateTime createdDate;
        public decimal? totalGrossAmount;
        public decimal? totalNetAmount;
        public decimal? subTotalGrossAmount;
        public decimal? subTotalNetAmount;
        public decimal? discount;
        public decimal? cashbackAmount;
        public decimal? extraCharge;
        public Enums.InvoiceStatus status;
        public string code;
        public Guid partnerTableId;
        public List<AppStoreInvoiceDTO> invoices { get; set; }
    }
    
    public class AppStoreInvoiceDTO
    {
        public Guid id;
        public Guid invoiceTotalId;
        public decimal? total_gross_amount;
        public decimal? total_net_amount;
        public decimal? subtotal_gross_amount;
        public decimal? subtotal_net_amount;
        public decimal? cashback_amount;
        public Enums.InvoiceStatus status;
        public DateTime date_created;
        public decimal? discount_amount;
        public List<AppStoreProductDTO> products;
    }
    
    public class AppStoreProductDTO
    {
        public Guid id;
        public string name;
        public string avatar;
        public decimal quantity;
        public decimal basePrice;
        public decimal priceOverride;
        public Enums.InvoiceStatus Status;
    }
    
    
}