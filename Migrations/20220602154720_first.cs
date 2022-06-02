using Microsoft.EntityFrameworkCore.Migrations;

namespace Enoca.NET_Challenge.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.KullaniciId);
                });

            migrationBuilder.CreateTable(
                name: "Ogrenciler",
                columns: table => new
                {
                    OgrenciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciAd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OgrenciSoyad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OgrenciNo = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    FakulteAdi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BolumAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.OgrenciId);
                });

            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "KullaniciId", "KullaniciAdi", "Sifre" },
                values: new object[] { 1, "admin", "123456" });

            migrationBuilder.InsertData(
                table: "Ogrenciler",
                columns: new[] { "OgrenciId", "BolumAdi", "FakulteAdi", "OgrenciAd", "OgrenciNo", "OgrenciSoyad" },
                values: new object[] { 1, "Elektrik-Elektronik Mühendisliği", "Mühendislik Fakültesi", "Cemil", 294773, "Şeroğlu" });

            migrationBuilder.InsertData(
                table: "Ogrenciler",
                columns: new[] { "OgrenciId", "BolumAdi", "FakulteAdi", "OgrenciAd", "OgrenciNo", "OgrenciSoyad" },
                values: new object[] { 2, "İşletme", "İİB Fakültesi", "Ahmet", 123456, "Yıldız" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "Ogrenciler");
        }
    }
}
