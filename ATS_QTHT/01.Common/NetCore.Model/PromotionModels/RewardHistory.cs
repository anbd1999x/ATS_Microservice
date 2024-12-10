using System;

namespace NetCore.Models.PromotionModels
{
    public class RewardHistory
    {
        public Guid id { get; set; }
        public Guid promotion_id { get; set; }
        public Guid user_id { get; set; }
    }
}