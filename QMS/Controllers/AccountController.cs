using Microsoft.AspNetCore.Mvc;
using QMS.Models;

namespace QMS.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                // Simulate authentication logic (this should query your database in real-world cases)
                if (model.Username == "admin" && model.Password == "password123")  // Example hardcoded login
                {
                    // Successful login, redirect to the dashboard or home page
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    // Invalid credentials
                    ModelState.AddModelError(string.Empty, "Invalid username or password.");
                }
            }

            return View(model);  // Return the view with the validation error
        }
    }
}
