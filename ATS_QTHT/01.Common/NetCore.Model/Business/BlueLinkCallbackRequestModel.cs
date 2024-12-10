using System;

namespace NetCore.PaymentGate
{
    public class BlueLinkCallbackRequestModel
    {
        public int id { get; set; }
        public string? msisdn { get; set; }
        public string? request_id { get; set; }
        public string? send_time { get; set; }
        public string? response_time_telco { get; set; }
        public string? status { get; set; }
        public string? referent_id { get; set; }
        public int? retry_count { get; set; }
        public string? error_info { get; set; }
        public int? mtcount { get; set; }
        public DateTime date_created { get; set; }
    }
}