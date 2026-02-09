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

            // Success logic will be expanded later in the course (CRUD + database persistence).
            // For now, we simply redirect to a success page (PRG).
            return RedirectToAction("ThankYou");
        }

        // GET: /Suggestions/ThankYou
        public IActionResult ThankYou()
        {
            return View();
        }
    }
}
