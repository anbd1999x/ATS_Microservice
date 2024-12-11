using NetCore.Models;
using SV.QTHT.Core;

namespace ATS_QTHT_API.HttpServices.CRM
{
    public interface IDbUserCRMHttpService
    {
        Task<Response<List<User>>> GetUser(FilterBase request);

    }
}
