using Microsoft.AspNetCore.Mvc;

namespace TestGit.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
