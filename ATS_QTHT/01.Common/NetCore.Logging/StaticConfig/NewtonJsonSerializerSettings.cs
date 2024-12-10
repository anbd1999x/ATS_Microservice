using System.Text.Json;

namespace NetCore.Logging.StaticConfig
{
    public static class JsonSerializerSettings
    {
        public static readonly JsonSerializerOptions CAMEL = new JsonSerializerOptions
        {

            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };
    }
}