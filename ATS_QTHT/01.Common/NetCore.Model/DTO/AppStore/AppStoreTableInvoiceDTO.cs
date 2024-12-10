using System;
using System.Collections.Generic;
using NetCore.Core.Enums;

namespace NetCore.Models.DTO.AppStore
{
    public class AppStoreTableInvoiceDTO
    {
        public Guid id { get; set; }
        public string invoiceCode { get; set; }
        public string tableName { get; set; }
        public decimal totalGrossAmount { get; set; }
        public decimal totalNetAmount { get; set; }
        public decimal subNetAmount { get; set; }
        public decimal subGrossAmount { get; set; }
        public int floor { get; set; }
    }
}