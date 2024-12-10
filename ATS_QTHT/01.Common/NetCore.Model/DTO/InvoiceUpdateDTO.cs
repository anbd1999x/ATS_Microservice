using System;

namespace NetCore.Models.DTO
{
    public class InvoiceUpdateDTO
    {
        public Guid id { get; set; }
        public decimal? discount_amount { get; set; }
        public string? note { get; set; }
    }
}