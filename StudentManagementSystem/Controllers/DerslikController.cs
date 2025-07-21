using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StudentManagementSystem.Data;

namespace StudentManagementSystem.Controllers
{

    public class DerslikController : Controller
    {

        private readonly AppDbContext _context;

        public DerslikController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /Derslik
        public IActionResult Liste()
        {
            var derslikler = _context.Derslikler.ToList();
            return View(derslikler);
        }
        public IActionResult DersliktekiDersler(int id)
        {
            // Derslikteki dersleri almak için DersProgrami üzerinden filtreleme yapıyoruz
            var dersler = _context.DersProgramlari
                                  .Where(dp => dp.DerslikID == id)  // DerslikID'ye göre filtreliyoruz
                                  .Include(dp => dp.Ders)
                                        .ThenInclude(d => d!.OgretimElemani)          // Ders bilgisini dahil ediyoruz
                                  .Select(dp => dp.Ders)            // Sadece Dersleri alıyoruz
                                  .Distinct()                        // Tekrarlanan dersleri engelliyoruz
                                  .ToList();

            if (dersler == null || !dersler.Any())
            {
                return NotFound();  // Eğer ders yoksa 404 döndürüyoruz
            }

            return View(dersler);  // Dersleri view'a gönderiyoruz
        }
        public IActionResult Duzenle(int id)
        {
            var derslik = _context.Derslikler.Find(id);
            if (derslik == null)
                return NotFound();

            return View(derslik);
        }
            [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Duzenle(int id, Derslik model)
        {
            if (id != model.DerslikID)
                return BadRequest();

            if (!ModelState.IsValid)
                return View(model);

            var derslik = _context.Derslikler.Find(id);
            if (derslik == null)
                return NotFound();

            derslik.SiraSayisi = model.SiraSayisi;
            derslik.KoltukSayisi = model.KoltukSayisi;
            derslik.Kapasite = model.SiraSayisi * model.KoltukSayisi;

            _context.SaveChanges();

            return RedirectToAction("Liste"); // veya uygun liste sayfası
        }


        

    }
}