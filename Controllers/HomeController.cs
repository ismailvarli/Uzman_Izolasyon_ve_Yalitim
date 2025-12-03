using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Uzman_Izolasyon_ve_Yalitim.Models;

namespace Uzman_Izolasyon_ve_Yalitim.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult hakkimizda()
        {
            return View();
        }
        public IActionResult iletisim()
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
