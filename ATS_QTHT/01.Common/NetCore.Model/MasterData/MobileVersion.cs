namespace NetCore.Models
{
    public class MobileVersion
    {
        public int? id { get; set; }
        public string? current_version { get; set; }
        public string? required_version { get; set; }
        public string? platform { get; set; }
    }
}
