namespace NetCore.Models
{
    public class AgencyAffiliateConfig
    {
        public int id { get; set; }
        public int agency_id { get; set; }
        public decimal level_1 { get; set; }
        public decimal level_2 { get; set; }
    }
}