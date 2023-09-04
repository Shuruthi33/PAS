using Microsoft.AspNetCore.Mvc;

namespace PAS.MVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
