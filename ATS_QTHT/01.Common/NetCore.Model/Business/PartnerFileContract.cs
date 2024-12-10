using System;

namespace NetCore.Models.Business
{
    public class PartnerFileContract
    {
        public int id { get; set; }
        public string filepath { get; set; }
        public Guid partner_id { get; set; }
        public int type { get; set; }
    }
}
