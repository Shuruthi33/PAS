using Microsoft.AspNetCore.Mvc;

namespace PAS.MVC.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Report()
        {
            return View();
        }
    }
}
