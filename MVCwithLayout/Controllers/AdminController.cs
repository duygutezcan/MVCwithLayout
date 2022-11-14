using Microsoft.AspNetCore.Mvc;

namespace MVCwithLayout.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Islem()
        {
            return View();
        }
        public IActionResult Mail()
        {
            return View();
        }
    }
}
