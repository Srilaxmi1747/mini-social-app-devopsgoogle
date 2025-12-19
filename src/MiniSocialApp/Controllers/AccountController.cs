using Microsoft.AspNetCore.Mvc;
using MiniSocialApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace MiniSocialApp.Controllers
{
    public class AccountController : Controller
    {
        // Temporary in-memory user store
        private static List<User> users = new();

        // --------------------
        // LOGIN (GET)
        // --------------------
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // --------------------
        // LOGIN (POST)
        // --------------------
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = users.FirstOrDefault(u =>
                u.Email == email && u.Password == password);

            if (user != null)
            {
                return RedirectToAction("Dashboard", "Home");
            }

            ViewBag.Error = "Invalid email or password";
            return View();
        }

        // --------------------
        // REGISTER (GET)
        // --------------------
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // --------------------
        // REGISTER (POST)
        // --------------------
        [HttpPost]
        public IActionResult Register(User user)
        {
            users.Add(user);
            return RedirectToAction("Login");
        }
    }
}

