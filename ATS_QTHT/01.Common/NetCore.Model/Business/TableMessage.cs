using System;

namespace NetCore.PaymentGate
{
    public class TableMessage
    {
        public Guid? id { get; set; }
        public Guid? table_id { get; set; }
        public string? message { get; set; }
        public DateTime date_created { get; set; }
        public string data { get; set; }
        public string type { get; set; }
        public string from { get; set; }
    }
}