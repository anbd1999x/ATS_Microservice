using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class PartnerAccNo : MasterCommonModel
    {
        public int id { get; set; }
        public Guid? partner_id { get; set; }
        public int? bk_id { get; set; }
        public byte? status { get; set; } = 1;
        public string acc_numb { get; set; }
        public string bank_code { get; set; }
        public string acc_holder { get; set; }
        public int type { get; set; }
        public string auth_doc_numb { get; set; }
        public string auth_doc_link { get; set; }
        public bool? is_default { get; set; } = false;
    }
}
