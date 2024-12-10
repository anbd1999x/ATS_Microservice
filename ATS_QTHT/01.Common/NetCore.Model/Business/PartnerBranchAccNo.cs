using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class PartnerBranchAccNo : MasterCommonModel
    {
        public int id { get; set; }
        public Guid? partner_id { get; set; }
        public int? bk_id { get; set; }
        public byte? status { get; set; }
        public string branch_id { get; set; }
        public string branch_name { get; set; }
        public string branch_address { get; set; }
        public string branch_rep_name { get; set; }
        public DateTime? branch_rep_yob { get; set; }
        public string branch_rep_tax_no { get; set; }
        public string branch_rep_identity_no { get; set; }
        public DateTime? branch_rep_identity_issue_date { get; set; }
        public string branch_rep_identity_issue_place { get; set; }
        public string branch_rep_permanent_residence { get; set; }
        public string cashplus_account_name { get; set; }
        public string acc_numb { get; set; }
        public string bank_code { get; set; }
        public string acc_holder { get; set; }
        public string phone { get; set; }
        public int? discount_rate { get; set; }
        public string? link_qr { get; set; }
        public string? qr_bank_account { get; set; }
        public string? qr_bank_owner { get; set; }
        public string? qr_bank_name { get; set; }
        public string? qr_base64 { get; set; }
        public string? latitude { get; set; }
        public string? longtitude { get; set; }
        public string? avatar { get; set; }
        public string? avatar_small { get; set; }
        public string support_person_id { get; set; }
        [NotMapped]
        public string username { get; set; }
        [NotMapped]
        public string password { get; set; }

        public int? type_tag { get; set; }
        
        public int? floor_count { get; set; }
        public string? theme { get; set; }
    }
}
