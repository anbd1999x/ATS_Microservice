using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Core.Utils
{
    public static class RestsharpUtils
    {
        public async static Task<T> PostAsync<T>(string url, List<KeyValuePair<string, string>> header = null, object body = default, List<KeyValuePair<string, string>> param = null)
        {

            // Cấu hình RestClient
            var options = new RestClientOptions(url)
            {
                ThrowOnAnyError = true,
                MaxTimeout = -1 // Thời gian chờ (10 giây)
            };
            var client = new RestClient(options);

            // Tạo RestRequest
            var request = new RestRequest
            {
                Method = Method.Post 
            };

            if (body != null)
                request.AddJsonBody(body);
            if (header != null)
            {
                foreach (var item in header)
                {
                    request.AddHeader(item.Key, item.Value);
                }
            }
            if (param != null)
            {
                foreach (var item in param)
                {
                    request.AddParameter(item.Key, item.Value);
                }
            }
            var response = await client.ExecuteAsync(request);
            if (!string.IsNullOrEmpty(response.Content))
                return NewtonJson.Deserialize<T>(response.Content);
            else
                return default;
        }

        public static T Post<T>(string url, List<KeyValuePair<string, string>> header = null, object body = default, List<KeyValuePair<string, string>> param = null)
        {
            // Cấu hình RestClient
            var options = new RestClientOptions(url)
            {
                ThrowOnAnyError = true,
                MaxTimeout = -1 // Thời gian chờ (10 giây)
            };
            var client = new RestClient(options);

            // Tạo RestRequest
            var request = new RestRequest
            {
                Method = Method.Post
            };
            if (body != null)
                request.AddJsonBody(body);
            if (header != null)
            {
                foreach (var item in header)
                {
                    request.AddHeader(item.Key, item.Value);
                }
            }
            if (param != null)
            {
                foreach (var item in param)
                {
                    request.AddParameter(item.Key, item.Value);
                }
            }
            var response = client.Execute(request);
            if (!string.IsNullOrEmpty(response.Content))
                return NewtonJson.Deserialize<T>(response.Content);
            else
                return default;
        }

        public static T Get<T>(string url, List<KeyValuePair<string, string>> header = null, List<KeyValuePair<string, string>> param = null)
        {

            // Cấu hình RestClient
            var options = new RestClientOptions(url)
            {
                ThrowOnAnyError = true,
                MaxTimeout = -1 // Thời gian chờ (10 giây)
            };
            var client = new RestClient(options);

            // Tạo RestRequest
            var request = new RestRequest
            {
                Method = Method.Get
            };
            
            if (header != null)
            {
                foreach (var item in header)
                {
                    request.AddHeader(item.Key, item.Value);
                }
            }
            if (param != null)
            {
                foreach (var item in param)
                {
                    request.AddParameter(item.Key, item.Value);
                }
            }
            var response = client.Execute(request);
            if (!string.IsNullOrEmpty(response.Content))
                return NewtonJson.Deserialize<T>(response.Content);
            else
                return default;
        }

        public async static Task<T> GetAsync<T>(string url, List<KeyValuePair<string, string>> header = null, List<KeyValuePair<string, string>> param = null)
        {
            // Cấu hình RestClient
            var options = new RestClientOptions(url)
            {
                ThrowOnAnyError = true,
                MaxTimeout = -1 
            };
            var client = new RestClient(options);

            // Tạo RestRequest
            var request = new RestRequest
            {
                Method = Method.Get 
            };
            if (header != null)
            {
                foreach (var item in header)
                {
                    request.AddHeader(item.Key, item.Value);
                }
            }
            if (param != null)
            {
                foreach (var item in param)
                {
                    request.AddParameter(item.Key, item.Value);
                }
            }
            var response = await client.ExecuteAsync(request);
            if (!string.IsNullOrEmpty(response.Content))
                return NewtonJson.Deserialize<T>(response.Content);
            else
                return default;
        }
    }
}
