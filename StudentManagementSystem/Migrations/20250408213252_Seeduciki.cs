using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class Seeduciki : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dersler",
                columns: new[] { "DersID", "DersAdi", "DonemID", "Kredi", "OgretimElemaniID", "SinifID" },
                values: new object[,]
                {
                    { 38, "Bilgi Güvenliği", 6, 0, 11, 3 },
                    { 40, "Makine Öğrenmesi Temelleri", 6, 0, 10, 3 },
                    { 43, "Yazılım Geliştirme-II", 6, 0, 11, 3 },
                    { 44, "Yazılım Proje Yönetimi", 6, 0, 13, 3 }
                });

            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "KullaniciID", "AdSoyad", "Eposta", "Numara", "RolID", "Sifre", "SinifID" },
                values: new object[,]
                {
                    { 17, "Serdar Solak", "Serdar.Solak@uni.edu", null, 2, "1234", null },
                    { 18, "Uğur Yıldız", "Uğur.Yıldız@uni.edu", null, 2, "1234", null },
                    { 19, "Yusuf Budak", "Yusuf.Budak@uni.edu", null, 2, "1234", null }
                });

            migrationBuilder.InsertData(
                table: "Dersler",
                columns: new[] { "DersID", "DersAdi", "DonemID", "Kredi", "OgretimElemaniID", "SinifID" },
                values: new object[,]
                {
                    { 39, "Linux Temelleri", 6, 0, 17, 3 },
                    { 41, "	Mobil Programlama", 6, 0, 18, 3 },
                    { 42, "Uzaktan Öğretim", 6, 0, 19, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 19);
        }
    }
}
