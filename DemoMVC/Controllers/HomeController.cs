using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Ví dụ lưu 1 session
            HttpContext.Session.SetString("Welcome", "Chào mừng bạn đến Buổi 8 DemoMVC!");
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "Đây là trang About.";
            return View();
        }
    }
}