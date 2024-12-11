using NetCore.Core.Caching.Interface;

namespace NetCore.Core.Caching.Impl
{
    public class NoCacheQueue : IQueueAndListCached
    {
        /// <summary>
        /// DeQueue
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string DeQueue(string key)
        {
            return string.Empty;
        }
        /// <summary>
        /// DeQueue
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public T DeQueue<T>(string key)
        {
            return default;
        }
        /// <summary>
        /// DeQueueAsync
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Task<string> DeQueueAsync(string key)
        {
            return Task.FromResult(string.Empty);
        }
        /// <summary>
        /// DeQueueAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public Task<T> DeQueueAsync<T>(string key)
        {
            return Task.FromResult(default(T));
        }
        /// <summary>
        /// EnQueue
        /// </summary>
        /// <param name="key"></param>
        /// <param name="item"></param>

        public void EnQueue(string key, string item)
        {
            return;
        }
        /// <summary>
        /// EnQueueAsync
        /// </summary>
        /// <param name="key"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public Task EnQueueAsync(string key, string item)
        {
            return Task.FromResult(0);
        }
    }
}
