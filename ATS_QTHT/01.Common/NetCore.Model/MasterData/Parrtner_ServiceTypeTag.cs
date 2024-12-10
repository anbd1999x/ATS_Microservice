using System;

namespace NetCore.Models
{
    public class Parrtner_ServiceTypeTag : MasterCommonModel
    {
        public int? id { get; set; }
        
        public Guid? partner_id { get; set; }    
        
        public int service_type_tag_id { get; set; }
        
        
        public int branch_id { get; set; }
    }
}