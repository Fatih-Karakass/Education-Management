using Ders1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ders1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // Inversion of control (kontrolü tersine çevirmek) -> kontolü container'e teslim etmek.
        // Dependecy injection (bağımlılıkları eklemek) -> bir nesne oluşturulurken gerekli bağımlılıkları injekt etmek demektir.
        // Inversion control != dependency injection;

        // Singleton pattern -> bir classın sadece bir tane nesnesinin olmasını sağlamak.

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}