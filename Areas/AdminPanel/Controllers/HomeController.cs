using Enoca.NET_Challenge.Filters;
using Enoca.NET_Challenge.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Enoca.NET_Challenge.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Login]
    public class HomeController : Controller
    {
        private readonly EnocaAppDbContext _db;

        public HomeController(EnocaAppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Ogrenciler()
        {
            var ogrenciList = _db.Ogrenciler.ToList();
            return View(ogrenciList);
        }

        public IActionResult Yeni()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Yeni(Ogrenci o)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.OgrenciAd = o.OgrenciAd;
            ogrenci.OgrenciSoyad = o.OgrenciSoyad;
            ogrenci.BolumAdi = o.BolumAdi;
            ogrenci.FakulteAdi = o.FakulteAdi;
            ogrenci.OgrenciNo = Convert.ToInt32(o.OgrenciNo);

            _db.Add(ogrenci);
            _db.SaveChanges();
            return RedirectToAction("Ogrenciler", "Home");

        }

        public IActionResult Duzenle(int id)
        {
            Ogrenci o = _db.Ogrenciler.Find(id);
            Ogrenci ogun = new Ogrenci();

            if (o != null)
            {
                ogun.OgrenciId = id;
                ogun.OgrenciAd = o.OgrenciAd;
                ogun.OgrenciSoyad = o.OgrenciSoyad;
                ogun.OgrenciNo = o.OgrenciNo;
                ogun.FakulteAdi = o.FakulteAdi;
                ogun.BolumAdi = o.BolumAdi;
            }
            else
                NotFound();

            return View(ogun);
        }

        [HttpPost]
        public IActionResult Duzenle(Ogrenci o)
        {
            if (ModelState.IsValid)
            {
                var ogrenci = _db.Ogrenciler.Find(o.OgrenciId);
                ogrenci.OgrenciAd = o.OgrenciAd;
                ogrenci.OgrenciSoyad = o.OgrenciSoyad;
                ogrenci.OgrenciNo = o.OgrenciNo;
                ogrenci.FakulteAdi = o.FakulteAdi;
                ogrenci.BolumAdi = o.BolumAdi;
            }
            _db.SaveChanges();
            return RedirectToAction("Ogrenciler", "Home");

        }

        [HttpPost]
        public IActionResult Sil(int id)
        {

            var ogrenci = _db.Ogrenciler.Find(id);
            if (ogrenci == null)
                return NotFound();

            _db.Ogrenciler.Remove(ogrenci);
            _db.SaveChanges();
            return RedirectToAction("Ogrenciler","Home");
        }
    }
}

