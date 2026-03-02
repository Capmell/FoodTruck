
using FoodTruck.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoodTruck.Controllers
{
    [ApiController]
    [Route("api/Menu")]
    public class MenuApiController : ControllerBase
    {
        private readonly IFoodService _foodService;

        public MenuApiController(IFoodService foodservice)
        {
            _foodService = foodservice;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var foods = await _foodService.GetAllAsync();
            return Ok(foods);
        }

        [Authorize]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var food = await _foodService.GetByIdAsync(id);

            if (food == null)
            {
                return NotFound();
            }

            return Ok(food);
        }
    }
}