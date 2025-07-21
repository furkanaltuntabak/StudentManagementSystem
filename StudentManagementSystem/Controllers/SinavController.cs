using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StudentManagementSystem.Data;

namespace StudentManagementSystem.Controllers
{

    public class SinavController : Controller
    {
        private readonly AppDbContext _context;

        public SinavController(AppDbContext context)
        {
            _context = context;
        }

        // Sınav oluşturma sayfası
        // Sınav oluşturma sayfası
        [HttpGet]
        public IActionResult Ekle()
        {
            // Dersleri, derslikleri ve öğretim elemanlarını al
            var dersler = _context.Dersler.ToList();
            var derslikler = _context.Derslikler.ToList();
            var ogretimElemanlari = _context.Kullanicilar.Where(k => k.RolID == 2).ToList();  // Öğretim elemanlarını al (RolID = 2 diyelim)

            // ViewBag üzerinden bu verileri gönderiyoruz
            ViewBag.Dersler = new SelectList(dersler, "DersID", "DersAdi");
            ViewBag.Derslikler = new SelectList(derslikler, "DerslikID", "DerslikAdi");
            ViewBag.OgretimElemanlari = new SelectList(ogretimElemanlari, "KullaniciID", "AdSoyad");

            return View();
        }

        // Sınav kaydetme işlemi
        [HttpPost]
        public IActionResult Ekle(Sinav sinav)
        {
            if (ModelState.IsValid)
            {
                // Çakışma Kontrolü
                var seciliDers = _context.Dersler.FirstOrDefault(d => d.DersID == sinav.DersID);

                // Derslik çakışma kontrolü
                bool derslikCakisma = _context.Sinavlar
                    .Any(s =>
                        s.DerslikID == sinav.DerslikID &&
                        s.Tarih.Date == sinav.Tarih.Date &&  // Aynı gün olması gerekir
                        s.Saat == sinav.Saat);  // Aynı saatte başka bir sınav varsa çakışma

                // Öğretim elemanı çakışma kontrolü
                bool hocaCakisma = _context.Sinavlar
                    .Any(s =>
                        s.OgretimElemaniID == sinav.OgretimElemaniID &&  // Aynı öğretim elemanı
                        s.Tarih.Date == sinav.Tarih.Date &&  // Aynı gün olması gerekir
                        s.Saat == sinav.Saat);  // Aynı saatte başka bir sınav varsa çakışma

                if (derslikCakisma)
                {
                    // Derslik çakışması var
                    ViewBag.Hata = "Bu derslikte, belirtilen gün ve saatte başka bir sınav bulunmaktadır.";
                    return View(sinav);  // Hata mesajıyla aynı sayfaya döner
                }

                if (hocaCakisma)
                {
                    // Öğretim elemanı çakışması var
                    ViewBag.Hata = "Bu öğretim elemanı aynı gün ve saatte başka bir sınavda bulunmaktadır.";
                    return View(sinav);  // Hata mesajıyla aynı sayfaya döner
                }

                // Çakışma yoksa sınavı kaydet
                _context.Sinavlar.Add(sinav);
                _context.SaveChanges();
                return RedirectToAction("Liste", "Sinav");  // Başarıyla kaydedildiyse sınavları listele
            }

            // Eğer model geçerli değilse, dersleri, derslikleri ve öğretim elemanlarını yeniden yükle
            var dersler = _context.Dersler.ToList();
            var derslikler = _context.Derslikler.ToList();
            var ogretimElemanlari = _context.Kullanicilar.Where(k => k.RolID == 2).ToList();  // Öğretim elemanlarını al (RolID = 2)

            ViewBag.Dersler = new SelectList(dersler, "DersID", "DersAdi");
            ViewBag.Derslikler = new SelectList(derslikler, "DerslikID", "DerslikAdi");
            ViewBag.OgretimElemanlari = new SelectList(ogretimElemanlari, "KullaniciID", "AdSoyad");

            return View(sinav);  // Geçerli değilse hata mesajlarıyla aynı sayfaya geri döner
        }

        public IActionResult Liste()
        {
            var sinavlar = _context.Sinavlar
                                .Include(s => s.Ders)  // Ders ilişkisini ekleyelim
                                .Include(s => s.Derslik)  // Derslik ilişkisini ekleyelim
                                .Include(s => s.OgretimElemani)  // Öğretim elemanı ilişkisini ekleyelim
                                .ToList();

            return View(sinavlar);  // Sinavları View'a gönderiyoruz
        }
        // SinavController - Sınav güncelleme sayfası
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var sinav = _context.Sinavlar
                                .Include(s => s.Ders)
                                .Include(s => s.Derslik)
                                .Include(s => s.OgretimElemani)
                                .FirstOrDefault(s => s.SinavID == id);

