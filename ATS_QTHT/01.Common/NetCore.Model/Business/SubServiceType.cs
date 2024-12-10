using System;

namespace NetCore.Models
{
    public class SubServiceType
    {
        public Guid id { get; set; }

        public Guid service_type_id { get; set; }

        public string code { get; set; }
        public string? icons { get; set; }

        public string name { get; set; }

        public DateTime date_created { get; set; }

        public DateTime date_updated { get; set; }
    }
}
