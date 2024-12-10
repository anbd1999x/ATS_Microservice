using Microsoft.AspNetCore.Http;
using NetCore.Core.Caching.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetCore.Core.Caching.Impl
{
    public class NoCached : ICached
    {
        public bool Add<T>(string key, T item, int expireInMinute = 0)
        {
            return false;
        }

        public bool Add(string key, string item, int expireInMinute = 0)
        {
            return false;
        }

        public Task<bool> AddAsync<T>(string key, T item, int expireInMinute = 0)
        {
            return Task.FromResult(false);
        }

        public Task<bool> AddAsync(string key, string item, int expireInMinute = 0)
        {
            return Task.FromResult(false);
        }

        public bool DeleteKeys(string patern)
        {
            throw new System.NotImplementedException();
        }

        public T Get<T>(string key, HttpContext context = null, string refreshKey = null)
        {
            return default;
        }

        public string Get(string key, HttpContext context = null, string refreshKey = null)
        {
            return string.Empty;
        }

        public Task<T> GetAsync<T>(string key, HttpContext context = null, string refreshKey = null)
        {
            return Task.FromResult(default(T));
        }

        public Task<string> GetAsync(string key, HttpContext context = null, string refreshKey = null)
        {
            return Task.FromResult(string.Empty);
        }

        public bool Remove(string key)
        {
            return false;
        }

        public Task<bool> RemoveAsync(string key)
        {
            return Task.FromResult(false);
        }

        public Task<bool> RemoveWithKeyStartAsync(string key)
        {
            throw new System.NotImplementedException();
        }

        public List<string> SearchKeys(string patern)
        {
            throw new System.NotImplementedException();
        }
    }
}
