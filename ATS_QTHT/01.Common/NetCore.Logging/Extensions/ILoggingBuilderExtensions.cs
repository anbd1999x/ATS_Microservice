using NetCore.Logging.NLogCustom;
using NetCore.Logging.StaticConfig;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NLog.Web;
using System.Collections.Generic;
using Serilog;
using Microsoft.Extensions.Hosting;
using Serilog.Filters;
using Serilog.Formatting.Compact;
using Microsoft.AspNetCore.Builder;
using NetCore.Core.Utils;

namespace NetCore.Logging.Extensions
{
    public static class LoggingBuilderExten
    {
        /// <summary>
        /// UseSerilog
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="configuration"></param>
        public static void UseSerilog(WebApplicationBuilder builder, IConfiguration configuration)
        {
            Log.Logger = new LoggerConfiguration()
                   .ReadFrom.Configuration(builder.Configuration) // Đọc từ cấu hình appsettings.json
                   .CreateLogger();
            builder.Logging.ClearProviders(); 
            builder.Logging.AddSerilog(Log.Logger);
        }

        /// <summary>
        ///UseNLog
        /// </summary>
        /// <param name="builder">Using ILogging builder</param>
        /// <param name="configFile">nlog.config file</param>
        /// <param name="kafkaTaget">Ip and port of Kafka cluster</param>
        /// <param name="applicationStore">Application name and Application Id</param>
        public static void UseNLog(string configFile, string kafkaTaget, LogSourceTypeEnums applicationStore)
        {
            NLogTargetCustom.RegisterTarget();
            StaticConfiguration.KafkaServer = kafkaTaget;
            StaticConfiguration.ApplicationStore = new Dictionary<int, string> { { (int)applicationStore, EnumConvert.GetEnumDescription(applicationStore) } };
            NLogBuilder.ConfigureNLog(configFile);
        }
    }
}