namespace FoodTruck.Models
{
    public class MenuItem
    {
        public int Id { get; set; }              // Primary key
        public string Food { get; set; } = "";  // Basic required text
        public string Drink { get; set; } = "";
    }
}
