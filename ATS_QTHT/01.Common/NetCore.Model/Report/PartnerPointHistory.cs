using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore.Models
{
    public class PartnerPointHistory
    {
        public Guid? id { get; set; }
        public Guid? partner_id { get; set; }
        public int? partner_branch_id { get; set; }
        public Guid? source_id { get; set; }
        public string? order_type { get; set; }
        public decimal? point_amount { get; set; }
        public DateTime? trans_date { get; set; }
        public string? point_type { get; set; }
        public DateTime? exchange_date { get; set; }
        public int? status { get; set; }
        public bool? check_sms { get; set; }
        public bool? send_sms { get; set; }
        public decimal? point_sms_total { get; set; }
        
        public Guid? ref_id { get; set; }
    }
}
