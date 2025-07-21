using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace StudentManagementSystem.Controllers
{
    public class KullaniciController : Controller
    {
        private readonly AppDbContext _context;

        public KullaniciController(AppDbContext context)
        {
            _context = context;
        }

        // Kullanıcı ekleme sayfası
        [HttpGet]
        public IActionResult Ekle()
        {
            ViewBag.Siniflar = _context.Siniflar
                .Select(s => new SelectListItem
                {
                    Value = s.SinifID.ToString(),
                    Text = s.SinifAdi
                }).ToList();

            return View();
        }


        // Kullanıcıyı veritabanına ekle
        [HttpPost]
        public async Task<IActionResult> Ekle(Kullanici model)
        {
            if (ModelState.IsValid)
            {
                model.RolID = 1; // Varsayılan öğrenci rolü

                _context.Kullanicilar.Add(model);
                await _context.SaveChangesAsync();

                return RedirectToAction("Liste");
            }

            ViewBag.Siniflar = _context.Siniflar
                .Select(s => new SelectListItem
                {
                    Value = s.SinifID.ToString(),
                    Text = s.SinifAdi
                }).ToList();

            return View(model);
        }


        // Kullanıcıları listeleme
        public async Task<IActionResult> Liste()
        {
            var kullanicilar = await _context.Kullanicilar
                .Include(k => k.Rol)
                .Include(k => k.Sinif) // Eğer sınıf da gösterilecekse
                .ToListAsync();

            return View(kullanicilar);
        }

        // Kullanıcıyı silme işlemi
        [HttpPost]
        public async Task<IActionResult> Sil(int id)
        {
            var kullanici = await _context.Kullanicilar.FindAsync(id);
            if (kullanici != null)
            {
                _context.Kullanicilar.Remove(kullanici);
                await _context.SaveChangesAsync();
            }

            var rol = HttpContext.Session.GetString("KullaniciRol");

            if (rol == "Bölüm Başkanı")
            {
                return RedirectToAction("BaskanListe");
            }
            else if (rol == "Bölüm Sekreteri")
            {
                return RedirectToAction("Liste");
            }
            else
            {
                // Başka roller veya varsayılan yönlendirme
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult OgretimElemanlari()
        {
            var ogretimElemanlari = _context.Kullanicilar
                .Where(k => k.RolID == 2) // 2: Öğretim Elemanı
                .ToList();

            return View(ogretimElemanlari);
        }


        public IActionResult OgretimElemaniDersProgrami(int kullaniciId)
        {
            var ogretimElemani = _context.Kullanicilar
                .Include(k => k.Rol)
                .FirstOrDefault(k => k.KullaniciID == kullaniciId && k.RolID == 2);  // Öğretim elemanı rolü ID'si 2

            if (ogretimElemani == null)
            {
                return NotFound();  // Öğretim elemanı bulunamadı
            }

            // Öğretim elemanına ait ders programlarını alıyoruz
            var dersProgramlari = _context.DersProgramlari
                .Where(dp => dp.Ders.OgretimElemaniID == kullaniciId)  // Öğretim elemanına atanmış derslerin programını getiriyoruz
                .Include(dp => dp.Ders)  // Ders detaylarını dahil ediyoruz
                .Include(dp => dp.Derslik)  // Derslik detaylarını dahil ediyoruz
                .ToList();

            return View(dersProgramlari);  // Ders programlarını view'e gönderiyoruz
        }
        // Bölüm Başkanı için kullanıcı ekleme sayfası
        [HttpGet]
        public IActionResult BaskanKullaniciEkle()
        {
            ViewBag.Siniflar = _context.Siniflar
                .Select(s => new SelectListItem
                {
                    Value = s.SinifID.ToString(),
                    Text = s.SinifAdi
                }).ToList();

            ViewBag.Roller = new List<SelectListItem>
    {
        new SelectListItem { Value = "1", Text = "Öğrenci" },
        new SelectListItem { Value = "2", Text = "Öğretim Elemanı" },
        new SelectListItem { Value = "3", Text = "Bölüm Sekreteri" }
    };

            return View();
        }


        // Bölüm Başkanı formunu post eder
        [HttpPost]
        public async Task<IActionResult> BaskanKullaniciEkle(Kullanici model)
        {
            if (ModelState.IsValid)
            {
                _context.Kullanicilar.Add(model);
                await _context.SaveChangesAsync();
                return RedirectToAction("BaskanListe");
            }

            ViewBag.Siniflar = _context.Siniflar
                .Select(s => new SelectListItem
                {
                    Value = s.SinifID.ToString(),
                    Text = s.SinifAdi
                }).ToList();

            ViewBag.Roller = new List<SelectListItem>
    {
        new SelectListItem { Value = "1", Text = "Öğrenci" },
        new SelectListItem { Value = "2", Text = "Öğretim Elemanı" },
        new SelectListItem { Value = "3", Text = "Bölüm Sekreteri" }
    };

            return View(model);
        }
        [HttpGet]
        public IActionResult BaskanListe()
        {
            var kullanicilar = _context.Kullanicilar
                .Include(k => k.Rol)
                .Include(k => k.Sinif)
                .ToList();

            return View("BaskanListe", kullanicilar);
        }

         public IActionResult RolGuncelle(int id)
        {
            var kullanici = _context.Kullanicilar.FirstOrDefault(k => k.KullaniciID == id);
            if (kullanici == null) return NotFound();

            ViewBag.Roller = new SelectList(_context.Roller.ToList(), "RolID", "RolAdi", kullanici.RolID);
            return View(kullanici);
        }




            [HttpPost]
        public IActionResult RolGuncelle(Kullanici model)
        {
            var kullanici = _context.Kullanicilar.Find(model.KullaniciID);
            if (kullanici == null) return NotFound();

            // Bilgileri güncelle
            kullanici.AdSoyad = model.AdSoyad;
            kullanici.Eposta = model.Eposta;
            kullanici.RolID = model.RolID;

            _context.SaveChanges();

            return RedirectToAction("BaskanListe");
        }






    }
}
