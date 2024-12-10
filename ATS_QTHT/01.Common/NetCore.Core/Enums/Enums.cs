using System.ComponentModel;

namespace NetCore.Core.Enums
{
    public class Enums
    {
        public enum OrderStatus
        {
            Pending = 1, // Customer yêu cầu
            Processing = 2, // Merchant xác nhận
            Cancel = 4,   // Hủy order
            Release = 5, // Hoàn thành đơn hàng
            Clear = 6, // Clear bàn
        }

        public enum CartStatus
        {
            Pending = 1, // Customer yêu cầu
            Processing = 2, // Merchant xác nhận
            Done = 3,      // Hoàn thành order
            Cancel = 4,   // Hủy order
        }

        public enum OrderItemStatus
        {
            Pending = 1,
            Accept = 2, // đã accept
            Ready = 3, // đã lên
            OutOfStock = 4,
            Clear = 5, // Clear bàn
            Cancel = 6,
        }

        public enum TableStatus
        {
            Free = 1,
            Busy = 2,
            Pending = 3,
            Disabled = 4,
        }

        public enum InvoiceStatus
        {
            Pending = 1,
            Done = 2,
        }

        public enum AccumulatePointOrderStatus
        {
            Init = 999,
            Processing = 4,
            Success = 5,
            Failed = 6
        }

        public enum BaoKimTransactionStatus
        {
            Success = 25,
            Failed = 26,
            Pending = 27
        }

        public enum ActionType
        {
            View = 1,
            Add = 2,
            Edit = 3,
            Delete = 4,
            Export = 5,
            Import = 6,
            Other = 7
        }

        public enum SmsProviderId
        {
            ESms = 1,
            BlueLink = 2
        }

        public enum ReconciliationType
        {
            Income = 1,
            Expenditure = 2
        }

        public enum NotificationGetListTarget
        {
            User = 1,
            Merchant = 2
        }

        public enum PaymentType
        {
            Cash = 1,
            BaoKim = 2
        }

        public enum BkTransactionType
        {
            [Description("MER_TRANSFER_NTD")] ToUser = 1,
            [Description("PAYMENT_GATE")] ToPaymentGate = 2,
            [Description("AFFILIATE")] ToAffiliate = 3,
            [Description("MER_TRANSFER_SYS")] ToSystem = 4,
            [Description("SYS_TRANSFER_MERCHANT")] ToMerchant = 5,
            [Description("AGENCY_SALE_AFFILIATE")] ToSaleAgency = 6,
            [Description("AGENCY_COMPANY_AFFILIATE")] ToCompanyAgency = 7
        }

        public enum BkTransactionStatus
        {
            Success = 25,
            Failed = 26,
            Pending = 27
        }

        public enum ReconciledStatus
        {
            NotReconciled = 1,
            Reconciling = 2,
            DeviatedReconciliation = 3,
            ReconciliationMatched = 4,
        }

        public enum GiftRecipient
        {
            User = 1,
            Merchant = 2
        }

        public static class FeePayer
        {
            public const string USER = "USER";
            public const string MERCHANT = "MERCHANT";
            public const string ATS = "ATS";
            public const string BAOKIM = "BAOKIM";
        }

        public enum OrderType
        {
            [Description("CHANGE_POINT")] CHANGE_POINT,
            [Description("PUSH")] PUSH,
            [Description("AFF_LV_1")] AFF_LV_1,
        }

        public static class NotificationUserType
        {
            public const string ALL = "ALL";
            public const string MERCHANT = "MERCHANT";
            public const string CUSTOMER = "CUSTOMER";
        }

        public enum SettlementObject
        {
            Merchant = 1,
            User = 2,
            ATS = 3
        }
        public enum ChangePointOrderStatus
        {
            Init = 18,
            Processing = 4,
            Success = 5,
            Failed = 6
        }

        public enum PartnerStatus
        {
            Processing = 14,
            Active = 15,
            Failed = 16
        }

        public enum PromotionStatus
        {
            Test = 0,
            Publish = 1,
            End = 2,
        }

        public enum GiftType
        {
            Cash = 1,
            Point = 2,
            Voucher = 3,
            Product = 4,
            DiscountMerchant = 5
        }

        public enum PaymentTypeGift
        {
            RealTime = 1,
            Direct = 2,
            Ship = 3
        }

        public enum ConditionType
        {
            ConditionCount = 1,
            ConditionTotalAmount = 2,
            ConditionProduct = 3,
            All = 4
        }

        public enum PromotionUserStatus
        {
            InProgress = 1,
            Done = 2,
        }
        public static class PrefixQR
        {
            public const string TD = "TD";
            public const string IV = "IV";
        }

        public enum MessageSendBy
        {
            Customer = 1,
            Merchant = 2,
        }

        public enum MessageType
        {
            AcceptOrder = 1,
            CancelOrder = 2,
            AcceptOrderItem = 3,
            DeleteOrderItem = 4,
        }
    }

    public enum ResponseEnum
    {
        ExperiedToken = -1,
        UserNotFound = -2,
        UserLocked = -3,
        UserNotEnable = -4,
        UserNoRole = -5
    }

    public enum KeyCloak_ResponseStatus
    {
        Created,
        NoContent
    }

    public enum Wso2_ResponseStatus
    {
        NoContent,
        OK,
        Created
    }
}
