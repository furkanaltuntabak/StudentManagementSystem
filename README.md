# Student Management System

Bu proje, Kocaeli Üniversitesi için geliştirilmiş bir **ASP.NET Core MVC tabanlı okul yönetim sistemidir**. Sistem, öğrenci, öğretim elemanı, bölüm sekreteri ve bölüm başkanı gibi farklı rollere sahip kullanıcıların erişim düzeylerine göre işlevler sunar.

## Özellikler

### Roller ve Yetkiler

#### 1. Bölüm Başkanı
- Tüm modüllere erişim sağlar.
- Kullanıcı yetkilendirmesi yapabilir.
- Ders, derslik, ders programı ve sınav işlemlerini yapabilir.
- Öğretim elemanlarına ders atayabilir.
- Sınav oturma düzenini belirleyebilir.

#### 2. Bölüm Sekreteri
- Kullanıcı kaydı oluşturabilir.
- Ders ve derslik işlemlerini yapabilir.
- Ders programı oluşturabilir ve listeleyebilir.
- Öğretim elemanlarına ders atayabilir.
- Öğretim elemanlarının programlarını görebilir.

#### 3. Öğretim Elemanı
- Kendi ders ve sınav programını görüntüleyebilir.
- Not girişi yapabilir.

#### 4. Öğrenci
- Kendi ders ve sınav programını görüntüleyebilir.

## Ana Modüller

- **Kullanıcı Yönetimi**: Öğrenci ve öğretim elemanı eklenmesi.
- **Ders Yönetimi**: Ders ekleme ve listeleme.
- **Derslik Yönetimi**: Derslikleri listeleme.
- **Ders Programı**: Döneme ve sınıfa göre ders programı oluşturma ve listeleme.
- **Sınav Yönetimi**: Sınav ekleme, listeleme ve kişisel sınav programı görüntüleme.
- **Öğretim Elemanına Ders Atama**: Derslerin öğretim elemanlarıyla eşleştirilmesi.

## Teknolojiler

- ASP.NET Core MVC
- Entity Framework Core (EF Core)
- SQL Server
- HTML5, CSS3, Bootstrap
- Session Yönetimi (Rol tabanlı erişim kontrolü)

## Projenin Kullanımı

1. **Projeyi klonlayın:**

```bash
git clone https://github.com/kullaniciadi/student-management-system.git
Veritabanını oluşturun:

AppDbContext.cs içinde gerekli DbSet’ler tanımlıdır.

dotnet ef database update komutu ile veritabanı oluşturulabilir.

Uygulamayı başlatın:

bash
Kopyala
Düzenle
dotnet run
Giriş Bilgileri:

Giriş ekranı: /Account/Login

Rol bilgisine göre arayüzler otomatik belirlenir.

Proje Yapısı
Controllers/: MVC Controller dosyaları

Models/: Entity sınıfları

Views/: Razor view dosyaları

wwwroot/: Statik dosyalar (CSS, JS)

Data/AppDbContext.cs: EF Core veritabanı bağlantısı

Katkıda Bulunma
Proje üniversite ödevi kapsamında hazırlandığından katkıya açık değildir. Ancak referans amaçlı kullanılabilir.
