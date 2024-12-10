using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class UserPermission
    {
        public Guid? id { get; set; }
        public Guid? user_id { get; set; }
        public Guid? action_id { get; set; }
    }
}
