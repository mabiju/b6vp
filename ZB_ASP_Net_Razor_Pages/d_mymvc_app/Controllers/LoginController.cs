using Microsoft.AspNetCore.Mvc;

namespace MyMvcApp.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult LoginPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginPage(string username, string password)
        {
            // Simple beginner login credentials
            string validUsername = "admin";
            string validPassword = "12345";

            if (username == validUsername && password == validPassword)
            {
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Invalid username or password.";

            return View();
        }
    }
}