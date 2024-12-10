using System;

namespace NetCore.Models.PromotionModels
{
    public class ConditionGift
    {
        public Guid id { get; set; }
        public Guid condition_id { get; set; }
        public Guid gift_id { get; set; }
        public string? description { get; set; }
    }
}