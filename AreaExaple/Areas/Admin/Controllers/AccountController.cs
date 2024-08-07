using Microsoft.AspNetCore.Mvc;

namespace AreaExaple.Areas.Admin.Controllers
{
    public class AccountController : BaseController
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}
