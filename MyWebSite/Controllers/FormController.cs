using Microsoft.AspNetCore.Mvc;
using MyWebSite.Models;

namespace MyWebSite.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Check(FormModel model)
        {
            // Check if the model is valid
            if (ModelState.IsValid)
            {
                // Pass the form data to the Check view
                return View(model); 
            }

            // If the model is not valid, return to the form
            return View("Index", model);
        }
    }
}
 