using FoodTruck.DTOs;

namespace FoodTruck.Services.Interfaces
{
    public interface IFoodService
    {
        Task<List<FoodListItem>> GetAllAsync();
        Task<FoodListItem> GetByIdAsync(int id);
    }
}