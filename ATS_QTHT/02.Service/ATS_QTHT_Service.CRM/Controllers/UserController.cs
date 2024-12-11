using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace ATS_QTHT_Service.CRM.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    [Description("Nhóm chức năng xử lý User")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
