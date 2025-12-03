using System;
using System.ComponentModel.DataAnnotations;

namespace UzmanIzolasyon.Models
{
    // Veritabanındaki "Projeler" tablosunu temsil eden model
    public class Proje
    {
        public int Id { get; set; }

        [Required, StringLength(250)]
        public string Baslik { get; set; } // proje başlığı

        [Required, StringLength(300)]
        public string Slug { get; set; } // seo uyumlu url parçası

        [StringLength(500)]
        public string Ozet { get; set; } // excerpt / kısa açıklama

        public string Icerik { get; set; } // detaylı içerik (HTML olabilir)

        [StringLength(500)]
        public string ResimYolu { get; set; } // /assets/img/gallery/slug.png

        [StringLength(1000)]
        public string HizmetBolgesi { get; set; } // "İstanbul, Ankara, İzmir..."

        public DateTime OlusturmaTarihi { get; set; } = DateTime.UtcNow;
        public DateTime? GuncellemeTarihi { get; set; }
        public bool Yayin { get; set; } = true;
    }
}
