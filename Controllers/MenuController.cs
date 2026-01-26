using Microsoft.AspNetCore.Mvc;

namespace FoodTruck.Controllers
{
    public class MenuController : Controller
    {
        private readonly FoodTruckContext _context;
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Menu()
        {
            return View();
        }
    }
}
