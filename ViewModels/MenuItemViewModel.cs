using System.Collections.Generic;
using FoodTruck.Models;

namespace FoodTruck.ViewModels
{
    public class MenuItemViewModel
    {
        public List<MenuItem> Menu { get; set; } = new();
        public string PageTitle { get; set; } = "Menu Items";
        public int TotalCount { get; set; }
        public string EmptyMessage { get; set; } = "No items found.";
    }
}