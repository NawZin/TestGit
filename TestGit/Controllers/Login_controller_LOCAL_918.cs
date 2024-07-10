using Microsoft.AspNetCore.Mvc;

namespace TestGit.Controllers
{
    public class Login_controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public interface IActionResult
        {
            string Login { get; set; }
        }
    }
}
