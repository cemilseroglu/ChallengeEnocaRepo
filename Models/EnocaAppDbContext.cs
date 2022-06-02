using Microsoft.EntityFrameworkCore;

namespace Enoca.NET_Challenge.Models
{
    public class EnocaAppDbContext : DbContext
    {
        public EnocaAppDbContext(DbContextOptions<EnocaAppDbContext> options) : base(options)
        {

        }

        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kullanici>().HasData(
                new Kullanici() { KullaniciId = 1, KullaniciAdi = "admin",Sifre="123456" }
                );

            modelBuilder.Entity<Ogrenci>().HasData(
                 new Ogrenci() { OgrenciId=1,OgrenciAd="Cemil",OgrenciSoyad="Şeroğlu",OgrenciNo=294773,FakulteAdi="Mühendislik Fakültesi",BolumAdi="Elektrik-Elektronik Mühendisliği"},
                 new Ogrenci() { OgrenciId = 2, OgrenciAd = "Ahmet", OgrenciSoyad = "Yıldız", OgrenciNo = 123456, FakulteAdi = "İİB Fakültesi", BolumAdi = "İşletme" }
                );
        }
    }
}
