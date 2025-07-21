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
        public DbSet<SinavOturmaPlani> SinavOturmaPlanlari { get; set; }
        public DbSet<SinavNot> SinavNotlari { get; set; }

        public DbSet<KapiIsimligi> KapiIsimlikleri { get; set; }  // Kapı isimliği için DbSet
        public DbSet<Derslik> Derslikler { get; set; }
        public DbSet<DersProgrami> DersProgramlari { get; set; }
        public DbSet<Sinav> Sinavlar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
              modelBuilder.Entity<SinavOturmaPlani>()
        .HasOne(s => s.Ogrenci)
        .WithMany()  // Kullanıcı modeli içinde SinavOturmaPlanları koleksiyonu yoksa boş bırakılabilir
        .HasForeignKey(s => s.OgrenciID)
        .OnDelete(DeleteBehavior.Restrict);

    modelBuilder.Entity<SinavOturmaPlani>()
        .HasOne(s => s.Derslik)
        .WithMany()  // Derslikte Sinavlar koleksiyonu varsa
        .HasForeignKey(s => s.DerslikID);

    modelBuilder.Entity<SinavOturmaPlani>()
        .HasOne(s => s.Sinif)
        .WithMany()  // Sinif içinde koleksiyon yoksa boş bırak
        .HasForeignKey(s => s.SinifID);

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
                },new Kullanici
                {
                    KullaniciID = 23,  
                    AdSoyad = "Ahmet Yılmaz", 
                    Eposta = "ahmet.yilmaz@uni.edu",  
                    Sifre = "abcd1234",  
                    Numara = "2020501234",  // Öğrencinin öğrenci numarası (isteğe bağlı)
                    RolID = 1, 
                    SinifID = 1, 
                },new Kullanici
                {
                    KullaniciID = 25,
                    AdSoyad = "Bölüm Sekreteri 1",
                    Eposta = "bolumsek@uni.edu",
                    Sifre = "1234", 
                    RolID = 3

                },
                new Kullanici
                {
                    KullaniciID = 31,  
                    AdSoyad = "Ahmet Arslan", 
                    Eposta = "ahmet.arslan@uni.edu",  
                    Sifre = "1234",  
                    Numara = "2020501006",  
                    RolID = 1, 
                    SinifID = 1, 
                },
                new Kullanici
                {
                    KullaniciID = 32,  
                    AdSoyad = "Büşra Yılmaz", 
                    Eposta = "busra.yilmaz@uni.edu",  
                    Sifre = "1234",  
                    Numara = "2020501007",  
                    RolID = 1, 
                    SinifID = 1, 
                },
                new Kullanici
                {
                    KullaniciID = 33,  
                    AdSoyad = "Cemil Kılıç", 
                    Eposta = "cemil.kilic@uni.edu",  
                    Sifre = "1234",  
                    Numara = "2020501008",  
                    RolID = 1, 
                    SinifID = 1, 
                },
                new Kullanici
                {
                    KullaniciID = 34,  
                    AdSoyad = "Deniz Kaya", 
                    Eposta = "deniz.kaya@uni.edu",  
                    Sifre = "1234",  
                    Numara = "2020501009",  
                    RolID = 1, 
                    SinifID = 1, 
                },
                new Kullanici
                {
                    KullaniciID = 35,  
                    AdSoyad = "Elif Demir", 
                    Eposta = "elif.demir@uni.edu",  
                    Sifre = "1234",  
                    Numara = "2020501010",  
                    RolID = 1, 
                    SinifID = 1, 
                },
                new Kullanici
                {
                    KullaniciID = 36,  
                    AdSoyad = "Furkan Çelik", 
                    Eposta = "furkan.celik@uni.edu",  
                    Sifre = "1234",  
                    Numara = "2020501011",  
                    RolID = 1, 
                    SinifID = 1, 
                },
                new Kullanici
                {
                    KullaniciID = 37,  
                    AdSoyad = "Gökhan Akbaş", 
                    Eposta = "gokhan.akbas@uni.edu",  
                    Sifre = "1234",  
                    Numara = "2020501012",  
                    RolID = 1, 
                    SinifID = 1, 
                },
                new Kullanici
                {
                    KullaniciID = 38,  
                    AdSoyad = "Hüseyin Tekin", 
                    Eposta = "huseyin.tekin@uni.edu",  
                    Sifre = "1234",  
                    Numara = "2020501013",  
                    RolID = 1, 
                    SinifID = 1, 
                },
                new Kullanici
                {
                    KullaniciID = 39,  
                    AdSoyad = "İsmail Erdoğan", 
                    Eposta = "ismail.erdogan@uni.edu",  
                    Sifre = "1234",  
                    Numara = "2020501014",  
                    RolID = 1, 
                    SinifID = 1, 
                },
                new Kullanici
                {
                    KullaniciID = 40,  
                    AdSoyad = "Jale Bozkurt", 
                    Eposta = "jale.bozkurt@uni.edu",  
                    Sifre = "1234",  
                    Numara = "2020501015",  
                    RolID = 1, 
                    SinifID = 1, 
                },
                new Kullanici
                {
                    KullaniciID = 41,  
                    AdSoyad = "Kemal Özkan", 
                    Eposta = "kemal.ozkan@uni.edu",  
                    Sifre = "1234",  
                    Numara = "2020501016",  
                    RolID = 1, 
                    SinifID = 1, 
                },
                new Kullanici
                {
                    KullaniciID = 42,  
                    AdSoyad = "Lale Yıldız", 
                    Eposta = "lale.yildiz@uni.edu",  
                    Sifre = "1234",  
                    Numara = "2020501017",  
                    RolID = 1, 
                    SinifID = 1, 
                },
                new Kullanici
                {
                    KullaniciID = 43,  
                    AdSoyad = "Murat Akın", 
                    Eposta = "murat.akin@uni.edu",  
                    Sifre = "1234",  
                    Numara = "2020501018",  
                    RolID = 1, 
                    SinifID = 1, 
                },
                new Kullanici
                {
                    KullaniciID = 44,  
                    AdSoyad = "Nihan Güler", 
                    Eposta = "nihan.guler@uni.edu",  
                    Sifre = "1234",  
                    Numara = "2020501019",  
                    RolID = 1, 
                    SinifID = 1, 
                },
                new Kullanici
                {
                    KullaniciID = 45,  
                    AdSoyad = "Ozan Aydın", 
                    Eposta = "ozan.aydin@uni.edu",  
                    Sifre = "1234",  
                    Numara = "2020501020",  
                    RolID = 1, 
                    SinifID = 1, 
                },
                new Kullanici
                {
                    KullaniciID = 46,  
                    AdSoyad = "Pelin Çetin", 
                    Eposta = "pelin.cetin@uni.edu",  
                    Sifre = "1234",  
                    Numara = "2020501021",  
                    RolID = 1, 
                    SinifID = 1, 
                },
                new Kullanici
                {
                    KullaniciID = 47,  
                    AdSoyad = "Rıza Demirtaş", 
                    Eposta = "riza.demirtas@uni.edu",  
                    Sifre = "1234",  
                    Numara = "2020501022",  
                    RolID = 1, 
                    SinifID = 1, 
                },
                new Kullanici
                {
                    KullaniciID = 48,  
                    AdSoyad = "Sibel Koç", 
                    Eposta = "sibel.koc@uni.edu",  
                    Sifre = "1234",  
                    Numara = "2020501023",  
                    RolID = 1, 
                    SinifID = 1, 
                },
                new Kullanici
                {
                    KullaniciID = 49,  
                    AdSoyad = "Tuna Kalkan", 
                    Eposta = "tuna.kalkan@uni.edu",  
                    Sifre = "1234",  
                    Numara = "2020501024",  
                    RolID = 1, 
                    SinifID = 1, 
                },
                new Kullanici
                {
                    KullaniciID = 50,  
                    AdSoyad = "Uğur Doğan", 
                    Eposta = "ugur.dogan@uni.edu",  
                    Sifre = "1234",  
                    Numara = "2020501025",  
                    RolID = 1, 
                    SinifID = 1, 
                },
                new Kullanici
                {
                    KullaniciID = 53,   
                    AdSoyad = "Bölüm Başkanı",  
                    Eposta = "bolumbaskani@uni.edu",   
                    Sifre = "1234",   
                    RolID = 4,  
                  
                },
                    new Kullanici { KullaniciID = 60, AdSoyad = "Ali Yılmaz", Eposta = "ali.yilmaz@uni.edu", Sifre = "1234", Numara = "2020501060", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 61, AdSoyad = "Ayşe Demir", Eposta = "ayse.demir@uni.edu", Sifre = "1234", Numara = "2020501061", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 62, AdSoyad = "Mehmet Kara", Eposta = "mehmet.kara@uni.edu", Sifre = "1234", Numara = "2020501062", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 63, AdSoyad = "Zeynep Şahin", Eposta = "zeynep.sahin@uni.edu", Sifre = "1234", Numara = "2020501063", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 64, AdSoyad = "Emre Aydın", Eposta = "emre.aydin@uni.edu", Sifre = "1234", Numara = "2020501064", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 65, AdSoyad = "Fatma Yıldız", Eposta = "fatma.yildiz@uni.edu", Sifre = "1234", Numara = "2020501065", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 66, AdSoyad = "Ahmet Taş", Eposta = "ahmet.tas@uni.edu", Sifre = "1234", Numara = "2020501066", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 67, AdSoyad = "Elif Kurt", Eposta = "elif.kurt@uni.edu", Sifre = "1234", Numara = "2020501067", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 68, AdSoyad = "Mert Can", Eposta = "mert.can@uni.edu", Sifre = "1234", Numara = "2020501068", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 69, AdSoyad = "Buse Yalçın", Eposta = "buse.yalcin@uni.edu", Sifre = "1234", Numara = "2020501069", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 70, AdSoyad = "Oğuz Kaan", Eposta = "oguz.kaan@uni.edu", Sifre = "1234", Numara = "2020501070", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 71, AdSoyad = "Selin Polat", Eposta = "selin.polat@uni.edu", Sifre = "1234", Numara = "2020501071", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 72, AdSoyad = "Burak Güneş", Eposta = "burak.gunes@uni.edu", Sifre = "1234", Numara = "2020501072", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 73, AdSoyad = "Ceren Aksoy", Eposta = "ceren.aksoy@uni.edu", Sifre = "1234", Numara = "2020501073", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 74, AdSoyad = "Hasan Koç", Eposta = "hasan.koc@uni.edu", Sifre = "1234", Numara = "2020501074", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 75, AdSoyad = "Melis Tan", Eposta = "melis.tan@uni.edu", Sifre = "1234", Numara = "2020501075", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 76, AdSoyad = "Tuna Er", Eposta = "tuna.er@uni.edu", Sifre = "1234", Numara = "2020501076", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 77, AdSoyad = "Nazlı Gül", Eposta = "nazli.gul@uni.edu", Sifre = "1234", Numara = "2020501077", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 78, AdSoyad = "Onur Bayrak", Eposta = "onur.bayrak@uni.edu", Sifre = "1234", Numara = "2020501078", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 79, AdSoyad = "Simge Acar", Eposta = "simge.acar@uni.edu", Sifre = "1234", Numara = "2020501079", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 80, AdSoyad = "Baran Ateş", Eposta = "baran.ates@uni.edu", Sifre = "1234", Numara = "2020501080", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 81, AdSoyad = "İlayda Kılıç", Eposta = "ilayda.kilic@uni.edu", Sifre = "1234", Numara = "2020501081", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 82, AdSoyad = "Efe Demirtaş", Eposta = "efe.demirtas@uni.edu", Sifre = "1234", Numara = "2020501082", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 83, AdSoyad = "Sude Yüce", Eposta = "sude.yuce@uni.edu", Sifre = "1234", Numara = "2020501083", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 84, AdSoyad = "Kerem Bilgin", Eposta = "kerem.bilgin@uni.edu", Sifre = "1234", Numara = "2020501084", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 85, AdSoyad = "Zeliha Tuncel", Eposta = "zeliha.tuncel@uni.edu", Sifre = "1234", Numara = "2020501085", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 86, AdSoyad = "Hakan Özkan", Eposta = "hakan.ozkan@uni.edu", Sifre = "1234", Numara = "2020501086", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 87, AdSoyad = "Dilara Yılmaz", Eposta = "dilara.yilmaz@uni.edu", Sifre = "1234", Numara = "2020501087", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 88, AdSoyad = "Serkan Gültekin", Eposta = "serkan.gultekin@uni.edu", Sifre = "1234", Numara = "2020501088", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 89, AdSoyad = "Melek Şimşek", Eposta = "melek.simsek@uni.edu", Sifre = "1234", Numara = "2020501089", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 90, AdSoyad = "Enes Uçar", Eposta = "enes.ucar@uni.edu", Sifre = "1234", Numara = "2020501090", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 91, AdSoyad = "Tuğçe Kaya", Eposta = "tugce.kaya@uni.edu", Sifre = "1234", Numara = "2020501091", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 92, AdSoyad = "Yunus Emre", Eposta = "yunus.emre@uni.edu", Sifre = "1234", Numara = "2020501092", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 93, AdSoyad = "Naz Arslan", Eposta = "naz.arslan@uni.edu", Sifre = "1234", Numara = "2020501093", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 94, AdSoyad = "Berkay Gök", Eposta = "berkay.gok@uni.edu", Sifre = "1234", Numara = "2020501094", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 95, AdSoyad = "Necla Bozkurt", Eposta = "necla.bozkurt@uni.edu", Sifre = "1234", Numara = "2020501095", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 96, AdSoyad = "Taylan Ersoy", Eposta = "taylan.ersoy@uni.edu", Sifre = "1234", Numara = "2020501096", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 97, AdSoyad = "Gamze Kılıç", Eposta = "gamze.kilic@uni.edu", Sifre = "1234", Numara = "2020501097", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 98, AdSoyad = "Volkan Yalın", Eposta = "volkan.yalin@uni.edu", Sifre = "1234", Numara = "2020501098", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 99, AdSoyad = "İrem Akın", Eposta = "irem.akin@uni.edu", Sifre = "1234", Numara = "2020501099", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 100, AdSoyad = "Cansu Demirtaş", Eposta = "cansu.demirtas@uni.edu", Sifre = "1234", Numara = "2020501100", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 101, AdSoyad = "Yusuf Akman", Eposta = "yusuf.akman@uni.edu", Sifre = "1234", Numara = "2020501101", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 102, AdSoyad = "Sena Karaca", Eposta = "sena.karaca@uni.edu", Sifre = "1234", Numara = "2020501102", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 103, AdSoyad = "Kaan Erdem", Eposta = "kaan.erdem@uni.edu", Sifre = "1234", Numara = "2020501103", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 104, AdSoyad = "Merve Çetin", Eposta = "merve.cetin@uni.edu", Sifre = "1234", Numara = "2020501104", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 105, AdSoyad = "Okan Yüce", Eposta = "okan.yuce@uni.edu", Sifre = "1234", Numara = "2020501105", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 106, AdSoyad = "Beril Korkmaz", Eposta = "beril.korkmaz@uni.edu", Sifre = "1234", Numara = "2020501106", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 107, AdSoyad = "Furkan Duru", Eposta = "furkan.duru@uni.edu", Sifre = "1234", Numara = "2020501107", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 108, AdSoyad = "Gizem Uslu", Eposta = "gizem.uslu@uni.edu", Sifre = "1234", Numara = "2020501108", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 109, AdSoyad = "Ömer Faruk", Eposta = "omer.faruk@uni.edu", Sifre = "1234", Numara = "2020501109", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 110, AdSoyad = "Zehra Gök", Eposta = "zehra.gok@uni.edu", Sifre = "1234", Numara = "2020501110", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 111, AdSoyad = "Burcu Altın", Eposta = "burcu.altin@uni.edu", Sifre = "1234", Numara = "2020501111", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 112, AdSoyad = "Harun Bilgi", Eposta = "harun.bilgi@uni.edu", Sifre = "1234", Numara = "2020501112", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 113, AdSoyad = "Yasemin Tuna", Eposta = "yasemin.tuna@uni.edu", Sifre = "1234", Numara = "2020501113", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 114, AdSoyad = "Halil İbrahim", Eposta = "halil.ibrahim@uni.edu", Sifre = "1234", Numara = "2020501114", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 115, AdSoyad = "İlayda Şahin", Eposta = "ilayda.sahin@uni.edu", Sifre = "1234", Numara = "2020501115", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 116, AdSoyad = "Deniz Yaman", Eposta = "deniz.yaman@uni.edu", Sifre = "1234", Numara = "2020501116", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 117, AdSoyad = "Tunahan Erol", Eposta = "tunahan.erol@uni.edu", Sifre = "1234", Numara = "2020501117", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 118, AdSoyad = "Tuana Bal", Eposta = "tuana.bal@uni.edu", Sifre = "1234", Numara = "2020501118", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 119, AdSoyad = "Doğukan Keskin", Eposta = "dogukan.keskin@uni.edu", Sifre = "1234", Numara = "2020501119", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 120, AdSoyad = "Meltem Gür", Eposta = "meltem.gur@uni.edu", Sifre = "1234", Numara = "2020501120", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 121, AdSoyad = "Barış Kaya", Eposta = "baris.kaya@uni.edu", Sifre = "1234", Numara = "2020501121", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 122, AdSoyad = "Sibel Koç", Eposta = "sibel.koc@uni.edu", Sifre = "1234", Numara = "2020501122", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 123, AdSoyad = "Batuhan Arı", Eposta = "batuhan.ari@uni.edu", Sifre = "1234", Numara = "2020501123", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 124, AdSoyad = "Mina Dursun", Eposta = "mina.dursun@uni.edu", Sifre = "1234", Numara = "2020501124", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 125, AdSoyad = "Recep Acar", Eposta = "recep.acar@uni.edu", Sifre = "1234", Numara = "2020501125", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 126, AdSoyad = "Arda Toprak", Eposta = "arda.toprak@uni.edu", Sifre = "1234", Numara = "2020501126", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 127, AdSoyad = "Nisanur Bilge", Eposta = "nisanur.bilge@uni.edu", Sifre = "1234", Numara = "2020501127", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 128, AdSoyad = "Caner Tetik", Eposta = "caner.tetik@uni.edu", Sifre = "1234", Numara = "2020501128", RolID = 1, SinifID = 1 },
                    new Kullanici { KullaniciID = 129, AdSoyad = "Yaren Aydemir", Eposta = "yaren.aydemir@uni.edu", Sifre = "1234", Numara = "2020501129", RolID = 1, SinifID = 1 }


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
