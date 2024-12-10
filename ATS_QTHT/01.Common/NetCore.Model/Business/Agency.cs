namespace NetCore.Models
{
    public class Agency
    {
        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public decimal discount_rate { get; set; }
        public int affiliate_level { get; set; }
    }
}