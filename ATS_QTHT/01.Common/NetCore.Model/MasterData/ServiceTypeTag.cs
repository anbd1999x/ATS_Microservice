using System.Collections.Generic;

namespace NetCore.Models
{
    public class ServiceTypeTag : MasterCommonModel
    {
        public int? id { get; set; }
        
        public string? code { get; set; }
        
        public string? name { get; set; }
    }
}