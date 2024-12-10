using System;

namespace NetCore.Models
{
    public class BKCallbackRequestModel
    {
        public int id { get; set; }

        public string order_type { get; set; }

        public string body { get; set; }  // JSON được lưu dưới dạng chuỗi
        public string? response_result { get; set; }  // 

        public DateTime? request_date { get; set; }

        public DateTime date_created { get; set; } = DateTime.Now;

        public DateTime date_updated { get; set; } = DateTime.Now;

    }
}
