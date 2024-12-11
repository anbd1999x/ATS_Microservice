using Microsoft.Extensions.DependencyInjection;
using NetCore.Core.Caching.Impl;
using NetCore.Core.Caching.Interface;
using NetCore.Core.Utils;

namespace NetCore.Core.Caching.Ioc
{
    public static class CachingServiceCollection
    {
        /// <summary>
        /// AddCachingProcessServices
        /// </summary>
        /// <param name="services"></param>
        public static void AddCachingProcessServices(this IServiceCollection services)
        {
            switch (StaticVariable.CacheType)
            {
                case 1:
                    RedisCachedServiceCollection.RegisterIoCs(ref services);
                    break;

                default:
                    services.AddSingleton<ICached>(cd => { return new NoCached(); });
                    break;
            }

            services.AddSingleton<ICacheAppService, CacheAppService>();
        }
    }
}
