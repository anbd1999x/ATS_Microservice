using System;

namespace NetCore.Models.Business.Order
{
    public class ProductCurrentVersion
    {
        public Guid id { get; set; }
        public Guid product_id { get; set; }
        public int version { get; set; }
    }
}