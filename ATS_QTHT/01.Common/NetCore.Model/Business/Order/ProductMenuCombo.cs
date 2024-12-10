using System;

namespace NetCore.Models.Business.Order
{
    public class ProductMenuCombo
    {
        public Guid id { get; set; }
        public string? name { get; set; }
        public string? code { get; set; }
        public string? avatar { get; set; }
        public string? avatar_small { get; set; }
        public string? description { get; set; }
        public string? short_description { get; set; }
        public Guid partner_id { get; set; }
        public int? partner_branch_id { get; set; }
        public Guid menu_id { get; set; }
    }
}