using Microsoft.EntityFrameworkCore;

namespace StudentManagementSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Rol> Roller { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Sinif> Siniflar { get; set; }
        public DbSet<Donem> Donemler { get; set; }

        public DbSet<Derslik> Derslikler { get; set; }
        public DbSet<DersProgrami> DersProgramlari { get; set; }
        public DbSet<Sinav> Sinavlar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Başlangıç rolleri
            modelBuilder.Entity<Rol>().HasData(
                new Rol { RolID = 1, RolAdi = "Öğrenci" },
                new Rol { RolID = 2, RolAdi = "Öğretim Elemanı" },
                new Rol { RolID = 3, RolAdi = "Bölüm Sekreteri" },
                new Rol { RolID = 4, RolAdi = "Bölüm Başkanı" }
            );
           
            modelBuilder.Entity<Ders>().HasData(
                new Ders
                {
                    DersID = 1,
                    DersAdi = "Programlama II",
                    OgretimElemaniID = 2,
                    SinifID = 1,
                    DonemID = 2
                },
                new Ders
                {
                    DersID = 2,
                    DersAdi = "Matematik II",
                    OgretimElemaniID = 3,
                    SinifID = 1,
                    DonemID = 2
                },
                new Ders
                {
                    DersID = 3,
                    DersAdi = "Fizik II",
                    OgretimElemaniID = 4,
                    SinifID = 1,
                    DonemID = 2
                },
                new Ders
                {
                    DersID = 4,
                    DersAdi = "Programlama Laboratuvarı II",
                    OgretimElemaniID = 2,
                    SinifID = 1,
                    DonemID = 2
                },
                new Ders
                {
                    DersID = 5,
                    DersAdi = "Lineer Cebir",
                    OgretimElemaniID = 5,
                    SinifID = 1,
                    DonemID = 2
                },
                new Ders
                {
                    DersID = 6,
                    DersAdi = "Web Teknolojileri",
                    OgretimElemaniID = 6,
                    SinifID = 1,
                    DonemID = 2
                },
                new Ders
                {
                    DersID = 7,
                    DersAdi = "Kariyer Planlama ",
                    OgretimElemaniID = 7,
                    SinifID = 1,
                    DonemID = 2
                },
                new Ders
                {
                    DersID = 8,
                    DersAdi = "Türk Dili II",
                    OgretimElemaniID = 8,
                    SinifID = 1,
                    DonemID = 2
                },
                new Ders
                {
                    DersID = 9,
                    DersAdi = "Atatürk İlkeleri ve İnkılap Tarihi II",
                    OgretimElemaniID = 9,
                    SinifID = 1,
                    DonemID = 2
                },
                new Ders
                {
                    DersID = 10,
                    DersAdi = "Atatürk İlkeleri ve İnkılap Tarihi I",
                    OgretimElemaniID = 9,
                    SinifID = 1,
                    DonemID = 1
                },
                new Ders
                {
                    DersID = 11,
                    DersAdi = "	Fizik I",
                    OgretimElemaniID = 4,
                    SinifID = 1,
                    DonemID = 1
                },
                new Ders
                {
                    DersID = 12,
                    DersAdi = "Matematik I",
                    OgretimElemaniID = 3,
                    SinifID = 1,
                    DonemID = 1
                },
                new Ders
                {
                    DersID = 13,
                    DersAdi = "Mesleki İngilizce",
                    OgretimElemaniID = 10,
                    SinifID = 1,
                    DonemID = 1
                },
                new Ders
                {
                    DersID = 14,
                    DersAdi = "Programlama I",
                    OgretimElemaniID = 2,
                    SinifID = 1,
                    DonemID = 1
                },
                new Ders
                {
                    DersID = 15,
                    DersAdi = "Programlama Laboratuvarı I",
                    OgretimElemaniID = 6,
                    SinifID = 1,
                    DonemID = 1
                },
                new Ders
                {
                    DersID = 16,
                    DersAdi = "Türk Dili I (UE)",
                    OgretimElemaniID = 8,
                    SinifID = 1,
                    DonemID = 1
                },
                new Ders
                {
                    DersID = 17,
                    DersAdi = "Yazılım Mühendisliğine Giriş",
                    OgretimElemaniID = 11,
                    SinifID = 1,
                    DonemID = 1
                },
                new Ders
                {
                    DersID = 18,
                    DersAdi = "Bilgisayar Mimarisi ve Mantıksal Tasarım",
                    OgretimElemaniID = 12,
                    SinifID = 2,
                    DonemID = 3
                },
                new Ders
                {
                    DersID = 19,
                    DersAdi = "Diferansiyel Denklemler",
                    OgretimElemaniID = 3,
                    SinifID = 2,
                    DonemID = 3
                },
                new Ders
                {
                    DersID = 20,
                    DersAdi = "Nesneye Yönelik Programlama",
                    OgretimElemaniID = 7,
                    SinifID = 2,
                    DonemID = 3
                },
                new Ders
                {
                    DersID = 21,
                    DersAdi = "Programlama Laboratuvarı III",
                    OgretimElemaniID = 11,
                    SinifID = 2,
                    DonemID = 3
                },
                new Ders
                {
                    DersID = 22,
                    DersAdi = "Sayısal Analiz",
                    OgretimElemaniID = 10,
                    SinifID = 2,
                    DonemID = 3
                },
                new Ders
                {
                    DersID = 23,
                    DersAdi = "Veri Yapıları ve Algoritmalar",
                    OgretimElemaniID = 13,
                    SinifID = 2,
                    DonemID = 3
                },
                new Ders
                {
                    DersID = 24,
                    DersAdi = "Yazılım Gereksinimleri Analizi",
                    OgretimElemaniID = 11,
                    SinifID = 2,
                    DonemID = 3
                },
                new Ders
                {
                    DersID = 25,
                    DersAdi = "Algoritma Analizi",
                    OgretimElemaniID = 11,
                    SinifID = 2,
                    DonemID = 4
                },
                new Ders
                {
                    DersID = 26,
                    DersAdi = "Ayrık Matematik",
                    OgretimElemaniID = 7,
                    SinifID = 2,
                    DonemID = 4
                },
                new Ders
                {
                    DersID = 27,
                    DersAdi = "Bilgisayar Organizasyonu",
                    OgretimElemaniID = 12,
                    SinifID = 2,
                    DonemID = 4
                },
                new Ders
                {
                    DersID = 28,
                    DersAdi = "Olasılık ve Raslantı Değişkenleri",
                    OgretimElemaniID = 14,
                    SinifID = 2,
                    DonemID = 4
                },
                new Ders
                {
                    DersID = 29,
                    DersAdi = "Otomata Teorisi",
                    OgretimElemaniID = 15,
                    SinifID = 2,
                    DonemID = 4
                },
                new Ders
                {
                    DersID = 30,
                    DersAdi = "Web Programlama",
                    OgretimElemaniID = 7,
                    SinifID = 2,
                    DonemID = 4
                },
                new Ders
                {
                    DersID = 31,
                    DersAdi = "Yazılım Mimarileri ve Tasarım",
                    OgretimElemaniID = 6,
                    SinifID = 2,
                    DonemID = 4
                },
                new Ders
                {
                    DersID = 32,
                    DersAdi = "Java Programlama",
                    OgretimElemaniID = 13,
                    SinifID = 3,
                    DonemID = 5
                },
                new Ders
                {
                    DersID = 33,
                    DersAdi = "Temel Afet",
                    OgretimElemaniID = 16,
                    SinifID = 3,
                    DonemID = 5
                },
                new Ders
                {
                    DersID = 34,
                    DersAdi = "Veritabanı Yönetim Sistemleri",
                    OgretimElemaniID = 6,
                    SinifID = 3,
                    DonemID = 5
                },
                new Ders
                {
                    DersID = 35,
                    DersAdi = "Yazılım Geliştirme-I",
                    OgretimElemaniID = 10,
                    SinifID = 3,
                    DonemID = 5
                },
                new Ders
                {
                    DersID = 36,
                    DersAdi = "Yazılım Test ve Doğrulama",
                    OgretimElemaniID = 7,
                    SinifID = 3,
                    DonemID = 5
                },
                new Ders
                {
                    DersID = 37,
                    DersAdi = "İşletim Sistemleri",
                    OgretimElemaniID = 6,
                    SinifID = 3,
                    DonemID = 5
                },
                new Ders
                {
                    DersID = 38,
                    DersAdi = "Bilgi Güvenliği",
                    OgretimElemaniID = 11,
                    SinifID = 3,
                    DonemID = 6
                },
                new Ders
                {
                    DersID = 39,
                    DersAdi = "Linux Temelleri",
                    OgretimElemaniID = 17,
                    SinifID = 3,
                    DonemID = 6
                },
                new Ders
                {
                    DersID = 40,
                    DersAdi = "Makine Öğrenmesi Temelleri",
                    OgretimElemaniID = 10,
                    SinifID = 3,
                    DonemID = 6
                },
                new Ders
                {
                    DersID = 41,
                    DersAdi = "	Mobil Programlama",
                    OgretimElemaniID = 18,
                    SinifID = 3,
                    DonemID = 6
                },
                new Ders
                {
                    DersID = 42,
                    DersAdi = "Uzaktan Öğretim",
                    OgretimElemaniID = 19,
                    SinifID = 3,
                    DonemID = 6
                },
                new Ders
                {
                    DersID = 43,
                    DersAdi = "Yazılım Geliştirme-II",
                    OgretimElemaniID = 11,
                    SinifID = 3,
                    DonemID = 6
                },
                new Ders
                {
                    DersID = 44,
                    DersAdi = "Yazılım Proje Yönetimi",
                    OgretimElemaniID = 13,
                    SinifID = 3,
                    DonemID = 6
                },
                new Ders
                {
                    DersID = 45,
                    DersAdi = "Oyun Programlama",
                    OgretimElemaniID = 20,
                    SinifID = 4,
                    DonemID = 7
                },
                new Ders
                {
                    DersID = 46,
                    DersAdi = "Doğal Dil İşleme",
                    OgretimElemaniID = 6,
                    SinifID = 4,
                    DonemID = 7
                },
                new Ders
                {
                    DersID = 47,
                    DersAdi = "Bilgisayar Grafikleri",
                    OgretimElemaniID = 2,
                    SinifID = 4,
                    DonemID = 7
                },
                new Ders
                {
                    DersID = 48,
                    DersAdi = "Yapay Sinir Ağları",
                    OgretimElemaniID = 10,
                    SinifID = 4,
                    DonemID = 7
                },
                new Ders
                {
                    DersID = 49,
                    DersAdi = "Yazılım Tasarımı",
                    OgretimElemaniID = 11,
                    SinifID = 4,
                    DonemID = 7
                },
                new Ders
                {
                    DersID = 50,
                    DersAdi = "Derin Öğrenme",
                    OgretimElemaniID = 2,
                    SinifID = 4,
                    DonemID = 7
                },
                new Ders
                {
                    DersID = 51,
                    DersAdi = "Görüntü İşleme",
                    OgretimElemaniID = 11,
                    SinifID = 4,
                    DonemID = 7
                },
                new Ders
                {
                    DersID = 52,
                    DersAdi = "Nesnelerin İnterneti",
                    OgretimElemaniID = 12,
                    SinifID = 4,
                    DonemID = 7
                },
                new Ders
                {
                    DersID = 53,
                    DersAdi = " Yapay Zeka ve Uzman Sistemler",
                    OgretimElemaniID = 21,
                    SinifID = 4,
                    DonemID = 8
                },
                new Ders
                {
                    DersID = 54,
                    DersAdi = "Metin Madenciliği",
                    OgretimElemaniID = 2,
                    SinifID = 4,
                    DonemID = 8
                },
                new Ders
                {
                    DersID = 55,
                    DersAdi = "Veri Gizleme",
                    OgretimElemaniID = 11,
                    SinifID = 4,
                    DonemID = 8
                },
                new Ders
                {
                    DersID = 56,
                    DersAdi = "İleri Veritabanı Sistemleri",
                    OgretimElemaniID = 13,
                    SinifID = 4,
                    DonemID = 8
                },
                new Ders
                {
                    DersID = 57,
                    DersAdi = "Robot Programlama",
                    OgretimElemaniID = 7,
                    SinifID = 4,
                    DonemID = 8
                },
                new Ders
                {
                    DersID = 58,
                    DersAdi = " Yazılım Kalite Güvencesi",
                    OgretimElemaniID = 12,
                    SinifID = 4,
                    DonemID = 8
                },
                new Ders
                {
                    DersID = 59,
                    DersAdi = "Kablosuz Ağlar",
                    OgretimElemaniID = 22,
                    SinifID = 4,
                    DonemID = 8
                },
                new Ders
                {
                    DersID = 60,
                    DersAdi = "Bitirme Çalışması",
                    OgretimElemaniID = 12,
                    SinifID = 4,
                    DonemID = 8
                }
                
            
                
            );

          
             modelBuilder.Entity<Sinif>().HasData(
                new Sinif
                {
                    SinifID = 1,
                    SinifAdi = "1. Sınıf"
                },
                new Sinif
                {
                    SinifID = 2,
                    SinifAdi = "2. Sınıf"
                },
                new Sinif 
                { 
                    SinifID = 3, 
                    SinifAdi = "3. Sınıf" 
                },
                new Sinif 
                { 
                    SinifID = 4, 
                    SinifAdi = "4. Sınıf" 
                }
            );
            modelBuilder.Entity<Donem>().HasData(
                new Donem { DonemID = 1, DonemAdi = "1. Sınıf Güz Dönemi" },
                new Donem { DonemID = 2, DonemAdi = "1. Sınıf Bahar Dönemi" },
                new Donem { DonemID = 3, DonemAdi = "2. Sınıf Güz Dönemi" },
                new Donem { DonemID = 4, DonemAdi = "2. Sınıf Bahar Dönemi" },
                new Donem { DonemID = 5, DonemAdi = "3. Sınıf Güz Dönemi" },
                new Donem { DonemID = 6, DonemAdi = "3. Sınıf Bahar Dönemi" },
                new Donem { DonemID = 7, DonemAdi = "4. Sınıf Güz Dönemi" },
                new Donem { DonemID = 8, DonemAdi = "4. Sınıf Bahar Dönemi" }
            );

