using Microsoft.AspNetCore.Mvc;

namespace BearcatBites.Controllers
{
    public class RestaurantRecommendationController : Controller
    {
        private readonly ILogger<RestaurantRecommendationController> _logger;

        public RestaurantRecommendationController(ILogger<RestaurantRecommendationController> logger)
        {
            _logger = logger;
        }

        public IActionResult ExploreBites()
        {
            return View();
        }

        public IActionResult ExploreSips()
        {
            return View();
        }
    }
}
