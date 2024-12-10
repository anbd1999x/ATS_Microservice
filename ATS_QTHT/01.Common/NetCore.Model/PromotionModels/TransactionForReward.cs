using System;

namespace NetCore.Models.PromotionModels
{
    public class TransactionForReward
    {
        public Guid id { get; set; }
        public Guid promotion_user_id { get; set; }
        public Guid accumulate_point_order_id { get; set; }
    }
}