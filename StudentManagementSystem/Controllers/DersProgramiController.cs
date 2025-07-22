using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Data;
using StudentManagementSystem.ViewModels;

namespace StudentManagementSystem.Controllers
{
    public class DersProgramiController : Controller
    {
        private readonly AppDbContext _context;

        public DersProgramiController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /DersProgrami/Ekle
        public IActionResult Ekle()
        {
            ViewBag.Dersler = new SelectList(_context.Dersler, "DersID", "DersAdi");
            ViewBag.Derslikler = new SelectList(_context.Derslikler, "DerslikID", "DerslikAdi");

            return View();
        }

        // POST: /DersProgrami/Ekle
        [HttpPost]
        public IActionResult Ekle(DersProgrami model)
        {
            var seciliDers = _context.Dersler
                .Include(d => d.Donem)
                .FirstOrDefault(d => d.DersID == model.DersID);

            if (seciliDers == null)
            {
                ViewBag.Hata = "Seçilen ders bulunamadı.";
                goto HazirlaView;
            }

            // Aynı yarıyılda (Güz/Bahar) derslik çakışması kontrolü
            bool derslikCakisma = _context.DersProgramlari
                .Include(dp => dp.Ders)
                .Any(dp =>
                    dp.Gun == model.Gun &&
                    dp.Saat == model.Saat &&
                    dp.DerslikID == model.DerslikID &&
                    dp.Ders.DonemID % 2 == seciliDers.DonemID % 2
                );

            // Aynı yarıyılda öğretim elemanı çakışması kontrolü
            bool hocaCakisma = _context.DersProgramlari
                .Include(dp => dp.Ders)
                .Any(dp =>
                    dp.Gun == model.Gun &&
                    dp.Saat == model.Saat &&
                    dp.Ders!.OgretimElemaniID == seciliDers.OgretimElemaniID &&
                    dp.Ders.DonemID % 2 == seciliDers.DonemID % 2
                );

            if (derslikCakisma)
            {
                ViewBag.Hata = "Bu derslikte, belirtilen gün ve saatte başka bir ders var.";
                goto HazirlaView;
            }

            if (hocaCakisma)
            {
                ViewBag.Hata = "Bu öğretim elemanı aynı gün ve saatte başka bir derste bulunuyor.";
                goto HazirlaView;
            }

            if (ModelState.IsValid)
            {
                _context.DersProgramlari.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Liste");
            }

        HazirlaView:
            ViewBag.Dersler = new SelectList(_context.Dersler, "DersID", "DersAdi", model.DersID);
            ViewBag.Derslikler = new SelectList(_context.Derslikler, "DerslikID", "DerslikAdi", model.DerslikID);
            return View(model);
        }





        // Opsiyonel: Eklenenleri listelemek için
        public IActionResult Liste(int? sinifID, int? donemID)
    {
        var viewModel = new DersProgramiListeViewModel
        {
            SinifID = sinifID,
            DonemID = donemID,
            Siniflar = _context.Siniflar
                        .Select(s => new SelectListItem
                        {
                            Value = s.SinifID.ToString(),
                            Text = s.SinifAdi
                        }).ToList(),
            Donemler = _context.Donemler
                        .Select(d => new SelectListItem
                        {
                            Value = d.DonemID.ToString(),
                            Text = d.DonemAdi
                        }).ToList()
        };

        var dersProgramlari = _context.DersProgramlari
            .Include(dp => dp.Ders)
                .ThenInclude(d => d!.OgretimElemani)
            .Include(dp => dp.Derslik)
            .AsQueryable();

        if (sinifID.HasValue)
        {
            dersProgramlari = dersProgramlari.Where(dp => dp.Ders!.SinifID == sinifID.Value);
        }

        if (donemID.HasValue)
        {
            dersProgramlari = dersProgramlari.Where(dp => dp.Ders!.DonemID == donemID.Value);
        }

        viewModel.DersProgramlari = dersProgramlari.ToList();

        return View(viewModel);
    }
        public IActionResult Delete(int id)
        {
            // Silmek istediğiniz ders programını ID'sine göre buluyoruz
            var dersProgrami = _context.DersProgramlari.FirstOrDefault(dp => dp.DersProgramiID == id);
            
            if (dersProgrami != null)
            {
                _context.DersProgramlari.Remove(dersProgrami); // Veriyi siliyoruz
                _context.SaveChanges(); // Değişiklikleri kaydediyoruz
            }

            return RedirectToAction("Liste"); // Silme işleminden sonra ders programları listesini tekrar gösteriyoruz
        }
      public IActionResult DersProgramim()
{
    var kullaniciID = HttpContext.Session.GetInt32("KullaniciID");

    if (kullaniciID == null)
    {
        return RedirectToAction("Login");
    }

    var ogretimElemani = _context.Kullanicilar
        .FirstOrDefault(k => k.KullaniciID == kullaniciID);

    if (ogretimElemani == null)
    {
        return NotFound("Kullanıcı bulunamadı.");
    }

    var dersProgrami = _context.DersProgramlari
        .Include(dp => dp.Ders)
            .ThenInclude(d => d.Donem)
        .Include(dp => dp.Ders)
            .ThenInclude(d => d.Sinif)
        .Include(dp => dp.Derslik)
        .Where(dp => dp.Ders != null && dp.Ders.OgretimElemaniID == ogretimElemani.KullaniciID)
        .ToList();

    return View(dersProgrami);
}





        public IActionResult GuncelleSaatler()
{
    var saatMap = new Dictionary<string, string>
    {
        { "09:00", "09:00-10:50" },
        { "11:00", "11:00-12:50" },
        { "13:00", "13:00-14:50" },
        { "15:00", "15:00-16:50" },
     
    };

    var dersProgramlari = _context.DersProgramlari.ToList();

    foreach (var dp in dersProgramlari)
    {
        if (saatMap.ContainsKey(dp.Saat))
        {
            dp.Saat = saatMap[dp.Saat];
        }
    }

    _context.SaveChanges();

    return Content("Saat güncellemeleri başarıyla yapıldı.");
}
public IActionResult OgrenciDersProgrami()
{
    var kullaniciId = HttpContext.Session.GetInt32("KullaniciID");
    var kullanici = _context.Kullanicilar.Include(k => k.Sinif).FirstOrDefault(k => k.KullaniciID == kullaniciId);
    
    if (kullanici == null)
    {
        return NotFound();  // Kullanıcı bulunamadı
    }

    var sinifID = kullanici.SinifID;
    var donemler = _context.Donemler.Select(d => new SelectListItem
    {
        Value = d.DonemID.ToString(),
        Text = d.DonemAdi
    }).ToList();

    // Öğrencinin ders programını al
    var dersProgrami = _context.DersProgramlari
        .Include(dp => dp.Ders)
        .Include(dp => dp.Derslik)
        .Where(dp => dp.Ders!.SinifID == sinifID)
        .ToList();

    var viewModel = new DersProgramiListeViewModel
    {
        DersProgramlari = dersProgrami,
        Donemler = donemler
    };

    return View(viewModel);
}



    }
            

            
}