            if (sinav == null)
            {
                return NotFound();  // Eğer sınav bulunamazsa hata sayfası
            }
            

            // Seçenekleri yükle (Dersler, Derslikler, Öğretim Elemanları)
            ViewBag.Dersler = new SelectList(_context.Dersler, "DersID", "DersAdi", sinav.DersID);
            ViewBag.Derslikler = new SelectList(_context.Derslikler, "DerslikID", "DerslikAdi", sinav.DerslikID);
            ViewBag.OgretimElemanlari = new SelectList(_context.Kullanicilar.Where(k => k.RolID == 2), "KullaniciID", "AdSoyad", sinav.OgretimElemaniID);

            return View(sinav);
        }

        [HttpPost]
        public IActionResult Edit(Sinav sinav)
        {
            if (ModelState.IsValid)
            {
                _context.Sinavlar.Update(sinav);
                _context.SaveChanges();
                return RedirectToAction("Liste");  // Güncelleme başarılıysa sınavlar listesine yönlendir
            }
            
            // Seçenekleri yeniden yükle (Dersler, Derslikler, Öğretim Elemanları)
            ViewBag.Dersler = new SelectList(_context.Dersler, "DersID", "DersAdi", sinav.DersID);
            ViewBag.Derslikler = new SelectList(_context.Derslikler, "DerslikID", "DerslikAdi", sinav.DerslikID);
            ViewBag.OgretimElemanlari = new SelectList(_context.Kullanicilar.Where(k => k.RolID == 2), "KullaniciID", "AdSoyad", sinav.OgretimElemaniID);

            return View(sinav);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var sinav = _context.Sinavlar.FirstOrDefault(s => s.SinavID == id);
            if (sinav != null)
            {
                _context.Sinavlar.Remove(sinav);
                _context.SaveChanges();
            }

            return RedirectToAction("liste");
        }

        public IActionResult Create()
        {
            // Sınıfları çekip dropdown için ViewBag'e aktaralım
            ViewBag.Siniflar = new SelectList(_context.Siniflar.OrderBy(s => s.SinifAdi).ToList(), "SinifID", "SinifAdi");
            // Sadece RolID 2 olanları al
            ViewBag.Ogretmenler = new SelectList(
                _context.Kullanicilar.Where(x => x.RolID == 2).ToList(),
                "KullaniciID",
                "AdSoyad"
            );
            ViewBag.Dersler = new SelectList(
            _context.Dersler.ToList(),
            "DersID",
            "DersAdi"
           );

            return View();
        }
        [HttpPost]
[ValidateAntiForgeryToken]
public IActionResult Create(int sinifID ,int ogretmenID, int dersID)
{
     var secilenOgretmen = _context.Kullanicilar.FirstOrDefault(x => x.KullaniciID == ogretmenID);
    ViewBag.GozetmenAdi = secilenOgretmen?.AdSoyad;
      var secilenDers = _context.Dersler.FirstOrDefault(x => x.DersID == dersID);
   var ogrenciler = _context.Kullanicilar
    .Where(k => k.SinifID == sinifID && k.RolID == 1)
    .ToList() // Veriyi önce belleğe alıyoruz
    .OrderBy(x => Guid.NewGuid()) // Sonra rastgele sıralıyoruz (LINQ to Objects)
    .ToList();
  TempData["GozetmenAdi"] = secilenOgretmen?.AdSoyad;
    TempData["DersAdi"] = secilenDers?.DersAdi;
    int amfiID = 1;
    int d108ID = 3;
    int amfiKapasite = 60;
    int d108Kapasite = 30;
    int toplamKapasite = amfiKapasite + d108Kapasite;

    if (ogrenciler.Count > toplamKapasite)
    {
        ModelState.AddModelError("", "Öğrenci sayısı toplam derslik kapasitesini aşıyor.");
        ViewBag.Siniflar = new SelectList(_context.Siniflar.OrderBy(s => s.SinifAdi).ToList(), "SinifID", "SinifAdi");
        return View();
    }

    var oturmaPlanlari = new List<SinavOturmaPlani>();
    int index = 0;

    // AMFİ YERLEŞTİR
    for (int sira = 1; sira <= 10 && index < ogrenciler.Count && index < amfiKapasite; sira++)
    {
        for (int koltuk = 1; koltuk <= 6 && index < amfiKapasite && index < ogrenciler.Count; koltuk++)
        {
            oturmaPlanlari.Add(new SinavOturmaPlani
            {
                SinifID = sinifID,
                DerslikID = amfiID,
                OgrenciID = ogrenciler[index].KullaniciID,
                SiraNo = sira,
                KoltukNo = koltuk
            });
            index++;
        }
    }

    // D108 YERLEŞTİR
    for (int sira = 1; sira <= 10 && index < ogrenciler.Count; sira++)
    {
        for (int koltuk = 1; koltuk <= 4 && index < ogrenciler.Count; koltuk++)
        {
            oturmaPlanlari.Add(new SinavOturmaPlani
            {
                SinifID = sinifID,
                DerslikID = d108ID,
                OgrenciID = ogrenciler[index].KullaniciID,
                SiraNo = sira,
                KoltukNo = koltuk
            });
            index++;
        }
    }

    _context.SinavOturmaPlanlari.AddRange(oturmaPlanlari);
    _context.SaveChanges();

    return RedirectToAction("ProgramListe", new { sinifid = sinifID });
}


