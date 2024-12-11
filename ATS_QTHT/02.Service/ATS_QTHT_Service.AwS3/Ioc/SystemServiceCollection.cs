
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCore.Core.Utils;
using ATS_QTHT_Service.AwsS3.Logic.ProcessAwsS3;
using NetCore.DataProcess.EntitiFramework;
using MediatR;
using NetCore.Core.Caching.Ioc;

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
            services.AddCachingProcessServices(); 
            services.RegisterDataContextServiceComponents(configuration);
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<IDbProcessAwsS3Handler, DbProcessAwsS3Handler>();
            services.AddHttpContextAccessor();


        }
    }
}
