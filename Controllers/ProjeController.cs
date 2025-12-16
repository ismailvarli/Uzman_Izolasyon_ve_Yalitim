using Microsoft.AspNetCore.Mvc;

namespace Uzman_Izolasyon_ve_Yalitim.Controllers
{
    public class ProjeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("halkali-paladyen-silim")]
        public IActionResult halkali_paladyen_silim()
        {
            return View();
        }
    }
}
