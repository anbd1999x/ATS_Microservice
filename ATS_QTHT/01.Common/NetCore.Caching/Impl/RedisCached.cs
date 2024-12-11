using NetCore.Core.Caching.Common;
using NetCore.Core.Caching.Interface;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using NetCore.Core.Utils;
using Microsoft.Extensions.Logging;
using NetCore.Logging;
using System.Text.Json;

namespace NetCore.Core.Caching.Impl
{
    public class RedisCached : ICached, IQueueAndListCached
    {
        protected ConnectionMultiplexer _redisConnection;
        protected Task<ConnectionMultiplexer> _redisConnectionAsync;
        private CachingConfigModel _configuration;
        private ILogger _logger = ApplicationLogManager.CreateLogger<RedisCached>();

        /// <summary>
        /// RedisCached
        /// </summary>
        /// <param name="configuration"></param>
        public RedisCached(CachingConfigModel configuration = null)
        {
            _configuration = configuration;
            var connectionMutiplexer = new ConnectionMultiplexerHelper(configuration);
            _redisConnection = connectionMutiplexer.ConnectionMultipexe;
            _redisConnectionAsync = connectionMutiplexer.ConnectionMultipexeAsync;
        }
        /// <summary>
        /// GetDatabaseInstance
        /// </summary>
        /// <returns></returns>
        private IDatabase GetDatabaseInstance()
        {
            IDatabase client = null;

            try
            {
                client = _redisConnection.GetDatabase(_configuration.Database);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }

            return client;
        }
        /// <summary>
        /// GetDatabaseInstanceForAsync
        /// </summary>
        /// <returns></returns>
        private IDatabase GetDatabaseInstanceForAsync()
        {
            IDatabase client = null;
            try
            {
                client = _redisConnectionAsync.Result.GetDatabase(_configuration.Database);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }

            return client;
        }
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
            try
            {
                IDatabase client = GetDatabaseInstance();

                byte[] bytes = ZipToBytes(item, key);

                DateTime currentTime = DateTime.Now;
                TimeSpan expired = currentTime.AddMinutes(expireInMinute) - currentTime;

                if (expireInMinute > 0)
                    client.StringSet(key, bytes, expiry: expired);
                else
                    client.StringSet(key, bytes);

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return false;
            }
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
            try
            {
                IDatabase client = GetDatabaseInstance();

                byte[] bytes = ZipToBytes(item, key);

                DateTime currentTime = DateTime.Now;
                TimeSpan expired = currentTime.AddMinutes(expireInMinute) - currentTime;

                if (expireInMinute > 0)
                    client.StringSet(key, bytes, expiry: expired, flags: CommandFlags.FireAndForget);
                else
                    client.StringSet(key, bytes, flags: CommandFlags.FireAndForget);

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return false;
            }
        }
        /// <summary>
        /// AddAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="item"></param>
        /// <param name="expireInMinute"></param>
        /// <returns></returns>
        public async Task<bool> AddAsync<T>(string key, T item, int expireInMinute = 0)
        {
            try
            {
                RedisKey redisKey = key;
                RedisValue redisValue = ZipToBytes(item, key);

                DateTime currentTime = DateTime.Now;
                TimeSpan expired = currentTime.AddMinutes(expireInMinute) - currentTime;

                IDatabase client = GetDatabaseInstanceForAsync();
                if (expireInMinute > 0)
                {
                    await client.StringSetAsync(redisKey, redisValue, expiry: expired, flags: CommandFlags.FireAndForget).ConfigureAwait(false);
                }
                else
                    await client.StringSetAsync(redisKey, redisValue, flags: CommandFlags.FireAndForget).ConfigureAwait(false);

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return false;
            }
        }
        /// <summary>
        /// AddAsync
        /// </summary>
        /// <param name="key"></param>
        /// <param name="item"></param>
        /// <param name="expireInMinute"></param>
        /// <returns></returns>
        public async Task<bool> AddAsync(string key, string item, int expireInMinute = 0)
        {
            try
            {
                RedisKey redisKey = key;
                RedisValue redisValue = ZipToBytes(item, key);

                DateTime currentTime = DateTime.Now;
                TimeSpan expired = currentTime.AddMinutes(expireInMinute) - currentTime;

                IDatabase client = GetDatabaseInstanceForAsync();
                if (expireInMinute > 0)
                {
                    await client.StringSetAsync(redisKey, redisValue, expiry: expired, flags: CommandFlags.FireAndForget).ConfigureAwait(false);
                }
                else
                    await client.StringSetAsync(redisKey, redisValue, flags: CommandFlags.FireAndForget).ConfigureAwait(false);

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return false;
            }
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
            T result = default;
            try
            {
                IDatabase client = GetDatabaseInstance();

                if (CacheHelpers.IsRequestClearCache(context))
                {
                    client.KeyDelete(key);
                }

                byte[] redisValue = client.StringGet(key);

                result = UnZipFromBytes<T>(redisValue);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
            return result;
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
            string result = string.Empty;
            try
            {
                IDatabase client = GetDatabaseInstance();

                if (CacheHelpers.IsRequestClearCache(context))
                {
                    client.KeyDelete(key);
                }

                byte[] redisValue = client.StringGet(key);

                //result = redisValue == null ? null : Unzip(redisValue);
                result = UnZipFromBytes<string>(redisValue);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
            return result;
        }
        /// <summary>
        /// GetAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="context"></param>
        /// <param name="refreshKey"></param>
        /// <returns></returns>
        public async Task<T> GetAsync<T>(string key, HttpContext context = null, string refreshKey = null)
        {
            T result = default;
            try
            {
                IDatabase client = GetDatabaseInstanceForAsync();

                if (CacheHelpers.IsRequestClearCache(context, refreshKey))
                {
                    client.KeyDelete(key);
                }

                byte[] bytes = await client.StringGetAsync(key);
                result = UnZipFromBytes<T>(bytes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Task
        /// </summary>
        /// <param name="key"></param>
        /// <param name="context"></param>
        /// <param name="refreshKey"></param>
        /// <returns></returns>
        public async Task<string> GetAsync(string key, HttpContext context = null, string refreshKey = null)
        {
            string result = string.Empty;
            try
            {
                IDatabase client = GetDatabaseInstanceForAsync();

                if (CacheHelpers.IsRequestClearCache(context, refreshKey))
                {
                    client.KeyDelete(key);
                }

                byte[] redisValue = await client.StringGetAsync(key);

                result = UnZipFromBytes<string>(redisValue);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Remove(string key)
        {
            bool result = false;

            try
            {
                IDatabase client = GetDatabaseInstance();

                result = client.KeyDelete(key);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }

            return result;
        }
        /// <summary>
        /// RemoveAsync
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<bool> RemoveAsync(string key)
        {
            bool result = false;

            try
            {
                IDatabase client = GetDatabaseInstanceForAsync();

                result = await client.KeyDeleteAsync(key);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }

            return result;
        }
        /// <summary>
        /// RemoveWithKeyStartAsync
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<bool> RemoveWithKeyStartAsync(string key)
        {
            bool result = false;

            try
            {
                var server = _redisConnection.GetServer(_redisConnection.GetEndPoints().First());
                if (server != null)
                {
                    List<Task> tasks = new List<Task>();
                    foreach (var item in server.Keys(pattern: $"{key}:*"))
                    {
                        tasks.Add(Task.Run(() => RemoveAsync(item)));
                    }
                    await Task.WhenAll(tasks);
                    result = true;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }

            return result;
        }
        /// <summary>
        /// ZipToBytes
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private byte[] ZipToBytes<T>(T item, string key)
        {
            if (item == null || item.Equals(default(T)))
                return null;

            string jsonString = JsonSerializer.Serialize(item);

            // Convert JSON string to byte array (UTF-8 encoding)
            return Encoding.UTF8.GetBytes(jsonString);
        }
        /// <summary>
        /// UnZipFromBytes
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="bytes"></param>
        /// <returns></returns>
        private T UnZipFromBytes<T>(byte[] bytes)
        {
            if (bytes == null || bytes.Length <= 0)
                return default;

            var jsonString = Encoding.UTF8.GetString(bytes);
            return JsonSerializer.Deserialize<T>(jsonString);
        }
        /// <summary>
        /// CopyTo
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dest"></param>
        private void CopyTo(Stream src, Stream dest)
        {
            var bytes = new byte[8096];

            int cnt;

            while ((cnt = src.Read(bytes, 0, bytes.Length)) != 0) dest.Write(bytes, 0, cnt);
        }
        /// <summary>
        /// Unzip
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        private string Unzip(byte[] bytes)
        {
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(msi, CompressionMode.Decompress))
                {
                    //gs.CopyTo(mso);
                    CopyTo(gs, mso);
                }

                return Encoding.UTF8.GetString(mso.ToArray());
            }
        }

        //Queue
        /// <summary>
        /// DeQueue
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string DeQueue(string key)
        {
            try
            {
                IDatabase client = GetDatabaseInstance();

                RedisValue valueFromSortedSet = client.ListRightPop(key);

                return valueFromSortedSet;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return string.Empty;
            }
        }
        /// <summary>
        /// DeQueue
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public T DeQueue<T>(string key)
        {
            try
            {
                string value = DeQueue(key);
                if (!string.IsNullOrEmpty(value))
                {
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(value);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }

            return default;
        }
        /// <summary>
        /// DeQueueAsync
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<string> DeQueueAsync(string key)
        {
            try
            {

                IDatabase client = GetDatabaseInstanceForAsync();
                return await client.ListRightPopAsync(key);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, ex.Message);
                return string.Empty;
            }
        }
        /// <summary>
        /// DeQueueAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<T> DeQueueAsync<T>(string key)
        {
            try
            {
                string value = await DeQueueAsync(key);

                if (!string.IsNullOrEmpty(value))
                {
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(value);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }

            return default;
        }
        /// <summary>
        /// EnQueue
        /// </summary>
        /// <param name="key"></param>
        /// <param name="item"></param>
        public void EnQueue(string key, string item)
        {
            try
            {
                //if (score <= 0) score = Utils.DateTimeToUnixTime(DateTime.Now);

                IDatabase client = GetDatabaseInstance();

                client.ListLeftPush(key, item);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
        }
        /// <summary>
        /// EnQueueAsync
        /// </summary>
        /// <param name="key"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task EnQueueAsync(string key, string item)
        {
            try
            {
                //if (score <= 0) score = Utils.DateTimeToUnixTime(DateTime.Now);

                string value = NewtonJson.Serialize(item);

                IDatabase client = GetDatabaseInstanceForAsync();

                await client.ListLeftPushAsync(key, value);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
        }
        /// <summary>
        /// SearchKeys
        /// </summary>
        /// <param name="patern"></param>
        /// <returns></returns>
        public List<string> SearchKeys(string patern)
        {
            List<string> lstRet = new List<string>();
            try
            {
                foreach (var endpoint in _redisConnection.GetEndPoints())
                {
                    var server = _redisConnection.GetServer(endpoint);
                    foreach (var key in server.Keys(pattern: patern))
                    {
                        lstRet.Add(key.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return lstRet;
        }
        /// <summary>
        ///DeleteKeys
        /// </summary>
        /// <param name="patern"></param>
        /// <returns></returns>
        public bool DeleteKeys(string patern)
        {
            bool frag = false;
            try
            {
                foreach (var endpoint in _redisConnection.GetEndPoints())
                {
                    var server = _redisConnection.GetServer(endpoint);
                    foreach (var key in server.Keys(pattern: patern))
                    {
                        frag = _redisConnection.GetDatabase(_configuration.Database).KeyDelete(key);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return frag;
        }
    }
}