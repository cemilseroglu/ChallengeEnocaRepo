using Enoca.NET_Challenge.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Enoca.NET_Challenge.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EnocaAppDbContext _db;

        public HomeController(ILogger<HomeController> logger,EnocaAppDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Kullanici k)
        {
            var kullanici = _db.Kullanicilar.FirstOrDefault(x=>x.KullaniciAdi==k.KullaniciAdi);
            if (kullanici == null)
                ViewBag.Hata = "Böyle bir kullanıcı yok.Lütfen tekrar deneyin!";
            else
            {
                if(kullanici.KullaniciAdi == k.KullaniciAdi && kullanici.Sifre == k.Sifre)
                return RedirectToAction("Index", "Home", new { area = "AdminPanel" });
                else
                {
                    ViewBag.Hata = "Kullanıcı adını veya şifreyi yanlış girdiniz...Lütfen tekrar deneyiniz.";
                }
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
