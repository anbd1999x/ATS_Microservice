using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class PartnerDocument : MasterCommonModel
    {
        public Guid? id { get; set; }
        public Guid? partner_id { get; set; }
        public string? file_name { get; set; }
        public string? links { get; set; }

        [NotMapped]
        public string? name { get; set; }
        [NotMapped]
        public string? link { get; set; }
    }
}
