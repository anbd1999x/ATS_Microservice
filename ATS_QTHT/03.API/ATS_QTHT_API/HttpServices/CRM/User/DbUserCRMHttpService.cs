using NetCore.Core.Helper;
using NetCore.Models;
using SV.QTHT.Core;

namespace ATS_QTHT_API.HttpServices.CRM
{
    public class DbUserCRMHttpService : IDbUserCRMHttpService
    {
        private HttpClient _client;
        private IHttpHelper _httpHelper;
        private IHttpContextAccessor _httpContextAccessor;

        ///<Summary>
        ///</Summary>
        public DbUserCRMHttpService(HttpClient client, IHttpContextAccessor httpContextAccessor)
        {
            _client = client;
            _httpContextAccessor = httpContextAccessor;
            _httpHelper = new HttpHelper(_client, _httpContextAccessor);
        }
        /// <summary>
        /// GetUser
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<Response<List<User>>> GetUser(FilterBase request)
        {
            return await _httpHelper.PostAsync<Response<List<User>>>($"User/GetUser", request);
        }
    }
}
