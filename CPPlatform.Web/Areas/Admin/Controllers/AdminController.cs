using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CPPlatform.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize] // 👈 Bu satır admin alanına sadece giriş yapmış kullanıcıların erişmesini sağlar
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
