using System;

namespace NetCore.Models.Business.Order
{
    public class ProductForOrder : MasterCommonModel
    {
        public Guid? id { get; set; }
        public string? code { get; set; }
        public string? name { get; set; }
        public decimal? base_price { get; set; }
        public decimal price_override { get; set; }
        public int? status { get; set; }
        public string? description { get; set; }
        public string? detail_info { get; set; }
        public string? avatar { get; set; }
        public string? avatar_small { get; set; }
        public Guid? partner_id { get; set; }
        public int partner_branch_id { get; set; }
        public Guid? product_group_id { get; set; }
        public Guid? catagory_product_id { get; set; }
    }
}