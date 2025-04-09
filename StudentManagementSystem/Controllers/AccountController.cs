using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentManagementSystem.Data;

namespace StudentManagementSystem.Controllers
{
    
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult OgrenciGiris()
        {
            return View();
        }
        [HttpPost]
        public IActionResult OgrenciGiris(Kullanici model)
        {
            if (!ModelState.IsValid)
                return View(model);

            // Giriş kontrolü (örnek olarak)
            var kullanici = _context.Kullanicilar
                .FirstOrDefault(k => k.Eposta == model.Eposta && k.Sifre == model.Sifre && k.RolID == 1); // 1 = Öğrenci

            if (kullanici == null)
            {
                ViewBag.Hata = "Geçersiz e-posta veya şifre.";
                return View(model);
            }

            // Giriş başarılı → yönlendirme
            return RedirectToAction("Index", "Home");
        }
        public IActionResult YoneticiGiris()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YoneticiGiris(Kullanici model)
        {
            if (!ModelState.IsValid)
                return View(model);

            // RolID == 2 olarak yönetici kontrolü
            var kullanici = _context.Kullanicilar
                .FirstOrDefault(k => k.Eposta == model.Eposta && k.Sifre == model.Sifre && k.RolID == 2); // 2 = Yönetici

            if (kullanici == null)
            {
                ViewBag.Hata = "Geçersiz giriş bilgisi. E-posta veya şifre hatalı ya da rol uygun değil.";
                // Hata mesajını detaylı olarak görmek için model bilgilerini loglayabilirsiniz.
                Console.WriteLine($"Giriş denemesi: E-posta: {model.Eposta}, Şifre: {model.Sifre}");
                return View(model);
            }

            // Giriş başarılı
            return RedirectToAction("Index", "Home"); // Başka bir sayfaya yönlendirme
        }



        
    }
}