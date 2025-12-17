using Microsoft.AspNetCore.Mvc;
using MiniSocialApp.Models;

namespace MiniSocialApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login() => View();
        public IActionResult Register() => View();
    }
}