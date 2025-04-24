// AccountController.cs
using Microsoft.AspNetcore.Mvc;
//using QMS.Models;

public class AccountController : Controller
{
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login()
    {
        if (ModelState.IsValid)
        {
            if () // Dummy auth
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("WrongCredentials", "Invalid username or password.");
            }
        }

        return View();
    }
}
