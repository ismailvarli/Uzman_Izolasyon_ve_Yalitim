using Microsoft.AspNetCore.Mvc;

namespace Uzman_Izolasyon_ve_Yalitim.Controllers
{
    public class GaleriController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
