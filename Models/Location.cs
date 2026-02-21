namespace FoodTruck.Models
{
    public class Location
    {
        public int id { get; set; }              // Primary key
        public string Town { get; set; } = "";  // Basic required text
        public string Street { get; set; } = "";
    }
}
