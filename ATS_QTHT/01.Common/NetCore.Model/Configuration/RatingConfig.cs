using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore.Models
{
    public class RatingConfig : MasterCommonModel
    {
        public Guid? id { get; set; }
        public string? rating { get; set; }
        public string? description { get; set; }
    }
}
