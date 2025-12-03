using Microsoft.AspNetCore.Mvc;

namespace Uzman_Izolasyon_ve_Yalitim.Controllers
{
    public class ProjeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
