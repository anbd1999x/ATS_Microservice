using ATS_QTHT_API.HttpServices.CRM;
using Microsoft.AspNetCore.Mvc;
using NetCore.Models;
using SV.QTHT.Core;
using System.ComponentModel;

namespace ATS_QTHT_Service.CRM.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    [Description("Nhóm chức năng xử lý User")]
    public class UserController : Controller
    {
        private readonly IDbUserCRMHttpService _dbUSerHandler;

        public UserController(IDbUserCRMHttpService dbUSerHandler)
        {
            _dbUSerHandler = dbUSerHandler;
        }
        /// <summary>
        /// kiểm tra kết nôi vơi s3
        /// </summary>
        /// <param name="param"></param>
        /// <action>CHECK</action>
        [HttpPost]
        public async Task<Response<List<User>>> GetUser(FilterBase request)
        {
            return await _dbUSerHandler.GetUser(request);
        }
    }
}
