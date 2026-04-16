using BearcatBites.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BearcatBites.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ExploreBites()
        {
            return View();
        }
        
        public IActionResult ExploreSips()
        {
            return View();
        }

        public IActionResult DailySpotlight()
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
