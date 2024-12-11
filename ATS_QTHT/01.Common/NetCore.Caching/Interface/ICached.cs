using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetCore.Core.Caching.Interface
{
    /// <summary>
    /// ICached
    /// </summary>
    public interface ICached
    {
        bool Add<T>(string key, T item, int expireInMinute = 0);
        bool Add(string key, string item, int expireInMinute = 0);

        Task<bool> AddAsync<T>(string key, T item, int expireInMinute = 0);

        Task<bool> AddAsync(string key, string item, int expireInMinute = 0);

        T Get<T>(string key, HttpContext context = null, string refreshKey = null);
        string Get(string key, HttpContext context = null, string refreshKey = null);

        Task<T> GetAsync<T>(string key, HttpContext context = null, string refreshKey = null);

        Task<string> GetAsync(string key, HttpContext context = null, string refreshKey = null);

        bool Remove(string key);
        Task<bool> RemoveAsync(string key);
        Task<bool> RemoveWithKeyStartAsync(string key);
        List<string> SearchKeys(string patern);
        bool DeleteKeys(string patern);
    }
}
