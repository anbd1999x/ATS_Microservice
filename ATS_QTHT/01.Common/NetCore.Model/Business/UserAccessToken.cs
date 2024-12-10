using System;

namespace NetCore.Models
{
    public class UserAccessToken
    {
        public Guid id { get; set; }
        public string login_token { get; set; }
        public string refresh_token { get; set; }
        public string username { get; set; }
        public string user_type { get; set; }
        public DateTime date_created { get; set; }
        public DateTime expire_at { get; set; }
    }
}