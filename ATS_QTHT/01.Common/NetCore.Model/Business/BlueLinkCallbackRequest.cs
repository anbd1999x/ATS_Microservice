namespace NetCore.PaymentGate
{
    public class BlueLinkCallbackRequest
    {
        public string? msisdn { get; set; }
        public string? requestId { get; set; }
        public string? sendTime { get; set; }
        public string? responseTimeTelco { get; set; }
        public string? status { get; set; }
        public string? referentId { get; set; }
        public int? retryCount { get; set; }
        public string? errorInfo { get; set; }
        public int? mtcount { get; set; }
    }
}