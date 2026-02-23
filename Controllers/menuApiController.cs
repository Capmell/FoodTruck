using FoodTruck.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodTruck.Controllers
{
    public class MenuApiController : Controller
    {
        [ApiController]
        [Route("api/menu")]
        public class menuApiController : ControllerBase
        {
            private readonly FoodTruckContext _context;

            public menuApiController(FoodTruckContext context)
            {
                _context = context;
            }

            [Authorize]
            [HttpGet]
            public async Task<IActionResult> GetAll()
            {
                var foods = await _context.MenuItem
                    .AsNoTracking()
                    .Select(b => new { b.id, b.Food })
                    .ToListAsync();

                return Ok(foods);
            }

            [Authorize]
            [HttpGet("{id:int}")]
            public async Task<IActionResult> GetById(int id)
            {
                var food = await _context.MenuItem
                    .AsNoTracking()
                    .Where(b => b.id == id)
                    .Select(b => new { b.id, b.Drink })
                    .FirstOrDefaultAsync();

                if (food == null)
                {
                    return NotFound();
                }

                return Ok(food);
            }
        }
    }
}
