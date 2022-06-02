﻿// <auto-generated />
using Enoca.NET_Challenge.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Enoca.NET_Challenge.Migrations
{
    [DbContext(typeof(EnocaAppDbContext))]
    partial class EnocaAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Enoca.NET_Challenge.Models.Kullanici", b =>
                {
                    b.Property<int>("KullaniciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("KullaniciId");

                    b.ToTable("Kullanicilar");

                    b.HasData(
                        new
                        {
                            KullaniciId = 1,
                            KullaniciAdi = "admin",
                            Sifre = "123456"
                        });
                });

            modelBuilder.Entity("Enoca.NET_Challenge.Models.Ogrenci", b =>
                {
                    b.Property<int>("OgrenciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BolumAdi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FakulteAdi")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("OgrenciAd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OgrenciNo")
                        .HasMaxLength(6)
                        .HasColumnType("int");

                    b.Property<string>("OgrenciSoyad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("OgrenciId");

                    b.ToTable("Ogrenciler");

                    b.HasData(
                        new
                        {
                            OgrenciId = 1,
                            BolumAdi = "Elektrik-Elektronik Mühendisliği",
                            FakulteAdi = "Mühendislik Fakültesi",
                            OgrenciAd = "Cemil",
                            OgrenciNo = 294773,
                            OgrenciSoyad = "Şeroğlu"
                        },
                        new
                        {
                            OgrenciId = 2,
                            BolumAdi = "İşletme",
                            FakulteAdi = "İİB Fakültesi",
                            OgrenciAd = "Ahmet",
                            OgrenciNo = 123456,
                            OgrenciSoyad = "Yıldız"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}