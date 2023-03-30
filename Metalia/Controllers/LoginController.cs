using Microsoft.AspNetCore.Mvc;

namespace Metalia.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
