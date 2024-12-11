using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using NetCore.Core.Utils;
using System.Net.Http.Headers;
using System.Text;

namespace NetCore.Core.Helper
{
    public class HttpHelper : IHttpHelper
    {
        private HttpClient _client;
        private IHttpContextAccessor _httpContextAccessor;

        public HttpHelper(HttpClient client, IHttpContextAccessor httpContextAccessor)
        {
            _client = client;
            _httpContextAccessor = httpContextAccessor;
        }
        /// <summary>
        /// GetAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <returns></returns>
        public async Task<T> GetAsync<T>(string url)
        {
            Dictionary<string, string> lstHeaderParams = new Dictionary<string, string>();
            StringValues token = string.Empty;
            var accessToken = string.Empty;
            StringValues operatingSystem = string.Empty;
            StringValues geoLocation = string.Empty;
            _httpContextAccessor.HttpContext.Request.Headers.TryGetValue("Authorization", out token);
            _httpContextAccessor.HttpContext.Request.Headers.TryGetValue("operating-system", out operatingSystem);
            _httpContextAccessor.HttpContext.Request.Headers.TryGetValue("geo-location", out geoLocation);
            if (!string.IsNullOrEmpty(token))
            {
                accessToken = token.ToString().StartsWith("Bearer ") ? token.ToString().Substring(7) : token.ToString();
                lstHeaderParams.Add("Authorization", accessToken);
                _client.DefaultRequestHeaders.Remove("Authorization");
                _client.DefaultRequestHeaders.Add("Authorization", accessToken);
            }
            if (!string.IsNullOrEmpty(operatingSystem))
            {
                lstHeaderParams.Add("operating-system", operatingSystem.ToString());
                _client.DefaultRequestHeaders.Add("operating-system", operatingSystem.ToString());
            }
            if (!string.IsNullOrEmpty(geoLocation))
            {
                lstHeaderParams.Add("geo-location", geoLocation.ToString());
                _client.DefaultRequestHeaders.Add("geo-location", geoLocation.ToString());
            }
            var response = await _client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                return NewtonJson.Deserialize<T>(content);
            }
            else
            {
                return default;
            }
        }
        /// <summary>
        /// GetAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public async Task<T> GetAsync<T>(string url, string accessToken)
        {
            Dictionary<string, string> lstHeaderParams = new Dictionary<string, string>();
            StringValues operatingSystem = string.Empty;
            StringValues geoLocation = string.Empty;
            _httpContextAccessor.HttpContext.Request.Headers.TryGetValue("operating-system", out operatingSystem);
            _httpContextAccessor.HttpContext.Request.Headers.TryGetValue("geo-location", out geoLocation);
            if (!string.IsNullOrEmpty(accessToken))
            {
                accessToken = accessToken.ToString().StartsWith("Bearer ") ? accessToken.ToString().Substring(7) : accessToken.ToString();
                lstHeaderParams.Add("Authorization", accessToken);
                _client.DefaultRequestHeaders.Remove("Authorization");
                _client.DefaultRequestHeaders.Add("Authorization", accessToken);
            }
            if (!string.IsNullOrEmpty(operatingSystem))
            {
                lstHeaderParams.Add("operating-system", operatingSystem.ToString());
                _client.DefaultRequestHeaders.Add("operating-system", operatingSystem.ToString());
            }
            if (!string.IsNullOrEmpty(geoLocation))
            {
                lstHeaderParams.Add("geo-location", geoLocation.ToString());
                _client.DefaultRequestHeaders.Add("geo-location", geoLocation.ToString());
            }
            var response = await _client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                return NewtonJson.Deserialize<T>(content);
            }
            else
            {
                return default;
            }
        }
        /// <summary>
        /// PostAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<T> PostAsync<T>(string url, object data = null)
        {
            Dictionary<string, string> lstHeaderParams = new Dictionary<string, string>();
            StringValues token = string.Empty;
            var accessToken = string.Empty;
            StringValues operatingSystem = string.Empty;
            StringValues geoLocation = string.Empty;
            _httpContextAccessor.HttpContext.Request.Headers.TryGetValue("Authorization", out token);
            _httpContextAccessor.HttpContext.Request.Headers.TryGetValue("operating-system", out operatingSystem);
            _httpContextAccessor.HttpContext.Request.Headers.TryGetValue("geo-location", out geoLocation);
            if (!string.IsNullOrEmpty(token))
            {
                accessToken = token.ToString().StartsWith("Bearer ") ? token.ToString().Substring(7) : token.ToString();
                lstHeaderParams.Add("Authorization", accessToken);
                _client.DefaultRequestHeaders.Remove("Authorization");
                _client.DefaultRequestHeaders.Add("Authorization", accessToken);
            }
            if (!string.IsNullOrEmpty(operatingSystem))
            {
                lstHeaderParams.Add("operating-system", operatingSystem.ToString());
                _client.DefaultRequestHeaders.Add("operating-system", operatingSystem.ToString());
            }
            if (!string.IsNullOrEmpty(geoLocation))
            {
                lstHeaderParams.Add("geo-location", geoLocation.ToString());
                _client.DefaultRequestHeaders.Add("geo-location", geoLocation.ToString());
            }
            if (data != null)
            {
                var json = NewtonJson.Serialize(data);
                var dataPost = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _client.PostAsync(url, dataPost);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    return NewtonJson.Deserialize<T>(content);
                }
                else
                {
                    return default;
                }
            }
            else
            {
                var response = await _client.PostAsync(url, null);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    return NewtonJson.Deserialize<T>(content);
                }
                else
                {
                    return default;
                }
            }
        }
        /// <summary>
        /// PostFileAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <param name="file"></param>
        /// <returns></returns>
        public async Task<T> PostFileAsync<T>(string url, object data = null, IFormFile file = null)
        {
            Dictionary<string, string> lstHeaderParams = new Dictionary<string, string>();
            StringValues token = string.Empty;
            var accessToken = string.Empty;
            StringValues operatingSystem = string.Empty;
            StringValues geoLocation = string.Empty;
            _httpContextAccessor.HttpContext.Request.Headers.TryGetValue("Authorization", out token);
            _httpContextAccessor.HttpContext.Request.Headers.TryGetValue("operating-system", out operatingSystem);
            _httpContextAccessor.HttpContext.Request.Headers.TryGetValue("geo-location", out geoLocation);
            if (!string.IsNullOrEmpty(token))
            {
                accessToken = token.ToString().StartsWith("Bearer ") ? token.ToString().Substring(7) : token.ToString();
                lstHeaderParams.Add("Authorization", accessToken);
                _client.DefaultRequestHeaders.Remove("Authorization");
                _client.DefaultRequestHeaders.Add("Authorization", accessToken);
            }
            if (!string.IsNullOrEmpty(operatingSystem))
            {
                lstHeaderParams.Add("operating-system", operatingSystem.ToString());
                _client.DefaultRequestHeaders.Add("operating-system", operatingSystem.ToString());
            }
            if (!string.IsNullOrEmpty(geoLocation))
            {
                lstHeaderParams.Add("geo-location", geoLocation.ToString());
                _client.DefaultRequestHeaders.Add("geo-location", geoLocation.ToString());
            }
            if (data != null)
            {
                //var json = NewtonJson.Serialize(data);
                var dataPost = new MultipartFormDataContent();
                foreach (var item in data.GetType().GetProperties())
                {
                    var itemData = item.GetValue(data, null);
                    if (itemData is IFormFile)
                    {
                        var fileData = ((IFormFile)item.GetValue(data, null));
                        var stream = fileData.OpenReadStream();
                        dataPost.Add(new StreamContent(stream), fileData.Name, fileData.FileName);
                    }
                    if (itemData is Stream)
                    {
                        var fileData = ((Stream)item.GetValue(data, null));
                        dataPost.Add(new StreamContent(fileData), "FileStream", "test.zip");
                    }
                    dataPost.Add(new StringContent(itemData == null ? string.Empty : itemData.ToString()), item.Name);
                }
                var response = await _client.PostAsync(url, dataPost);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    return NewtonJson.Deserialize<T>(content);
                }
                else
                {
                    return default;
                }
            }
            else
            {
                var response = await _client.PostAsync(url, null);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    return NewtonJson.Deserialize<T>(content);
                }
                else
                {
                    return default;
                }
            }
        }
        /// <summary>
        /// PutAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<T> PutAsync<T>(string url, object data = null)
        {
            Dictionary<string, string> lstHeaderParams = new Dictionary<string, string>();
            StringValues token = string.Empty;
            var accessToken = string.Empty;
            StringValues operatingSystem = string.Empty;
            StringValues geoLocation = string.Empty;
            _httpContextAccessor.HttpContext.Request.Headers.TryGetValue("Authorization", out token);
            _httpContextAccessor.HttpContext.Request.Headers.TryGetValue("operating-system", out operatingSystem);
            _httpContextAccessor.HttpContext.Request.Headers.TryGetValue("geo-location", out geoLocation);
            if (!string.IsNullOrEmpty(token))
            {
                accessToken = token.ToString().StartsWith("Bearer ") ? token.ToString().Substring(7) : token.ToString();
                lstHeaderParams.Add("Authorization", accessToken);
                _client.DefaultRequestHeaders.Add("Authorization", accessToken);
            }
            if (!string.IsNullOrEmpty(operatingSystem))
            {
                lstHeaderParams.Add("operating-system", operatingSystem.ToString());
                _client.DefaultRequestHeaders.Add("operating-system", operatingSystem.ToString());
            }
            if (!string.IsNullOrEmpty(geoLocation))
            {
                lstHeaderParams.Add("geo-location", geoLocation.ToString());
                _client.DefaultRequestHeaders.Add("geo-location", geoLocation.ToString());
            }
            if (data != null)
            {
                var json = NewtonJson.Serialize(data);
                var dataPut = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _client.PutAsync(url, dataPut);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    return NewtonJson.Deserialize<T>(content);
                }
                else
                {
                    return default;
                }
            }
            else
            {
                var response = await _client.PutAsync(url, null);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    return NewtonJson.Deserialize<T>(content);
                }
                else
                {
                    return default;
                }
            }
        }
        /// <summary>
        /// DeleteAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <returns></returns>
        public async Task<T> DeleteAsync<T>(string url)
        {
            Dictionary<string, string> lstHeaderParams = new Dictionary<string, string>();
            StringValues token = string.Empty;
            var accessToken = string.Empty;
            StringValues operatingSystem = string.Empty;
            StringValues geoLocation = string.Empty;
            _httpContextAccessor.HttpContext.Request.Headers.TryGetValue("Authorization", out token);
            _httpContextAccessor.HttpContext.Request.Headers.TryGetValue("operating-system", out operatingSystem);
            _httpContextAccessor.HttpContext.Request.Headers.TryGetValue("geo-location", out geoLocation);
            if (!string.IsNullOrEmpty(token))
            {
                accessToken = token.ToString().StartsWith("Bearer ") ? token.ToString().Substring(7) : token.ToString();
                lstHeaderParams.Add("Authorization", accessToken);
                _client.DefaultRequestHeaders.Add("Authorization", accessToken);
            }
            if (!string.IsNullOrEmpty(operatingSystem))
            {
                lstHeaderParams.Add("operating-system", operatingSystem.ToString());
                _client.DefaultRequestHeaders.Add("operating-system", operatingSystem.ToString());
            }
            if (!string.IsNullOrEmpty(geoLocation))
            {
                lstHeaderParams.Add("geo-location", geoLocation.ToString());
                _client.DefaultRequestHeaders.Add("geo-location", geoLocation.ToString());
            }
            var response = await _client.DeleteAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                return NewtonJson.Deserialize<T>(content);
            }
            else
            {
                return default;
            }
        }
        /// <summary>
        /// PostTusFileAsyn
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<T> PostTusFileAsyn<T>(string url, object data = null)
        {
            try
            {
                foreach (var item in _httpContextAccessor.HttpContext.Request.Headers)
                {
                    foreach (var value in item.Value)
                    {
                        _client.DefaultRequestHeaders.TryAddWithoutValidation(item.Key, value);
                    }

                }
                var method = _httpContextAccessor.HttpContext.Request.Method;
                if (method == "POST")
                {
                    var json = NewtonJson.Serialize(data);
                    var dataPost = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await _client.PostAsync(url, dataPost);
                    if (response.IsSuccessStatusCode)
                    {
                        foreach (var item in response.Headers)
                        {
                            foreach (var val in item.Value)
                            {
                                _httpContextAccessor.HttpContext.Response.Headers.TryAdd(item.Key, val);
                            }
                        }
                        _httpContextAccessor.HttpContext.Response.Headers.Remove("location");
                        _httpContextAccessor.HttpContext.Response.Headers.Remove("Upload-Offset");
                        var location = response.Headers.Location.OriginalString;
                        var session = location.ToString().Split("/");
                        _httpContextAccessor.HttpContext.Response.Headers.TryAdd("location", "/" + "File/Upload" + "/" + session[session.Length - 1]);
                        _httpContextAccessor.HttpContext.Response.Headers.TryAdd("Content-Length", "0");
                        _httpContextAccessor.HttpContext.Response.Headers.TryAdd("Tus-Resumable", "1.0.0");
                        string content = await response.Content.ReadAsStringAsync();
                        return NewtonJson.Deserialize<T>(content);
                    }
                    else
                    {
                        return default;
                    }
                }
                else if (method == "PATCH")
                {

                    var memoryStream = new MemoryStream();
                    await _httpContextAccessor.HttpContext.Request.Body.CopyToAsync(memoryStream);
                    byte[] byteArray = memoryStream.ToArray();
                    using (var content = new ByteArrayContent(byteArray))
                    {

                        var session = _httpContextAccessor.HttpContext.Request.Path.Value.Split("/");
                        content.Headers.ContentType = new MediaTypeHeaderValue("application/offset+octet-stream");
                        _client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/offset+octet-stream");

                        var httpVerb = new HttpMethod("PATCH");
                        var httpRequestMessage = new HttpRequestMessage(httpVerb, url + "/" + session[session.Length - 1])
                        {
                            Content = content
                        };
                        var response = await _client.SendAsync(httpRequestMessage);
                        if (response.IsSuccessStatusCode)
                        {
                            foreach (var item in response.Headers)
                            {
                                foreach (var val in item.Value)
                                {
                                    _httpContextAccessor.HttpContext.Response.Headers.TryAdd(item.Key, val);
                                }
                            }
                            _httpContextAccessor.HttpContext.Response.Headers.Remove("location");
                            _httpContextAccessor.HttpContext.Response.Headers.TryAdd("location", _httpContextAccessor.HttpContext.Request.Path.Value);
                            _httpContextAccessor.HttpContext.Response.Headers.TryAdd("Tus-Resumable", "1.0.0");
                            _httpContextAccessor.HttpContext.Request.Headers.TryGetValue("upload-offset", out var uploadOffsets);
                            foreach (var offsetValue in uploadOffsets)
                            {
                                var length = _httpContextAccessor.HttpContext.Request.ContentLength.Value + int.Parse(offsetValue);
                                _httpContextAccessor.HttpContext.Response.Headers.TryAdd("upload-offset", length.ToString());
                            }
                            return default;
                        }
                        else
                        {
                            return default;
                        }
                    }
                }
                else
                {
                    return default;
                }
            }
            catch (System.Exception ex)
            {
                return default;
            }

        }
        /// <summary>
        /// DonwloadFileAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public async Task<byte[]> DonwloadFileAsync<T>(string url, object data = null)
        {
            try
            {
                Dictionary<string, string> lstHeaderParams = new Dictionary<string, string>();
                StringValues token = string.Empty;
                var accessToken = string.Empty;
                StringValues operatingSystem = string.Empty;
                StringValues geoLocation = string.Empty;
                _httpContextAccessor.HttpContext.Request.Headers.TryGetValue("Authorization", out token);
                _httpContextAccessor.HttpContext.Request.Headers.TryGetValue("operating-system", out operatingSystem);
                _httpContextAccessor.HttpContext.Request.Headers.TryGetValue("geo-location", out geoLocation);
                if (!string.IsNullOrEmpty(token))
                {
                    accessToken = token.ToString().StartsWith("Bearer ") ? token.ToString().Substring(7) : token.ToString();
                    lstHeaderParams.Add("Authorization", accessToken);
                    _client.DefaultRequestHeaders.Remove("Authorization");
                    _client.DefaultRequestHeaders.Add("Authorization", accessToken);
                }
                if (!string.IsNullOrEmpty(operatingSystem))
                {
                    lstHeaderParams.Add("operating-system", operatingSystem.ToString());
                    _client.DefaultRequestHeaders.Add("operating-system", operatingSystem.ToString());
                }
                if (!string.IsNullOrEmpty(geoLocation))
                {
                    lstHeaderParams.Add("geo-location", geoLocation.ToString());
                    _client.DefaultRequestHeaders.Add("geo-location", geoLocation.ToString());
                }
                if (data != null)
                {
                    var json = NewtonJson.Serialize(data);
                    var dataPost = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await _client.PostAsync(url, dataPost);
                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        return null;
                    }
                    else
                    {
                        return default;
                    }
                }
                else
                {
                    _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(System.Net.Mime.MediaTypeNames.Application.Octet));
                    _client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "*/*");;
                    var httpRequest = new HttpRequestMessage()
                    {
                        RequestUri = new System.Uri(_client.BaseAddress + url)
                    };
                    var response = await _client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
                    if (response.IsSuccessStatusCode)
                    {
                        using (var content = await response.Content.ReadAsStreamAsync())
                        {
                            var memory = new MemoryStream();
                            await content.CopyToAsync(memory);
                            return memory.ToArray();
                        }
                    }
                    else
                    {
                        return default;
                    }
                }
            }
            catch (System.Exception ex)
            {
                return default;
            }
            
        }
    }
}
