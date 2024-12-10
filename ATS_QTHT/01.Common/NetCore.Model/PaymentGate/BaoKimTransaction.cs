using System;
using System.Collections.Generic;
using NetCore.Core.Enums;

namespace NetCore.Models
{
    public class BaoKimTransaction
    {
        public Guid? id { get; set; } // Init only
        public string? payment_type { get; set; } // Init only
        public string? transaction_no { get; set; } // Init only
        public string? bao_kim_transaction_id { get; set; } // Init only
        public DateTime? transaction_date { get; set; } // Init only
        public DateTime? payment_received_date { get; set; } // Init only
        public string? bank_receive_name { get; set; } // Response
        public string? bank_receive_account { get; set; } // Response
        public int? bank_receive_id { get; set; } // Response
        public string? bank_receive_owner { get; set; } // Response
        public string? collection_fee_payer { get; set; } // Người chịu phí thu hộ
        public string? expense_fee_payer { get; set; } // Người chịu phí chi hộ
        public decimal? amount { get; set; } // Webbhook 2
        public int? trans_status { get; set; } // Init
        public string? trans_log { get; set; }
        public string? transaction_description { get; set; } // Webhook 2
        public Guid? accumulate_point_order_id { get; set; } // Init only
        public Guid? partner_id { get; set; } // Webhook 2
        public Guid? customer_id { get; set; } // Webhook 2
        public decimal? amount_balance { get; set; } = 0;

        // For system, this field stands for amount BEFORE fee calculation. The actual received amount = this field - fees
        // For other sides, this field stands for amount that he/she actually receives to bank account or point transfer
        public decimal? actual_receive_amount { get; private set; } // Webhook 2
        public decimal? total_fees { get; set; } // Webhook 2
        public DateTime? created_at { get; set; } // Init only
        public DateTime? updated_at { get; set; } // Init, Webhook 2
        public bool should_transfer_money { get; private set; } // Webhook 2
        public bool is_realtime_transaction { get; set; }
        public decimal user_expense_fee { get; private set; } // Webhook 2 (phí chi hộ user)
        public decimal merchant_expense_fee { get; private set; } // Webhook 2 (phí chi hộ merchant)
        public decimal collection_fee { get; private set; } // Webhook 2 (phí thu hộ)bk_value_amount
        
        public string? bk_value_amount { get; set; } // Webhook 2 (phí thu hộ)bk_value_amount
        
        public Enums.ReconciledStatus? reconciled_status { get; set; }
        public string? qr_path { get; set; } // Init only
        public BaoKimTransaction()
        {
            id = Guid.NewGuid();
            collection_fee = 0;
            user_expense_fee = 0;
            merchant_expense_fee = 0;
            total_fees = 0;
            actual_receive_amount = 0;
            amount_balance = 0;
            amount = 0;
        }

        public BaoKimTransaction(
            Enums.BkTransactionType paymentType,
            string transactionNo,
            string bkTransactionId,
            Guid accumulatePointOrderId,
            DateTime requestedAt,
            DateTime dateTime,
            string bankReceiveAccount,
            string bankReceiveName,
            string bankReceiveOwner,
            int? bankReceiveId
        )
        {
            id = Guid.NewGuid();
            payment_type = ParsePaymentType(paymentType);
            transaction_no = transactionNo;
            bao_kim_transaction_id = bkTransactionId;
            transaction_date = requestedAt;
            accumulate_point_order_id = accumulatePointOrderId;

            trans_status = (int)Enums.BkTransactionStatus.Pending;
            created_at = dateTime;
            updated_at = dateTime;
            
            bank_receive_account = bankReceiveAccount;
            bank_receive_name = bankReceiveName;
            bank_receive_owner = bankReceiveOwner;
            bank_receive_id = bankReceiveId;

            collection_fee = 0;
            user_expense_fee = 0;
            merchant_expense_fee = 0;
            total_fees = 0;
            actual_receive_amount = 0;
            amount_balance = 0;
            amount = 0;
        }

        public BaoKimTransaction Update(string? baoKimTransactionId, string? transactionNo, Guid? partnerId,
            Guid? customerId)
        {
            bao_kim_transaction_id = baoKimTransactionId;
            transaction_no = transactionNo;
            partner_id = partnerId;
            customer_id = customerId;

            return this;
        }

        public BaoKimTransaction Update(Guid? partnerId, Guid? customerId, DateTime dateTime)
        {
            partner_id = partnerId;
            customer_id = customerId;
            updated_at = dateTime;

            return this;
        }

        public void SetDescription(string description)
        {
            transaction_description = description;
        }

        public void SetActualReceiveAmount(decimal actualReceiveAmount)
        {
            actual_receive_amount = actualReceiveAmount;
        }

        public void SetBankDetails(string name, string accountNumber, string owner)
        {
            bank_receive_name = name;
            bank_receive_account = accountNumber;
            bank_receive_owner = owner;
        }

        public void SetUserExpenseFee(decimal userExpenseFee)
        {
            user_expense_fee = userExpenseFee;
        }

        public void SetMerchantExpenseFee(decimal merchantExpenseFee)
        {
            merchant_expense_fee = merchantExpenseFee;
        }

        public void SetCollectionFee(decimal collectionFee)
        {
            collection_fee = collectionFee;
        }

        public void UpdateAmount(decimal amount, bool isRealtimeTransaction)
        {
            this.amount = amount;
            is_realtime_transaction = isRealtimeTransaction;
        }

        public void ShouldTransferMoney(bool shouldTransferMoney = true)
        {
            should_transfer_money = shouldTransferMoney;
        }

        public void CalculateTotalFees()
        {
            total_fees = user_expense_fee + merchant_expense_fee + collection_fee;
        }

        public static string ParsePaymentType(Enums.BkTransactionType paymentType)
        {
            Dictionary<Enums.BkTransactionType, string> paymentTypeDict =
                new Dictionary<Enums.BkTransactionType, string>
                {
                    { Enums.BkTransactionType.ToUser, "MER_TRANSFER_NTD" },
                    { Enums.BkTransactionType.ToPaymentGate, "PAYMENT_GATE" },
                    { Enums.BkTransactionType.ToAffiliate, "AFFILIATE" },
                    { Enums.BkTransactionType.ToSystem, "MER_TRANSFER_SYS" },
                    { Enums.BkTransactionType.ToMerchant, "SYS_TRANSFER_MERCHANT" },
                    { Enums.BkTransactionType.ToSaleAgency, "AGENCY_SALE_AFFILIATE" },
                    { Enums.BkTransactionType.ToCompanyAgency, "AGENCY_COMPANY_AFFILIATE" },
                };

            paymentTypeDict.TryGetValue(paymentType, out string value);

            return value;
        }
    }
}