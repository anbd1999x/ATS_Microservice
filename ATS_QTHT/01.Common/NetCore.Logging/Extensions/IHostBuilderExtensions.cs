using Microsoft.Extensions.Hosting;
using NLog.Web;
using Serilog;

namespace NetCore.Logging.Extensions
{
    public static class IHostBuilderExtensions
    {
        public static IHostBuilder AddNLog(this IHostBuilder hostBuilder)
        {
            return hostBuilder.UseNLog();
        }
    }
}