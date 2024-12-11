using NetCore.Core.Utils;
using Polly;
using Polly.Retry;
using System.Text;

namespace NetCore.Core.Base
{
    public abstract class BaseHttpClientFactory
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string serviceName;
        private readonly AsyncRetryPolicy<HttpResponseMessage> _retryPolicy;
        /// <summary>
        /// BaseHttpClientFactory
        /// </summary>
        /// <param name="httpClientFactory"></param>
        /// <param name="serviceName"></param>
        /// <param name="retry"></param>
        public BaseHttpClientFactory(IHttpClientFactory httpClientFactory, string serviceName, int retry = 3)
        {
            _httpClientFactory = httpClientFactory;
            this.serviceName = serviceName;
            _retryPolicy = Policy.HandleResult<HttpResponseMessage>(r => !r.IsSuccessStatusCode)
                                 .RetryAsync(retry);
        }
        /// <summary>
        /// CreateHttpClient
        /// </summary>
        /// <returns></returns>
        public virtual HttpClient CreateHttpClient()
        {
            var httpClient = _httpClientFactory.CreateClient(serviceName);
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            return httpClient;
        }
        /// <summary>
        /// CreateHttpClient
        /// </summary>
        /// <param name="withAuthen"></param>
        /// <returns></returns>
        public HttpClient CreateHttpClient(bool withAuthen)
        {
            if (withAuthen)
                return CreateHttpClientWithAuthen();
            return CreateHttpClient();
        }
        /// <summary>
        /// CreateHttpClientWithAuthen
        /// </summary>
        /// <returns></returns>
        public abstract HttpClient CreateHttpClientWithAuthen();
        /// <summary>
        /// GetAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="endpoint"></param>
        /// <param name="withAuthen"></param>
        /// <returns></returns>
        public virtual async Task<ResultHttp<T, string>> GetAsync<T>(string endpoint, bool withAuthen = false)
        {
            ResultHttp<T, string> resultHttp = new ResultHttp<T, string>();
            using (HttpClient client = CreateHttpClient(withAuthen))
            {
                var response = await _retryPolicy.ExecuteAsync(() => client.GetAsync(endpoint));
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    resultHttp.Data = NewtonJson.Deserialize<T>(result);
                    resultHttp.Success = true;
                    return resultHttp;
                }
                else
                {
                    string result = await response.Content.ReadAsStringAsync();
                    resultHttp.Error = result;
                    resultHttp.Success = false;
                    return resultHttp;
                }
            }

        }
        /// <summary>
        /// PostAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="endpoint"></param>
        /// <param name="content"></param>
        /// <param name="withAuthen"></param>
        /// <returns></returns>
        public virtual async Task<ResultHttp<T, string>> PostAsync<T>(string endpoint, HttpContent content, bool withAuthen = false)
        {
            ResultHttp<T, string> resultHttp = new ResultHttp<T, string>();
            using (HttpClient client = CreateHttpClient(withAuthen))
            {
                var response = await _retryPolicy.ExecuteAsync(() => client.PostAsync(endpoint, content));
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    resultHttp.Data = NewtonJson.Deserialize<T>(result);
                    resultHttp.Success = true;
                    return resultHttp;
                }
                else
                {
                    string result = await response.Content.ReadAsStringAsync();
                    resultHttp.Error = result;
                    resultHttp.Success = false;
                    return resultHttp;
                }
            }
        }

        /// <summary>
        /// PostAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="endpoint"></param>
        /// <param name="data"></param>
        /// <param name="withAuthen"></param>
        /// <returns></returns>
        public async Task<ResultHttp<T, string>> PostAsync<T>(string endpoint, object data = null, bool withAuthen = false)
        {
            ResultHttp<T, string> resultHttp = new ResultHttp<T, string>();
            using (HttpClient client = CreateHttpClient(withAuthen))
            {
                HttpContent content = null;
                if (data != null)
                {
                    content = new StringContent(NewtonJson.Serialize(data), Encoding.UTF8, "application/json");
                }
                var response = await _retryPolicy.ExecuteAsync(() => client.PostAsync(endpoint, content));
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    resultHttp.Data = NewtonJson.Deserialize<T>(result);
                    resultHttp.Success = true;
                    return resultHttp;
                }
                else
                {
                    string result = await response.Content.ReadAsStringAsync();
                    resultHttp.Error = result;
                    resultHttp.Success = false;
                    return resultHttp;
                }
            }
        }
        /// <summary>
        /// GetAsync
        /// </summary>
        /// <typeparam name="TSuccess"></typeparam>
        /// <typeparam name="TFalse"></typeparam>
        /// <param name="endpoint"></param>
        /// <param name="withAuthen"></param>
        /// <returns></returns>
        public virtual async Task<ResultHttp<TSuccess, TFalse>> GetAsync<TSuccess, TFalse>(string endpoint, bool withAuthen = false)
        {
            ResultHttp<TSuccess, TFalse> resultHttp = new ResultHttp<TSuccess, TFalse>();
            using (HttpClient client = CreateHttpClient(withAuthen))
            {
                var response = await _retryPolicy.ExecuteAsync(() => client.GetAsync(endpoint));
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    resultHttp.Data = NewtonJson.Deserialize<TSuccess>(result);
                    resultHttp.Success = true;
                    return resultHttp;
                }
                else
                {
                    string result = await response.Content.ReadAsStringAsync();
                    resultHttp.Error = NewtonJson.Deserialize<TFalse>(result);
                    resultHttp.Success = false;
                    return resultHttp;
                }
            }

        }

        /// <summary>
        /// PostAsync
        /// </summary>
        /// <typeparam name="TSuccess"></typeparam>
        /// <typeparam name="TFalse"></typeparam>
        /// <param name="endpoint"></param>
        /// <param name="content"></param>
        /// <param name="withAuthen"></param>
        /// <returns></returns>
        public virtual async Task<ResultHttp<TSuccess, TFalse>> PostAsync<TSuccess, TFalse>(string endpoint, HttpContent content, bool withAuthen = false)
        {
            ResultHttp<TSuccess, TFalse> resultHttp = new ResultHttp<TSuccess, TFalse>();
            using (HttpClient client = CreateHttpClient(withAuthen))
            {
                var response = await _retryPolicy.ExecuteAsync(() => client.PostAsync(endpoint, content));
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    resultHttp.Data = NewtonJson.Deserialize<TSuccess>(result);
                    resultHttp.Success = true;
                    return resultHttp;
                }
                else
                {
                    string result = await response.Content.ReadAsStringAsync();
                    resultHttp.Error = NewtonJson.Deserialize<TFalse>(result);
                    resultHttp.Success = false;
                    return resultHttp;
                }
            }
        }

        /// <summary>
        /// PostAsync
        /// </summary>
        /// <typeparam name="TSuccess"></typeparam>
        /// <typeparam name="TFalse"></typeparam>
        /// <param name="endpoint"></param>
        /// <param name="data"></param>
        /// <param name="withAuthen"></param>
        /// <returns></returns>
        public async Task<ResultHttp<TSuccess, TFalse>> PostAsync<TSuccess, TFalse>(string endpoint, object data = null, bool withAuthen = false)
        {
            ResultHttp<TSuccess, TFalse> resultHttp = new ResultHttp<TSuccess, TFalse>();
            using (HttpClient client = CreateHttpClient(withAuthen))
            {
                HttpContent content = null;
                if (data != null)
                {
                    content = new StringContent(NewtonJson.Serialize(data), Encoding.UTF8, "application/json");
                }
                var response = await _retryPolicy.ExecuteAsync(() => client.PostAsync(endpoint, content));
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    resultHttp.Data = NewtonJson.Deserialize<TSuccess>(result);
                    resultHttp.Success = true;
                    return resultHttp;
                }
                else
                {
                    string result = await response.Content.ReadAsStringAsync();
                    resultHttp.Error = NewtonJson.Deserialize<TFalse>(result);
                    resultHttp.Success = false;
                    return resultHttp;
                }
            }
        }
    }
    public class ResultHttp<TSuccess, TFalse>
    {
        public bool Success { get; set; }

        public TSuccess Data { get; set; }

        public TFalse Error { get; set; }
    }

}
