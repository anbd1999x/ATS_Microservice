using System;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;

namespace NetCore.Models
{
    public class StatisticRevenueDaily
    {
        public Guid id { get; set; }
        public decimal total_accumulate_orders { get; set; } // tổng số đơn
        public decimal total_accumulate_order_success { get; set; } // tổng số đơn thành công
        public decimal total_revenue_merchant { get; set; } // doanh thu của merchant ( cả user chưa là thành viên và user là thành viên )
        public decimal user_revenue_merchant { get; set; } // doanh thu của Merchant với những user là thành viên của Cashplus
        public decimal nonuser_revenue_merchant { get; set; } // doanh thu của Merchant với những user chưa là thành viên của Cashplus
        public decimal discount_of_merchant { get; set; } // tổng chiết khấu theo hợp đồng
        public decimal discount_for_user { get; set; } // số tiền chiết khấu user 40% của chiết khấu hợp đồng ( điểm hoàn cho user và tiền hoàn )
        public decimal total_cashback_for_user { get; set; } // số tiền hoàn realtime cho user
        public decimal total_point_for_user { get; set; } // số điểm tích lũy cho user (bao gồm cả user và merchant)
        public decimal total_accumulate_user_points { get; set; } // tổng số điểm tích lũy cho user
        public decimal total_accumulate_partner_points { get; set; } // tổng số điểm tích lũy cho merchant
        public decimal discount_for_cashplus { get; set; } // tổng chiết khấu cho cashplus 60% của chiết khấu hợp đồng
        public decimal fees_and_other_charges { get; set; } // tổng phí giao dịch ( thanh toán real-time, phí chi, phí thu)
        public decimal collection_fees_charges { get; set; } // tổng phí thu hộ giao dịch
        public decimal expense_fees_charges { get; set; } // tổng phí chi hộ giao dịch
        public decimal total_affiliate_points { get; set; } // tổng số điểm affilate cho lv1
        public decimal total_affiliate_partner_points { get; set; } // tổng số điểm affilate cho lv1 là merchant
        public decimal total_affiliate_user_points { get; set; } // tổng số điểm affilate cho lv1 là user
        public decimal total_cashplus_revenue { get; set; } // doanh thu của Cashplus còn lại sau phí
        public decimal total_cashplus_profit { get; set; } // lợi nhuận của Cashplus còn lại sau phí
        public decimal total_customers { get; set; } // tổng số khách hàng mới
        public decimal total_partners { get; set; } // tổng số merchant tiếp cận mới
        public decimal total_partners_active { get; set; } // tổng số merchant đã hoạt động ( hiển thị được trên App Cashplus)
        public decimal total_change_orders { get; set; } // tổng số đơn đổi điểm
        public decimal total_accumulate_customer_change_points { get; set; } // tổng tiền đã đổi từ điểm cho khách hàng
        public DateTime statistic_date { get; set; }
    }
}