using NetCore.Core.Utils;

namespace NetCore.Core.Caching.Common
{
    public static class KeyCacheHelper
    {
        private static readonly string _prefixKey = StaticVariable.CachePrefix;
        private static readonly string separator = ":";
        public struct ObjectKey
        {
            public object Input { get; set; }
            public bool IsSerialize { get; set; }
        }
        /// <summary>
        /// GenCacheKey
        /// </summary>
        /// <param name="cacheName"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string GenCacheKey(string cacheName, params object[] args)
        {
            string cacheKey = $"{_prefixKey}{separator}{cacheName}";

            if (args != null && args.Length > 0)
            {
                string keyComplex = args.Aggregate(cacheKey, (current, param) => Aggregate(current, param));
                cacheKey = string.Concat(cacheKey, separator, StringUtils.CalculateMD5Hash(keyComplex));
            }

            return cacheKey;
        }
        /// <summary>
        /// Aggregate
        /// </summary>
        /// <param name="current"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        private static string Aggregate(string current, object param)
        {
            var paramSerialize = NewtonJson.Serialize(param);
            current = current + separator + EncodeObject(paramSerialize);
            return current;
        }
        /// <summary>
        /// EncodeObject
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private static string EncodeObject(object obj)
        {
            if (obj == null) return string.Empty;
            return StringUtils.CalculateMD5Hash(NewtonJson.Serialize(obj));
        }
    }
}
