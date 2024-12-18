﻿using Microsoft.Extensions.DependencyInjection;
using NetCore.Core.Caching.Common;
using NetCore.Core.Caching.Impl;
using NetCore.Core.Caching.Interface;
using NetCore.Core.Utils;

namespace NetCore.Core.Caching.Ioc
{
    public static class RedisCachedServiceCollection
    {
        /// <summary>
        /// RegisterIoCs
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterIoCs(ref IServiceCollection services)
        {
            var cacheQueueConfig = AppSettings.Instance.Get<CachingConfigModel>("Cache:Redis:Queue");
            var cacheDataConfig = AppSettings.Instance.Get<CachingConfigModel>("Cache:Redis:Data");
            if (cacheDataConfig.Allow)
            {
                services.AddSingleton<ICached>(sv => { return new RedisCached(cacheDataConfig); });
            }
            else
            {
                services.AddSingleton<ICached>(sv => { return new NoCached(); });
            }

            if (cacheQueueConfig.Allow)
            {
                services.AddSingleton<IQueueAndListCached>(sv => { return new RedisCached(cacheQueueConfig); });
            }
            else
            {
                services.AddSingleton<IQueueAndListCached>(sv => { return new NoCacheQueue(); });
            }

            return services;
        }
    }
}
