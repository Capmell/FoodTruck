using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FoodTruck.Models
{
    public class FoodTruckContext : DbContext
    {
        public BookBarnContext(DbContextOptions<FoodTruckContext> options)
            : base(options)
        {
        }

        public DbSet<MenuItem> MenuItem => Set<MenuItem>();
        public DbSet<Location> Location => Set<Location>();

    }
}