            modelBuilder.Entity<Derslik>().HasData(
                new Derslik
                {
                    DerslikID = 1,
                    DerslikAdi = "Amfi",
                    Kapasite = 100
                },
                new Derslik
                {
                    DerslikID = 2,
                    DerslikAdi = "Lab",
                    Kapasite = 100
                },
                new Derslik
                {
                    DerslikID = 3,
                    DerslikAdi = "D-108",
                    Kapasite = 100
                },
                new Derslik
                {
                    DerslikID = 4,
                    DerslikAdi = "Uzaktan Eğitim (UE)",
                    Kapasite = 300
                }
            );
            modelBuilder.Entity<Kullanici>().HasData(
                new Kullanici
                {
                    KullaniciID = 2,
                    AdSoyad = "İrfan Kösesoy",
                    Eposta = "İrfan.Kosesoy@uni.edu",
                    Sifre = "1234", // sade testlik
                    RolID = 2 // Öğretim Elemanı
                },
                new Kullanici
                {
                    KullaniciID = 3,
                    AdSoyad = "Arzu Coşkun",
                    Eposta = "Arzu.Coşkun@uni.edu",
                    Sifre = "1234",
                    RolID = 2
                },
                new Kullanici
                {
                    KullaniciID = 4,
                    AdSoyad = "Tayfun Güray",
                    Eposta = "Tayfun.Güray@uni.edu",
                    Sifre = "1234",
                    RolID = 2
                },
                new Kullanici
                {
                    KullaniciID = 5,
                    AdSoyad = "Banu PAZAR",
                    Eposta = "Banu.pazar@uni.edu",
                    Sifre = "1234",
                    RolID = 2
                },
                new Kullanici
                {
                    KullaniciID = 6,
                    AdSoyad = "Hakan Gündüz",
                    Eposta = "Hakan.Gündüz@uni.edu",
                    Sifre = "1234",
                    RolID = 2
                },
                new Kullanici
                {
                    KullaniciID = 7,
                    AdSoyad = "Levent Bayındır",
                    Eposta = "Levent.Bayındır@uni.edu",
                    Sifre = "1234",
                    RolID = 2
                },
                new Kullanici
                {
                    KullaniciID = 8,
                    AdSoyad = "Fatma Üçler",
                    Eposta = "Fatma.Üçler@uni.edu",
                    Sifre = "1234",
                    RolID = 2
                },
                new Kullanici
                {
                    KullaniciID = 9,
                    AdSoyad = "Gülten Madendağ",
                    Eposta = "Gülten.Madendag@uni.edu",
                    Sifre = "1234",
                    RolID = 2
                },
                new Kullanici
                {
                    KullaniciID = 10,
                    AdSoyad = "Kaplan Kaplan",
                    Eposta = "Kaplan.Kaplan@uni.edu",
                    Sifre = "1234", 
                    RolID = 2 
                },
                new Kullanici
                {
                    KullaniciID = 11,
                    AdSoyad = "Zeki Konyar",
                    Eposta = "Zeki.Konyar@uni.edu",
                    Sifre = "1234", 
                    RolID = 2 
                },
                new Kullanici
                {
                    KullaniciID = 12,
                    AdSoyad = "Kerem Küçük",
                    Eposta = "Kerem.Küçük@uni.edu",
                    Sifre = "1234", 
                    RolID = 2 
                },
                new Kullanici
                {
                    KullaniciID = 13,
                    AdSoyad = "Samet Diri",
                    Eposta = "Samet.Diri@uni.edu",
                    Sifre = "1234", 
                    RolID = 2 
                },
                new Kullanici
                {
                    KullaniciID = 14,
                    AdSoyad = "Orhan Akbulut",
                    Eposta = "Orhan.Akbulut@uni.edu",
                    Sifre = "1234", 
                    RolID = 2 
                },
                new Kullanici
                {
                    KullaniciID = 15,
                    AdSoyad = "Onur Gök",
                    Eposta = "Onur.Gök@uni.edu",
                    Sifre = "1234", 
                    RolID = 2 
                },
                new Kullanici
                {
                    KullaniciID = 16,
                    AdSoyad = "İbrahim SERTÇELİK",
                    Eposta = "İbrahim.SERTÇELİK@uni.edu",
                    Sifre = "1234", 
                    RolID = 2 
                },
                new Kullanici
                {
                    KullaniciID = 17,
                    AdSoyad = "Serdar Solak",
                    Eposta = "Serdar.Solak@uni.edu",
                    Sifre = "1234", 
                    RolID = 2 
                },
                new Kullanici
                {
                    KullaniciID = 18,
                    AdSoyad = "Uğur Yıldız",
                    Eposta = "Uğur.Yıldız@uni.edu",
                    Sifre = "1234", 
                    RolID = 2 
                },
                new Kullanici
                {
                    KullaniciID = 19,
                    AdSoyad = "Yusuf Budak",
                    Eposta = "Yusuf.Budak@uni.edu",
                    Sifre = "1234", 
                    RolID = 2 
                },
                new Kullanici
                {
                    KullaniciID = 20,
                    AdSoyad = "Yavuz Selim Fatihoğlu",
                    Eposta = "Yavuz.Selim@uni.edu",
                    Sifre = "1234", 
                    RolID = 2 
                },
                new Kullanici
                {
                    KullaniciID = 21,
                    AdSoyad = "Radwan Ali Abdulghani Saleh",
                    Eposta = "Radwan.Ali@uni.edu",
                    Sifre = "1234", 
                    RolID = 2 
                },
                new Kullanici
                {
                    KullaniciID = 22,
                    AdSoyad = " Adnan Kavak",
                    Eposta = "Adnan.Kavak@uni.edu",
                    Sifre = "1234", 
                    RolID = 2 
                }
            );
            modelBuilder.Entity<DersProgrami>().HasData(
                new DersProgrami
                {
                    DersProgramiID = 1,
                    DersID = 1,
                    DerslikID = 1,
                    Gun = "Pazartesi",
                    Saat = "10:00-11:30"
                },
                new DersProgrami
                {
                    DersProgramiID = 2,
                    DersID = 2,
                    DerslikID = 2,
                    Gun = "Çarşamba",
                    Saat = "13:00"
                }
            );
           




        }
    }
}
