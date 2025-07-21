using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace StudentManagementSystem.Controllers
{
    public class DersController : Controller
    {
        private readonly AppDbContext _context;

        public DersController(AppDbContext context)
        {
            _context = context;
        }

       [HttpGet]

    public IActionResult DersEkle()
    {
        // Sınıfları alıyoruz
        var siniflar = _context.Siniflar.ToList();

        // Dönemler (Güz ve Bahar) seçenekleri
        var donemler = new List<SelectListItem>
        {
            new SelectListItem { Text = "Güz", Value = "Güz" },
            new SelectListItem { Text = "Bahar", Value = "Bahar" }
        };

        // Sınıfları ve dönemleri View'a gönderiyoruz
        ViewBag.Siniflar = new SelectList(siniflar, "SinifID", "SinifAdi");
        ViewBag.Donemler = donemler;

        return View();
    }

    // POST: Ders/DersEkle
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult DersEkle(int sinifId, string donem, string dersAdi)
    {
        if (string.IsNullOrEmpty(dersAdi))
        {
            ModelState.AddModelError("DersAdi", "Ders adı boş olamaz.");
        }

        if (ModelState.IsValid)
        {
            // DonemID hesapla
            int donemID = 0;
            if (donem == "Güz")
            {
                donemID = sinifId * 2 - 1; // Güz dönemi, 1.sınıf Güz -> 1, 2.sınıf Güz -> 3 vb.
            }
            else if (donem == "Bahar")
            {
                donemID = sinifId * 2; // Bahar dönemi, 1.sınıf Bahar -> 2, 2.sınıf Bahar -> 4 vb.
            }

            // Yeni ders objesi oluşturuluyor
            var yeniDers = new Ders
            {
                DersAdi = dersAdi,
                SinifID = sinifId,
                DonemID = donemID,
                OgretimElemaniID = null // Öğretim Elemanı ataması yapılmadı, boş bırakılıyor
            };

            // Ders veritabanına ekleniyor
            _context.Dersler.Add(yeniDers);
            _context.SaveChanges();

            // Liste sayfasına yönlendir
            return RedirectToAction("Liste");
        }

        // Hatalı ise (ders adı boş gibi) sınıf ve dönemleri tekrar View'a gönderiyoruz
        var siniflar = _context.Siniflar.ToList();
        var donemler = new List<SelectListItem>
        {
            new SelectListItem { Text = "Güz", Value = "Güz" },
            new SelectListItem { Text = "Bahar", Value = "Bahar" }
        };

        ViewBag.Siniflar = new SelectList(siniflar, "SinifID", "SinifAdi");
        ViewBag.Donemler = donemler;

        return View();
    }

        // Öğretim Elemanına Ders Atama GET işlemi
        [HttpGet]
        public IActionResult OgretimElemaninaDersAta()
        {
            ViewBag.OgretimElemanlari = _context.Kullanicilar
                .Where(k => k.RolID != 1) // Öğrenci dışındakiler
                .Select(k => new SelectListItem
                {
                    Value = k.KullaniciID.ToString(),
                    Text = k.AdSoyad
                }).ToList();

            ViewBag.Dersler = _context.Dersler
                .Where(d => d.OgretimElemaniID == null) // Henüz atanmamış dersler
                .Select(d => new SelectListItem
                {
                    Value = d.DersID.ToString(),
                    Text = d.DersAdi
                }).ToList();

            return View();
        }

        // Öğretim Elemanına Ders Atama POST işlemi
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OgretimElemaninaDersAta(int ogretimElemaniId, int dersId)
        {
            var ders = await _context.Dersler.FindAsync(dersId);
            if (ders == null)
            {
                return NotFound();
            }

            ders.OgretimElemaniID = ogretimElemaniId;
            await _context.SaveChangesAsync();

            return RedirectToAction("Liste"); // Dersler listesine yönlendirme
        }

        // Dersler listesi
        public async Task<IActionResult> Liste()
        {
            var dersler = await _context.Dersler
                .Include(d => d.OgretimElemani)  // Öğretim elemanını ekliyoruz
                .Include(d => d.Sinif)          // Sınıfı ekliyoruz
                .Include(d => d.Donem)          // Dönemi ekliyoruz
                .ToListAsync();

            return View(dersler);
        }
         // Ders silme işlemi
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Sil(int id)
        {
            var ders = _context.Dersler.Include(d => d.DersProgramlari).FirstOrDefault(d => d.DersID == id);
            if (ders == null)
            {
                return NotFound();
            }

            // Eğer derse ait programlar varsa onları da silebiliriz
            if (ders.DersProgramlari != null)
            {
                _context.DersProgramlari.RemoveRange(ders.DersProgramlari);
            }

            _context.Dersler.Remove(ders);
            _context.SaveChanges();

            return RedirectToAction("Liste");
        }
    }
}
