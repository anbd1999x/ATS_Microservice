using System;

namespace NetCore.Models
{
    public class Accessary
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image_path { get; set; }
        public long price { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
