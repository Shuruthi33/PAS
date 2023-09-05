using Microsoft.AspNetCore.Mvc;

namespace PAS.MVC.Controllers
{
    public class DashboardController : Controller
    {
        [Route("~/dashboard")]
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
