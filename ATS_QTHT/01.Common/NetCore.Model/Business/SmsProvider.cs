using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace NetCore.Models
{
    public class SmsProvider
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } = default!;
        
        [Column("is_enabled")]
        [JsonProperty("is_enabled")]
        public bool IsEnabled { get; set; }
    }
}
