using NetCore.Core.Utils;
using NetCore.DataProcess.EntitiFramework;
using MediatR;
using NetCore.Core.Caching.Ioc;

namespace ATS_QTHT_Service.CRM.Ioc
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
            services.AddHttpContextAccessor();

        }
    }
}
