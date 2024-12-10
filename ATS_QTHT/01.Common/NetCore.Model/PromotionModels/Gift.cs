using NetCore.Extensions;
using System;
using System.Collections.Generic;

namespace NetCore.Models.PromotionModels
{
    public class Gift
    {
        public Guid id { get; set; }
        public string gift_name { get; set; } = null!;
        public decimal gift_value { get; set; }
        public string description { get; set; } = null!;
        public Enums.GiftType gift_type { get; set; }
        public DateTime created_at { get; set; }
        public Guid created_by { get; set; }
        public DateTime? updated_at { get; set; }
        public Guid? updated_by { get; set; }
        public Enums.PaymentTypeGift payment_type { get; set; }
        public string? unit { get; set; }
        public ICollection<Condition> Conditions { get; set; } = new List<Condition>();
    }
}
