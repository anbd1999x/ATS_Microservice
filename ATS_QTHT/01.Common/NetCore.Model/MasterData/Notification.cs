using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using NetCore.Extensions;

namespace NetCore.Models
{
    public class Notification : MasterCommonModel
    {
        public Guid? id { get; set; }
        public Guid? user_id { get; set; }
        public Guid? type_id { get; set; }
        public string? title { get; set; }
        public string? avatar { get; set; }
        public string? content { get; set; }
        public string? description { get; set; }
        public string? system_type { get; set; }
        public Guid? reference_id { get; set; }
        public Guid? cms_notification_id { get; set; }

        public decimal? point { get; set; }

        public Notification()
        {
        }

        public Notification(string title, string content, string systemType, Guid userId)
        {
            DateTime now = DateTime.Now;

            id = Guid.NewGuid();
            this.title = title;
            point = 0;
            type_id = Guid.Parse("16FE077C-D9FD-45A3-BE22-FFE0F7DF6361");
            user_id = userId;
            date_created = now;
            date_updated = now;
            this.content = content;
            system_type = "VAPG_CALLBACK";
            reference_id = null;
        }
    }
}