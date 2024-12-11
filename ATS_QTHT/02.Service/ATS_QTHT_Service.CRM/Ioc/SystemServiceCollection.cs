using NetCore.Core.Utils;
using NetCore.DataProcess.EntitiFramework;
using MediatR;
using NetCore.Core.Caching.Ioc;
using ATS_QTHT_Service.CRM.Logic;
using NetCore.DataProcess.Ioc;

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
        public static IServiceCollection RegisterIoCs(this IServiceCollection services, IConfiguration configuration)
        {
            AppSettings.Instance.SetConfiguration(configuration);
            services.AddCachingProcessServices(); 
            services.RegisterDataContextServiceComponents(configuration);
            services.RegisterDapperServiceComponents();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            //services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<IDbUserHandler, DbUserHandler>();
            services.AddHttpContextAccessor();
            return services;

        }
    }
}
