using NetCore.Core.Enums;
using System;
using System.Collections.Generic;

namespace NetCore.Models.PromotionModels
{
    public class Promotion
    {
        public Guid id { get; set; }
        public string promotion_name { get; set; } = null!;
        public string promotion_code { get; set; } = null!;
        public DateTime? start_date { get; set; }
        public DateTime? end_date { get; set; }
        public Enums.PromotionStatus status { get; set; }
        public DateTime created_at { get; set; }
        public Guid created_by { get; set; }
        public DateTime? updated_at { get; set; }
        public Guid? updated_by { get; set; }
        public decimal total_budget { get; set; }
        public decimal personal_budget { get; set; }
        public string? description { get; set; }

        public ICollection<Condition> Conditions { get; set; } = new List<Condition>();
        public ICollection<PhasePromotion> PhasePromotions { get; set; } = new List<PhasePromotion>();
        public ICollection<GiftHistory> GiftHistories { get; set; } = new List<GiftHistory>();
    }
}
