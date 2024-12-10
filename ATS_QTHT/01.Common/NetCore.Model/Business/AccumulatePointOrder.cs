using NetCore.Core.Enums;
using System;

namespace NetCore.Models
{
    public class AccumulatePointOrder : MasterCommonModel
    {
        public Guid? id { get; set; }
        public string? trans_no_bk { get; set; }
        public string? trans_no { get; set; }
        public Guid? customer_id { get; set; }
        public Guid? partner_id { get; set; }
        public decimal? fee_amount { get; set; }
        public decimal? bill_amount { get; set; }
        public decimal? point_exchange { get; set; }
        public decimal? point_avaiable { get; set; }
        public decimal? point_waiting { get; set; }
        public decimal? point_partner { get; set; }
        public decimal? discount_rate { get; set; }
        public decimal? point_customer { get; set; }
        public decimal? point_system { get; set; }
        public int? status { get; set; }
        public string? approve_user { get; set; }
        public DateTime? approve_date { get; set; }
        public string? description { get; set; }
        public string? reason_fail { get; set; }
        public string? files { get; set; }
        public string? address { get; set; }
        public string? payment_type { get; set; }
        public string? session_id { get; set; }
        public string? payment_gate_response { get; set; } // serialized webhook data
        public string? return_type { get; set; }
        public DateTime? payment_gate_response_date { get; set; }
        public decimal? amount_customer { get; set; }
        public decimal? amount_partner { get; set; }
        public decimal? amount_system { get; set; }
        public int? partner_branch_id { get; set; }
        public bool? is_static_qr { get; set; }
        public string? partner_branch_code { get; set; }
        public DateTime? updated_partial_webhook_at { get; set; }
        
        public DateTime? updated_full_webhook_at { get; set; }
        
        public Enums.ReconciledStatus? reconciled_status { get; set; }

        public Guid? invoicetotal_id { get; set; }

        public AccumulatePointOrder()
        {
        }

        public void Update(
            Guid partnerId,
            decimal feeAmount,
            decimal billAmount,
            decimal discountRate,
            string approveUser,
            string? description,
            string? address,
            Enums.PaymentType paymentType,
            string? paymentGateResponse,
            string? returnType,
            int? partnerBranchId,
            string? partnerBranchCode)
        {
            partner_id = partnerId;
            fee_amount = feeAmount;
            bill_amount = billAmount;
            discount_rate = discountRate;
            status = 4;
            approve_user = approveUser;
            this.description = description;
            this.address = address;
            payment_type = paymentType.ToString();
            payment_gate_response = paymentGateResponse;
            return_type = returnType;
            partner_branch_id = partnerBranchId;
            partner_branch_code = partnerBranchCode;

            DateTime now = DateTime.Now;
            date_created = now;
            date_updated = now;
            approve_date = now;
            payment_gate_response_date = now;
            updated_partial_webhook_at = now;
        }

        public void UpdateCustomerId(Guid customerId)
        {
            customer_id = customerId;
        }
    }
}