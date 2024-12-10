using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetCore.Core.Helper
{
    public interface IHttpHelper
    {
        Task<T> GetAsync<T>(string url);
        Task<T> GetAsync<T>(string url, string accessToken);
        Task<T> PostAsync<T>(string url, object data = null);
        Task<T> PostFileAsync<T>(string url, object data = null, IFormFile file = null);
        Task<T> PutAsync<T>(string url, object data = null);
        Task<T> DeleteAsync<T>(string url);
        Task<T> PostTusFileAsyn<T>(string url, object data = null);
        Task<byte[]> DonwloadFileAsync<T>(string url, object data = null);
    }
}
