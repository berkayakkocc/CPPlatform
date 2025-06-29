using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CPPlatform.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            // Geçici placeholder
            return View();
        }
    }
}
