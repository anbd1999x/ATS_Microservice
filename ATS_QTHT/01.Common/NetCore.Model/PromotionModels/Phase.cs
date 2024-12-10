using System;

namespace NetCore.Models.PromotionModels
{
    public class Phase
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public Guid promotion_id { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
    }
}