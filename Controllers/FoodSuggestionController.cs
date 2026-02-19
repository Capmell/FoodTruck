using Microsoft.AspNetCore.Mvc;
using FoodTruck.Models;


namespace FoodTruck.Controllers
{
    public class FoodSuggestionController : Controller
    {
       
        [HttpPost]
        public IActionResult Create(FoodSuggestionModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

           
            return RedirectToAction("ThankYou");
            if (!ModelState.IsValid) { return View(model); }
        }

        // GET: /Suggestions/ThankYou
        public IActionResult ThankYou()
        {
            return View();
        }
     
    }
}

