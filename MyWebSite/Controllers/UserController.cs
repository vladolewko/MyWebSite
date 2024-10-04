using Microsoft.AspNetCore.Mvc;
using MyWebSite.Models;

namespace MyWebSite.Controllers;

public class UserController : Controller
{
    public IActionResult Index()
    {
        return View(); // Ensure this method matches the signature expected in the routing
    }
    // POST: /User/Create
    [HttpPost]
    public IActionResult Create(UserModel model)
    {
        if (ModelState.IsValid)
        {
            // Handle the creation logic
            return RedirectToAction("Index"); // Redirect after successful creation
        }

        return View(model); // Return the view with validation errors
    }
}