using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace PAS.MVC.Controllers
{
    public class AdministrationsController : Controller
    {
        private readonly ILogger<AdministrationsController> logger;
        public AdministrationsController(ILogger<AdministrationsController> logger)
        {
            this.logger = logger;
        }
        public IActionResult Administrations()
        {
            return View();
        }
        [Microsoft.AspNetCore.Mvc.Route("~/AddCandidate")]
        public IActionResult AddCandidate(Int16 UserId=0)
        {
            ViewBag.UserId = UserId;
            return View();
        }
    }
}
