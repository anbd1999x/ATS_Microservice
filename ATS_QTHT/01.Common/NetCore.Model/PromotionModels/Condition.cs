using NetCore.Extensions;
using System;
using System.Collections.Generic;

namespace NetCore.Models.PromotionModels
{
    public class Condition
    {
        public Guid id { get; set; }
        public Guid promotion_id { get; set; }
        public string condition_name { get; set; }
        public decimal? total_amount { get; set; }
        public int? count_condition { get; set; }
        public decimal? min_amount { get; set; }
        public Enums.ConditionType condition_type { get; set; }
        public int? status { get; set; }
        public int? order { get; set; }
        public DateTime created_at { get; set; }
        public Guid created_by { get; set; }
        public DateTime? updated_at { get; set; }
        public Guid? updated_by { get; set; }
        public string? description { get; set; }
        public Guid? parent_id { get; set; }
        public Guid gift_id { get; set; }
        public int? gift_limit { get; set; }

        public Promotion Promotion { get; set; } = null!;
        public Gift Gift { get; set; } = null!;
        public ICollection<GiftHistory> GiftHistories { get; set; } = new List<GiftHistory>();
    }
}
