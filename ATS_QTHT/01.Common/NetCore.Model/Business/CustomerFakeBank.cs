using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class CustomerFakeBank
    {
        public Guid? id { get; set; }
        public string? bank_account { get; set; }
        public string? bank_owner { get; set; }
        public string? bank_name { get; set; }
        public Guid? user_id { get; set; }
        public string? supplier { get; set; }
        public string? user_created { get; set; }
        public string? qr_link { get; set; }
        public string? qr_base64 { get; set; }
        public DateTime? date_created { get; set; }
    }
}
