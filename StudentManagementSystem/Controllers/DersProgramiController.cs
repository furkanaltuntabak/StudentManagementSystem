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
    // Seçilen dersin dönemini bul
    var seciliDers = _context.Dersler
        .Include(d => d.Donem)
        .FirstOrDefault(d => d.DersID == model.DersID);

    if (seciliDers == null)
    {
        ViewBag.Hata = "Seçilen ders bulunamadı.";
        ViewBag.Dersler = new SelectList(_context.Dersler, "DersID", "DersAdi", model.DersID);
        ViewBag.Derslikler = new SelectList(_context.Derslikler, "DerslikID", "DerslikAdi", model.DerslikID);
        return View(model);
    }

    // Aynı yarıyılda (Güz veya Bahar) çakışma kontrolü
    var cakismaVar = _context.DersProgramlari
    .Include(dp => dp.Ders)
    .Any(dp =>
        dp.Gun == model.Gun &&
        dp.Saat == model.Saat &&
        dp.Ders.DonemID % 2 == seciliDers.DonemID % 2 &&
        (
            dp.DerslikID == model.DerslikID || 
            dp.Ders.OgretimElemaniID == seciliDers.OgretimElemaniID
        )
    );


    if (cakismaVar)
    {
        ViewBag.Hata = "Bu derslikte aynı yarıyılda (Güz/Bahar), belirtilen gün ve saatte başka bir ders var Ya da 1 Hoca aynı anda 1'den fazla ders veremez";
        ViewBag.Dersler = new SelectList(_context.Dersler, "DersID", "DersAdi", model.DersID);
        ViewBag.Derslikler = new SelectList(_context.Derslikler, "DerslikID", "DerslikAdi", model.DerslikID);
        return View(model);
    }

    if (ModelState.IsValid)
    {
        _context.DersProgramlari.Add(model);
        _context.SaveChanges();
        return RedirectToAction("Liste");
    }

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

            }
}
