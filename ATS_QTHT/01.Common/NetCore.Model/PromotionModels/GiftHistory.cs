using NetCore.Core.Enums;
using System;

namespace NetCore.Models.PromotionModels
{
    public class GiftHistory
    {
        public Guid id { get; set; }
        public Guid promotion_id { get; set; }
        public Guid condition_id { get; set; }
        public Enums.GiftRecipient gift_recipient { get; set; }
        public Guid user_id { get; set; }
        public Guid gift_id { get; set; }
        public Guid? accumulate_point_id { get; set; }
        public DateTime created_at { get; set; }

        public Promotion Promotion { get; set; } = null!;
        public Condition Condition { get; set; } = null!;
        public Gift Gift { get; set; } = null!;
    }
}
