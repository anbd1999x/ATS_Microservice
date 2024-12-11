using NetCore.Models;
using SV.QTHT.Core;

namespace ATS_QTHT_Service.CRM.Logic
{
    public interface IDbUserHandler
    {
        Task<Response<List<User>>> GetUser(FilterBase request);

    }
}
