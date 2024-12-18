﻿using Microsoft.AspNetCore.Http;

namespace NetCore.Core.Caching.Common
{
    public class CacheHelpers
    {
        /// <summary>
        /// IsRequestClearCache
        /// </summary>
        /// <param name="context"></param>
        /// <param name="refreshKey"></param>
        /// <returns></returns>
        public static bool IsRequestClearCache(HttpContext context = null, string refreshKey = null)
        {
            if (context == null) return false;

            if (context.Request != null && (context.Request.Headers != null && !string.IsNullOrWhiteSpace(context.Request.Headers["User-Agent"].ToString())))
            {
                if (string.IsNullOrEmpty(refreshKey))
                {
                    return context.Request.Headers["User-Agent"].ToString().Contains("refreshcache");
                }
                else
                {
                    return context.Request.Headers["User-Agent"].ToString().Contains(refreshKey);
                }
            }
            return false;
        }
    }
}
