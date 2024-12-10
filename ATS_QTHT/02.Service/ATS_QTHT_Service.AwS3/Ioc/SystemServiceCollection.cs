
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCore.Core.Utils;
using ATS_QTHT_Service.AwsS3.Logic.ProcessAwsS3;

namespace ATS_QTHT_Service.AwsS3.Ioc
{
    ///<Summary>
    /// RegisterIoCs
    ///</Summary>
    public static class SystemServiceCollection
    {
        ///<Summary>
        /// RegisterIoCs
        ///</Summary>
        public static void RegisterIoCs(this IServiceCollection services, IConfiguration configuration)
        {
            AppSettings.Instance.SetConfiguration(configuration);
            services.AddScoped<IDbProcessAwsS3Handler, DbProcessAwsS3Handler>();
        }
    }
}
