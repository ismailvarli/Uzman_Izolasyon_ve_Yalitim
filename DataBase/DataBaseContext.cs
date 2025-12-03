using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using UzmanIzolasyon.Models; // Proje modeline ulaşmak için

namespace DataBase
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Proje> Projeler { get; set; } // Veritabanındaki "Projeler" tablosu

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Veritabanı bağlantı ayarları
            optionsBuilder.UseSqlServer("Server=ISMAIL\\SQLDERS;Database=DBWatch;Integrated Security=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // İstersen tablo adı veya alan adlarını burada özelleştirebilirsin.
            // modelBuilder.Entity<Proje>().ToTable("Projeler");
        }
    }
}
