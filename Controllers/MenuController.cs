using Microsoft.AspNetCore.Mvc;
using FoodTruck.ViewModels;
using FoodTruck.Models;

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
            var Foods = _context.MenuItem.ToList();

            var vm = new MenuItem
            {
                Food = "available food",
                Drink = "Available drinks",
                Id = Foods.Count,
                EmptyMessage = "No items are currently available."
            };

            return View(vm);
        }
    

    }
}
