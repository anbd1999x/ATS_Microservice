using System;

namespace NetCore.Models.DTO.WebStore
{
    public class WebStoreProductVersionDTO
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid PartnerId { get; set; }
        public int? PartnerBranchId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string Avatar { get; set; }
        public string DetailInfo { get; set; }
        public decimal PriceOverride { get; set; }
        public decimal BasePrice { get; set; }
        public int Status { get; set; }
        public int Version { get; set; }
    }
}