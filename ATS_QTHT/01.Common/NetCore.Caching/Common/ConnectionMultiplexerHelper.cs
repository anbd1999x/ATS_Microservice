using StackExchange.Redis;

namespace NetCore.Core.Caching.Common
{
    public class ConnectionMultiplexerHelper
    {
        public ConnectionMultiplexer ConnectionMultipexe;
        public Task<ConnectionMultiplexer> ConnectionMultipexeAsync;
        /// <summary>
        /// ConnectionMultiplexerHelper
        /// </summary>
        /// <param name="configuration"></param>
        public ConnectionMultiplexerHelper(CachingConfigModel configuration)
        {
            SetConnectionMutlplexer(configuration, configuration.ServerList);
        }
        /// <summary>
        /// SetConnectionMutlplexer
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="redisHosts"></param>
        /// <exception cref="ArgumentNullException"></exception>
        private void SetConnectionMutlplexer(CachingConfigModel configuration, List<RedisHostModel> redisHosts)
        {
            if (configuration == null || redisHosts == null)
            {
                throw new ArgumentNullException("Redis server is null");
            }
            ConfigurationOptions config = new ConfigurationOptions
            {
                DefaultDatabase = configuration.Database,
                SyncTimeout = configuration.Timeout,
                //AsyncTimeout = configuration.Timeout / 2,
                ClientName = configuration.Name,
                AbortOnConnectFail = false,
                ConnectRetry = 3,
                KeepAlive = 20,
                Password = configuration.Password,
                AllowAdmin = true
            };
            foreach (var item in redisHosts)
            {
                config.EndPoints.Add(item.Host, item.Port);
            }
            config.CommandMap = CommandMap.Create(new HashSet<string>
            { // EXCLUDE a few commands
                "INFO", "CONFIG", "CLUSTER",
                "PING", "ECHO", "CLIENT"
            }, available: false);
            ConnectionMultipexe = new Lazy<ConnectionMultiplexer>(() => ConnectionMultiplexer.Connect(config)).Value;
            ConnectionMultipexeAsync = new Lazy<Task<ConnectionMultiplexer>>(() => ConnectionMultiplexer.ConnectAsync(config)).Value;
        }
    }
}
