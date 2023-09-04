using Microsoft.AspNetCore.Mvc;

namespace PAS.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();

        }
       

    }
}
