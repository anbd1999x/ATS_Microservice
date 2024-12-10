namespace NetCore.Models
{
    public class ServiceType_ServiceTypeTag : MasterCommonModel
    {
        public int? id { get; set; }
        
        public string? service_type_id { get; set; }        
        public int service_type_tag_id { get; set; }
    }

}