
using FoodTruck.ViewModels;
using FoodTruck.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoodTruck.Controllers
{
    public class MenuController : Controller
    {
        private readonly IFoodService _foodService;

        public MenuController(IFoodService foodservice)
        {
            _foodService = foodservice;
        }

        public async Task<IActionResult> Index()
        {
            var menu = await _foodService.GetAllAsync();

            var vm = new MenuItemViewModel
            {
                Menu = menu,
                PageTitle = "Available Books",
                TotalCount = menu.Count,
                EmptyMessage = "No books are currently available."
            };

            return View(vm);
        }

        [Route("food/Info")]
        public IActionResult About()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Manage()
        {
            return View();
        }
    }
}