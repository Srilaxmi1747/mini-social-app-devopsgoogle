using Microsoft.AspNetCore.Mvc;

namespace MiniSocialApp.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Feed() => View();
        public IActionResult Create() => View();
    }
}