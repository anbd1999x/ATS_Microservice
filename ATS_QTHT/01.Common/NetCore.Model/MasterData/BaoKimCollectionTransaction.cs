using System;

namespace NetCore.Models
{
    public class BaoKimCollectionTransaction
    {
        public int? id { get; set; }
        
        public string? trans_no_bk { get; set; }
        public string? bank_no { get; set; }
        public string? bank_name { get; set; }
        public string? trans_code { get; set; }
        public string? partner_code { get; set; }
        public string? partner_branch_code { get; set; }
        public string? payment_gate_total { get; set; }
        public string? collection_fee { get; set; }
        public string? transfer_user_amount { get; set; }
        public string? transfer_merchant_amount { get; set; }
        public string? expense_fee { get; set; }
        public string? actual_merchant_amount { get; set; }
        public string? actual_ats_amount { get; set; }
        public string? trans_date_bank { get; set; }
        
        public string? trans_date_BaoKim { get; set; }
        public string? partner_transaction_date { get; set; }
        public string? status { get; set; }
        
        public DateTime? create_date { get; set; }
    }
}