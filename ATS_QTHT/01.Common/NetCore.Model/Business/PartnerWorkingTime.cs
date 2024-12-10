using System;

namespace NetCore.Models
{
    public class PartnerWorkingTime
    {
        public int id { get; set; }
        public Guid? partner_id { get; set; }
        public string start_hour { get; set; }
        public string end_hour { get; set; }
        public DateTime date_created { get; set; } = DateTime.Now;
        public DateTime date_updated { get; set; } = DateTime.Now;
    }
}
