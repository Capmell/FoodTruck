using FoodTruck.DTOs;

namespace FoodTruck.Controllers
{
    internal class MenuItemViewModel
    {
        public List<FoodListItem> Menu { get; set; }
        public string PageTitle { get; set; }
        public int TotalCount { get; set; }
        public string EmptyMessage { get; set; }
    }
}