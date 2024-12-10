using NetCore.Extensions;
using System;

namespace NetCore.Models.PromotionModels
{
    public class PromotionUser
    {
        public Guid id { get; set; }
        public Guid condition_id { get; set; }
        public Guid promotion_id { get; set; }
        public Guid? user_id { get; set; }
        public Enums.PromotionUserStatus status { get; set; }
        public int step { get; set; }
        public Guid? partner_id { get; set; }

        public Condition Condition { get; set; } = null!;
        public Promotion Promotion { get; set; } = null!;
    }
}
