using System;

namespace NetCore.Models.Business.Order
{
    public class OrderStatistic
    {
        public Guid id { get; set; }
        public Guid customer_id { get; set; }

        public int num_order { get; set; }
        public int num_order_success { get; set; }
        public int num_order_abandoned { get; set; }
    }
}