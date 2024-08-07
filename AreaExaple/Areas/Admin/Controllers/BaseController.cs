using Microsoft.AspNetCore.Mvc;

namespace AreaExaple.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
