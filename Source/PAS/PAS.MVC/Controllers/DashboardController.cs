using Microsoft.AspNetCore.Mvc;

namespace PAS.MVC.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
