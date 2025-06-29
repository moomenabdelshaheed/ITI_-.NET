using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCLAB1.Models;

namespace MVCLAB1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult showmix(int id)
        {
            if (id % 2 == 0)
            {
                return View("view1");
            }
            else
            {
                return Content("Hello From The Other Side -Adele");
            }
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
