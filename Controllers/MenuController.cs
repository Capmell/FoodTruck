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
            var Foods = _context.FoodTruck.ToList();

            var vm = new FoodTruck
            {
                Food = Foods,
                PageTitle = "Available items",
                TotalCount = Foods.Count,
                EmptyMessage = "No items are currently available."
            };

            return View(vm);
        }
    

    }
}
