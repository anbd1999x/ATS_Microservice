using System;

namespace NetCore.Models
{
    public class BaoKimSettlementTransaction
    {
        public int? id { get; set; }
        public string? trans_settlement_code { get; set; }
        public string? trans_payment_code { get; set; }
        public string? trans_no_bk { get; set; }
        public string? bank_no { get; set; }
        public string? trans_value_total { get; set; }
        public string? trans_code { get; set; }
        public string? partner_code { get; set; }
        public string? partner_branch_code { get; set; }
        public string? collection_fee { get; set; }
        public string? amount_settled { get; set; }
        public string? settlement_fee { get; set; }
        public string? actual_settlement_amount { get; set; }
        public string? settlement_object { get; set; }
        public string? settlement_period { get; set; }
        public string? settlement_status { get; set; }
        public string? trans_create_date { get; set; }
        public string? trans_update_date { get; set; }
        public DateTime? create_date { get; set; }
    }
}