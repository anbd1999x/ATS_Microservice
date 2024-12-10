using Microsoft.Extensions.DependencyInjection;
using NetCore.Core.Caching.Impl;
using NetCore.Core.Caching.Interface;
using NetCore.Core.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore.Core.Caching.Ioc
{
    public static class CachingServiceCollection
    {
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
