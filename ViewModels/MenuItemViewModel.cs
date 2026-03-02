using System.Collections.Generic;
using FoodTruck.DTOs;

namespace FoodTruck.ViewModels
{
    public class MenuListViewModel
    {
        public List<FoodListItem> Menu { get; set; } = new();
        public string PageTitle { get; set; } = "Menu";
        public int TotalCount { get; set; }
        public string EmptyMessage { get; set; } = "No Items found.";
    }
}