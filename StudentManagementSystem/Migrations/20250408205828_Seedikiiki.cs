using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class Seedikiiki : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dersler",
                columns: new[] { "DersID", "DersAdi", "DonemID", "Kredi", "OgretimElemaniID", "SinifID" },
                values: new object[,]
                {
                    { 25, "Algoritma Analizi", 4, 0, 11, 2 },
                    { 26, "Ayrık Matematik", 4, 0, 7, 2 },
                    { 27, "Bilgisayar Organizasyonu", 4, 0, 12, 2 },
                    { 30, "Web Programlama", 4, 0, 7, 2 },
                    { 31, "Yazılım Mimarileri ve Tasarım", 4, 0, 6, 2 }
                });

            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "KullaniciID", "AdSoyad", "Eposta", "Numara", "RolID", "Sifre", "SinifID" },
                values: new object[,]
                {
                    { 14, "Orhan Akbulut", "Orhan.Akbulut@uni.edu", null, 2, "1234", null },
                    { 15, "Onur Gök", "Onur.Gök@uni.edu", null, 2, "1234", null }
                });

            migrationBuilder.InsertData(
                table: "Dersler",
                columns: new[] { "DersID", "DersAdi", "DonemID", "Kredi", "OgretimElemaniID", "SinifID" },
                values: new object[,]
                {
                    { 28, "Olasılık ve Raslantı Değişkenleri", 4, 0, 14, 2 },
                    { 29, "Otomata Teorisi", 4, 0, 15, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 15);
        }
    }
}
