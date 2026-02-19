using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;


namespace FoodTruck.Models
{
    public class FoodSuggestionModel
    {
       
            [Required]
            [StringLength(80)]
            public string Id { get; set; }

            [Required]
            [StringLength(60)]
            public string Town { get; set; }

            [Range(1, 10)]
            public int Street { get; set; }

            [StringLength(300)]
            public string EmailAddress { get; set; }
        
    }
}
