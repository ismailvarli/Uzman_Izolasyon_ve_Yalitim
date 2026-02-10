using System.Text;

namespace Uzman_Izolasyon_ve_Yalitim
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.MapGet("/robots.txt", () => Results.Text(
            @"User-agent: *
Allow: /
Sitemap: https://www.uzmanizolasyonveyalitim.com/sitemap.xml", "text/plain"));

            // -----------------------------------------------------------------
            // 4. ADIM: SITEMAP (Google için Harita)
            // DİKKAT: Buradaki linklerin hepsi KÜÇÜK HARFLİ olmalı.
            // -----------------------------------------------------------------
            app.MapGet("/sitemap.xml", (HttpContext http) =>
            {
                http.Response.ContentType = "application/xml; charset=utf-8";
                var host = "https://www.uzmanizolasyonveyalitim.com";

                // Buraya tüm önemli sayfalarını KÜÇÜK HARFLE ekle
                var urls = new[]
                {
        $"{host}/",
         $"{host}/Services/bohcalama_izolasyon",
        $"{host}/Services/asansor_kuyu_izolasyon",
        $"{host}/Services/beton_cila",
                $"{host}/Services/beton_parlatma",
                $"{host}/Services/epoksi_zemin_kaplama",
                $"{host}/Services/epoksi_kaplama",
                $"{host}/Services/beton_parlatma",
                $"{host}/Services/bohcalama_izolasyon", 
                $"{host}/Services/yangin_yalitimi", 
                $"{host}/Services/ses_yalitimi",
                $"{host}/Services/cati_yalitimi",
                $"{host}/Services/dis_cephe_mantolama",
                $"{host}/Services/fabrika_silim",
                $"{host}/Services/kiremit_cati",
                $"{host}/Services/membran_cati",    
                $"{host}/Services/otopark_silim",
                $"{host}/Services/singil_cati",  

            };

                var sb = new StringBuilder();
                sb.AppendLine(@"<?xml version=""1.0"" encoding=""UTF-8""?>");
                sb.AppendLine(@"<urlset xmlns=""http://www.sitemaps.org/schemas/sitemap/0.9"">");
                foreach (var u in urls)
                {
                    sb.AppendLine("  <url>");
                    sb.AppendLine($"    <loc>{u}</loc>");
                    sb.AppendLine("    <changefreq>weekly</changefreq>");
                    sb.AppendLine("    <priority>0.8</priority>");
                    sb.AppendLine("  </url>");
                }
                sb.AppendLine("</urlset>");
                return Results.Text(sb.ToString(), "application/xml; charset=utf-8");
            });
            // MVC Rotaları
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
