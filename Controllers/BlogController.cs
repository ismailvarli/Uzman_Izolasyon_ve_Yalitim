using Microsoft.AspNetCore.Mvc;

namespace Uzman_Izolasyon_ve_Yalitim.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult isi_yalitimi_ile_enerji_tasarrufu_nasil_saglanir()
        {
            return View();
        }

        // 2. Sayfa: Teras İzolasyonu
        public IActionResult teras_izolasyonunda_dogru_malzeme_secimi()
        {
            return View();
        }

        // 3. Sayfa: Ses Yalıtımı
        public IActionResult ses_yalitimi__konfor_ve_kanitlanmis_cozumler()
        {
            return View();
        }
    }
}
