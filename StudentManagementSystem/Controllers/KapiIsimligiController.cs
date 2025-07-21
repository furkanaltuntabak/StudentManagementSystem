using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Data;

namespace StudentManagementSystem.Controllers
{
    public class KapiIsimligiController : Controller
    {
        private readonly AppDbContext _context;

        public KapiIsimligiController(AppDbContext context)
        {
            _context = context;
        }

        // 🔹 Bölüm Sekreteri: Belirli bir öğretim elemanı için formu açar
        [HttpGet]
        public IActionResult CreateForOgretimElemani(int ogretimElemaniId)
        {
            var ogretimElemani = _context.Kullanicilar.FirstOrDefault(k =>
                k.KullaniciID == ogretimElemaniId && k.RolID == 2); // 2 = Öğretim Elemanı

            if (ogretimElemani == null)
                return NotFound();

            var model = new KapiIsimligi
            {
                OgretimElemaniID = ogretimElemani.KullaniciID,
                KapiIsimligiAdi = ogretimElemani.AdSoyad // Otomatik doldurulabilir
            };

            return View("Create", model); // Ortak view kullanıyoruz
        }

        // 🔹 Ortak View için GET (giriş yapan öğretim elemanı kendi oluşturmak isterse)
        [HttpGet]
        public IActionResult Create()
        {
            var kullaniciID = HttpContext.Session.GetInt32("KullaniciID");
            if (kullaniciID == null)
                return RedirectToAction("Login", "Account");

            return View(new KapiIsimligi());
        }

        // 🔹 POST – Hem bölüm sekreteri hem öğretim elemanı için çalışır
        [HttpPost]
        public IActionResult Create(KapiIsimligi model)
        {
            // Eğer modelde OgretimElemaniID sıfırsa, giriş yapan öğretim elemanı içindir
            if (model.OgretimElemaniID == 0)
            {
                var sessionId = HttpContext.Session.GetInt32("KullaniciID");
                if (sessionId == null)
                    return RedirectToAction("Login", "Account");

                model.OgretimElemaniID = sessionId.Value;
            }

            _context.KapiIsimlikleri.Add(model);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
                // 🔍 Kapı İsimliği Göster – belirli bir öğretim elemanının kapı isimliği
        [HttpGet]
        public IActionResult BenimIsimligim()
        {
            var sessionId = HttpContext.Session.GetInt32("KullaniciID");
            if (sessionId == null)
                return RedirectToAction("Login", "Account");

            var isimlik = _context.KapiIsimlikleri
                .FirstOrDefault(k => k.OgretimElemaniID == sessionId.Value);

            if (isimlik == null)
            {
                TempData["Bilgi"] = "Henüz bir kapı isimliği oluşturmadınız.";
                return RedirectToAction("Create"); // Form ekranına yönlendirebiliriz
            }

            return View("BenimIsimligim", isimlik); // View adını sen istersen değiştir
        }


        
    }
}
