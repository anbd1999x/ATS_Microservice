using Microsoft.AspNetCore.Http;
using NetCore.Core.Caching.Interface;
using NetCore.Core.Utils;
using System.Linq.Expressions;

namespace NetCore.Core.Caching.Impl
{
    public class CacheAppService : ICacheAppService
    {
        private readonly ICached cachedData;
        private readonly IHttpContextAccessor _httpContextAccessor;
        /// <summary>
        /// CacheAppService
        /// </summary>
        /// <param name="cachedData"></param>
        /// <param name="httpContextAccessor"></param>
        public CacheAppService(ICached cachedData, IHttpContextAccessor httpContextAccessor)
        {
            this.cachedData = cachedData;
            _httpContextAccessor = httpContextAccessor;
        }
        /// <summary>
        /// Execute
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="func"></param>
        /// <param name="cachedInMinutes"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public T Execute<T>(Expression<Func<T>> func, int cachedInMinutes, params object[] args)
        {
            var cacheKey = GenerateCacheKey(func, args);

            var obj = cachedData.Get<T>(cacheKey, _httpContextAccessor.HttpContext);

            if (obj == null || EqualityComparer<T>.Default.Equals(obj, default))
            {
                obj = func.Compile()();
                if (!EqualityComparer<T>.Default.Equals(obj, default))
                    cachedData.Add(cacheKey, obj, cachedInMinutes);
            }

            return obj;
        }
        /// <summary>
        /// ExecuteAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="func"></param>
        /// <param name="cachedInMinutes"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task<T> ExecuteAsync<T>(Expression<Func<Task<T>>> func, int cachedInMinutes = -1, params object[] args)
        {
            var cacheKey = GenerateCacheKey(func, args);
            var obj = await cachedData.GetAsync<T>(cacheKey, _httpContextAccessor.HttpContext);

            if (obj != null && !EqualityComparer<T>.Default.Equals(obj, default)) return obj;
            obj = await func.Compile()();
            if (!EqualityComparer<T>.Default.Equals(obj, default))
                await cachedData.AddAsync(cacheKey, obj, cachedInMinutes);

            return obj;
        }
        /// <summary>
        /// Remove
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="func"></param>
        /// <param name="args"></param>
        public void Remove<T>(Expression<Func<T>> func, params object[] args)
        {
            var cacheKey = GenerateCacheKey(func, args);
            cachedData.Remove(cacheKey);
        }
        /// <summary>
        /// RemoveAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="func"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task RemoveAsync<T>(Expression<Func<T>> func, params object[] args)
        {
            var cacheKey = GenerateCacheKey(func, args);
            await cachedData.RemoveAsync(cacheKey);
        }
        /// <summary>
        /// GenerateCacheKey
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="func"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private string GenerateCacheKey<T>(Expression<Func<T>> func, object args)
        {
            var declaringClassName = "ClassName";
            var methodName = "MethodName";

            if (func.Body is MethodCallExpression methodCall)
            {
                methodName = methodCall.Method.Name;
                declaringClassName = methodCall.Method.DeclaringType.Name;
            }

            var cacheKey = string.Format("{0}-{1}:{2}-{3}",
                StaticVariable.CachePrefix,
                declaringClassName,
                methodName,
                args == null ? string.Empty : StringUtils.CalculateMD5Hash(NewtonJson.Serialize(args))
            );
            return cacheKey;
        }
    }
}
