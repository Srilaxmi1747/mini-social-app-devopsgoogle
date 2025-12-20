using Microsoft.AspNetCore.Mvc;

namespace MiniSocialApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
