using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddKullaniciSeedData44 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "KullaniciID", "AdSoyad", "Eposta", "Numara", "RolID", "Sifre", "SinifID" },
                values: new object[,]
                {
                    { 31, "Ahmet Arslan", "ahmet.arslan@uni.edu", "2020501006", 1, "1234", 1 },
                    { 32, "Büşra Yılmaz", "busra.yilmaz@uni.edu", "2020501007", 1, "1234", 1 },
                    { 33, "Cemil Kılıç", "cemil.kilic@uni.edu", "2020501008", 1, "1234", 1 },
                    { 34, "Deniz Kaya", "deniz.kaya@uni.edu", "2020501009", 1, "1234", 1 },
                    { 35, "Elif Demir", "elif.demir@uni.edu", "2020501010", 1, "1234", 1 },
                    { 36, "Furkan Çelik", "furkan.celik@uni.edu", "2020501011", 1, "1234", 1 },
                    { 37, "Gökhan Akbaş", "gokhan.akbas@uni.edu", "2020501012", 1, "1234", 1 },
                    { 38, "Hüseyin Tekin", "huseyin.tekin@uni.edu", "2020501013", 1, "1234", 1 },
                    { 39, "İsmail Erdoğan", "ismail.erdogan@uni.edu", "2020501014", 1, "1234", 1 },
                    { 40, "Jale Bozkurt", "jale.bozkurt@uni.edu", "2020501015", 1, "1234", 1 },
                    { 41, "Kemal Özkan", "kemal.ozkan@uni.edu", "2020501016", 1, "1234", 1 },
                    { 42, "Lale Yıldız", "lale.yildiz@uni.edu", "2020501017", 1, "1234", 1 },
                    { 43, "Murat Akın", "murat.akin@uni.edu", "2020501018", 1, "1234", 1 },
                    { 44, "Nihan Güler", "nihan.guler@uni.edu", "2020501019", 1, "1234", 1 },
                    { 45, "Ozan Aydın", "ozan.aydin@uni.edu", "2020501020", 1, "1234", 1 },
                    { 46, "Pelin Çetin", "pelin.cetin@uni.edu", "2020501021", 1, "1234", 1 },
                    { 47, "Rıza Demirtaş", "riza.demirtas@uni.edu", "2020501022", 1, "1234", 1 },
                    { 48, "Sibel Koç", "sibel.koc@uni.edu", "2020501023", 1, "1234", 1 },
                    { 49, "Tuna Kalkan", "tuna.kalkan@uni.edu", "2020501024", 1, "1234", 1 },
                    { 50, "Uğur Doğan", "ugur.dogan@uni.edu", "2020501025", 1, "1234", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 50);
        }
    }
}
