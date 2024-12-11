using Microsoft.AspNetCore.Http;
using NetCore.Core.Caching.Interface;

namespace NetCore.Core.Caching.Impl
{
    public class NoCached : ICached
    {
        /// <summary>
        /// Add
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="item"></param>
        /// <param name="expireInMinute"></param>
        /// <returns></returns>
        public bool Add<T>(string key, T item, int expireInMinute = 0)
        {
            return false;
        }
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="key"></param>
        /// <param name="item"></param>
        /// <param name="expireInMinute"></param>
        /// <returns></returns>
        public bool Add(string key, string item, int expireInMinute = 0)
        {
            return false;
        }
        /// <summary>
        /// AddAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="item"></param>
        /// <param name="expireInMinute"></param>
        /// <returns></returns>
        public Task<bool> AddAsync<T>(string key, T item, int expireInMinute = 0)
        {
            return Task.FromResult(false);
        }
        /// <summary>
        /// AddAsync
        /// </summary>
        /// <param name="key"></param>
        /// <param name="item"></param>
        /// <param name="expireInMinute"></param>
        /// <returns></returns>
        public Task<bool> AddAsync(string key, string item, int expireInMinute = 0)
        {
            return Task.FromResult(false);
        }
        /// <summary>
        /// DeleteKeys
        /// </summary>
        /// <param name="patern"></param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool DeleteKeys(string patern)
        {
            throw new System.NotImplementedException();
        }
        /// <summary>
        /// Get
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="context"></param>
        /// <param name="refreshKey"></param>
        /// <returns></returns>
        public T Get<T>(string key, HttpContext context = null, string refreshKey = null)
        {
            return default;
        }
        /// <summary>
        /// Get
        /// </summary>
        /// <param name="key"></param>
        /// <param name="context"></param>
        /// <param name="refreshKey"></param>
        /// <returns></returns>
        public string Get(string key, HttpContext context = null, string refreshKey = null)
        {
            return string.Empty;
        }
        /// <summary>
        /// GetAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="context"></param>
        /// <param name="refreshKey"></param>
        /// <returns></returns>
        public Task<T> GetAsync<T>(string key, HttpContext context = null, string refreshKey = null)
        {
            return Task.FromResult(default(T));
        }
        /// <summary>
        /// GetAsync
        /// </summary>
        /// <param name="key"></param>
        /// <param name="context"></param>
        /// <param name="refreshKey"></param>
        /// <returns></returns>
        public Task<string> GetAsync(string key, HttpContext context = null, string refreshKey = null)
        {
            return Task.FromResult(string.Empty);
        }
        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Remove(string key)
        {
            return false;
        }
        /// <summary>
        /// RemoveAsync
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Task<bool> RemoveAsync(string key)
        {
            return Task.FromResult(false);
        }
        /// <summary>
        /// RemoveWithKeyStartAsync
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Task<bool> RemoveWithKeyStartAsync(string key)
        {
            throw new System.NotImplementedException();
        }
        /// <summary>
        /// SearchKeys
        /// </summary>
        /// <param name="patern"></param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public List<string> SearchKeys(string patern)
        {
            throw new System.NotImplementedException();
        }
    }
}
