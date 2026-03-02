using System.Configuration;
using FoodTruck.DTOs;
using FoodTruck.Models;
using FoodTruck.Services.Interfaces;
using FoodTruck.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodTruck.Services
{
    public class FoodService : IFoodService
    {
        private readonly FoodTruckContext _context;

        public FoodService(FoodTruckContext context)
        {
            _context = context;
        }

        public async Task<List<FoodListItem>> GetAllAsync()
        {
            // Business rule example:
            // Only return books with a title and a non-negative price.
            // Also enforce a consistent sort order.
            return await _context.MenuItem
                .AsNoTracking()
                .Where(b => b.id != null && b.Food.Trim() != "")
                .OrderBy(b => b.Food)
                .Select(b => new FoodListItem
                {
                    Id = b.id,
                    Title = b.Food!
                  
                })
                .ToListAsync();
        }

        public async Task<FoodListItem?> GetByIdAsync(int id)
        {
            return await _context.MenuItem
                .AsNoTracking()
                .Where(b => b.id == id)
                .Select(b => new FoodListItem
                {
                    Id = b.id,
                    Title = b.Food!
                
                })
                .FirstOrDefaultAsync();
        }
    }
}