using Microsoft.AspNetCore.Mvc;

namespace DemoTestGit.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