    public IActionResult ProgramListe(int sinifid)
    {
        if (sinifid == 0)
        return RedirectToAction("ProgramListe", new { sinifid = 1 });

        var planlar = _context.SinavOturmaPlanlari
            .Where(p => p.SinifID == sinifid)
            .Include(p => p.Derslik)
            .Include(p => p.Ogrenci)
            .ToList();

        ViewBag.SinifAdi = sinifid + ". Sınıf";
        return View(planlar);
    }

        [HttpPost]
        public IActionResult Sil(int id)
        {
            var plan = _context.SinavOturmaPlanlari.Find(id);
            if (plan != null)
            {
                int sinifId = plan.SinifID;
                _context.SinavOturmaPlanlari.Remove(plan);
                _context.SaveChanges();
                return RedirectToAction("ProgramListe", new { sinifid = sinifId });
            }
            return RedirectToAction("ProgramListe"); // Eğer silinecek plan yoksa default dönüş
        }
        [HttpPost]
        public IActionResult TumunuSil()
        {
            var tumPlanlar = _context.SinavOturmaPlanlari.ToList();

            if (tumPlanlar.Any())
            {
                _context.SinavOturmaPlanlari.RemoveRange(tumPlanlar);
                _context.SaveChanges();
            }

            return RedirectToAction("ProgramListe");
        }
        [HttpGet]
        public IActionResult OgretimElemaniSinavlari()
        {
            var kullaniciID = HttpContext.Session.GetInt32("KullaniciID");
            if (kullaniciID == null)
                return RedirectToAction("Login", "Account");

            var sinavlar = _context.Sinavlar
                .Include(s => s.Ders)
                .Include(s => s.Derslik)
                .Include(s => s.OgretimElemani)
                .Where(s => s.OgretimElemaniID == kullaniciID)
                .ToList();

            return View("OgretimElemaniSinavlari", sinavlar); // View adını istediğin gibi
        }
  
        [HttpGet]
        public IActionResult NotAl(int id)
        {
            var sinav = _context.Sinavlar
                                .Include(s => s.Ders)
                                .FirstOrDefault(s => s.SinavID == id);

            if (sinav == null) return NotFound();

            ViewBag.SinavID = sinav.SinavID;
            ViewBag.DersAdi = sinav.Ders?.DersAdi;
            return View();
        }

        [HttpPost]
public IActionResult NotAl(int sinavID, string notMetni)
{
    var sinav = _context.Sinavlar.Find(sinavID);
    if (sinav == null) return NotFound();

    var ogretimElemaniID = HttpContext.Session.GetInt32("KullaniciID"); // Öğretmeni al

    var not = new SinavNot
    {
        SinavID = sinavID,
        NotMetni = notMetni,
        OgretimElemaniID = ogretimElemaniID
    };

    _context.SinavNotlari.Add(not);
    _context.SaveChanges();

    return RedirectToAction("OgretimElemaniSinavlari");
}


      public IActionResult NotlariGoster()
{
    var notlar = _context.SinavNotlari
                         .Include(n => n.Sinav)
                             .ThenInclude(s => s.Ders)
                         .Include(n => n.OgretimElemani) // 🟢 Bu şart!
                         .OrderByDescending(n => n.EklenmeTarihi)
                         .ToList();

    return View(notlar);
}

         public IActionResult NotuGoster(int id)
{
    var not = _context.SinavNotlari
                      .Include(n => n.Sinav)
                          .ThenInclude(s => s.Ders)
                      .Include(n => n.OgretimElemani) // 🟢 EKLENDİ!
                      .FirstOrDefault(n => n.SinavID == id);

    if (not == null)
    {
        TempData["Mesaj"] = "Bu sınav için henüz not eklenmemiş.";
        return RedirectToAction("Index");
    }

    return View(not);
}





    }
}