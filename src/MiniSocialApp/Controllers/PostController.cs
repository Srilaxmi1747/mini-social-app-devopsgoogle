using Microsoft.AspNetCore.Mvc;
using MiniSocialApp.Models;

namespace MiniSocialApp.Controllers
{
    public class PostController : Controller
    {
        private static List<Post> posts = new();

        public IActionResult Index()
        {
            return View(posts);
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(string content)
        {
            posts.Add(new Post
            {
                Content = content,
                CreatedAt = DateTime.Now
            });

            return RedirectToAction("Index");
        }
    }
}
