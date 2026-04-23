using BearcatBites.Data;
using BearcatBites.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BearcatBites.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BearcatBitesContext _context;

        public HomeController(ILogger<HomeController> logger, BearcatBitesContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public async Task<IActionResult> DailySpotlight()
        {
            var items = await _context.FoodItems.ToListAsync();

            if (items.Count == 0)
            {
                return View(null);
            }

            var random = new Random();
            var randomItem = items[random.Next(items.Count)];

            return View(randomItem);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
