using Microsoft.AspNetCore.Mvc;

namespace PAS.Controllers
{
    public class DashboardController : Controller
    {
        private readonly HttpClient _client;
        private const string BaseUri = "https://localhost:7138/api/";
        public DashboardController()
        {
            _client = new HttpClient();
        }

        public async Task<IActionResult> Index()
        {
            string actionUri = BaseUri +  "PrjAllotment/GetPrjAllotemtDetails";
            var response = await _client.GetStringAsync(actionUri);
            Console.WriteLine(response);
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult UserDetails()
        {
            return View();
        }


    }
}
