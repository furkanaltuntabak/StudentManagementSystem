using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class Seeddortiki : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dersler",
                columns: new[] { "DersID", "DersAdi", "DonemID", "Kredi", "OgretimElemaniID", "SinifID" },
                values: new object[,]
                {
                    { 54, "Metin Madenciliği", 8, 0, 2, 4 },
                    { 55, "Veri Gizleme", 8, 0, 11, 4 },
                    { 56, "İleri Veritabanı Sistemleri", 8, 0, 13, 4 },
                    { 57, "Robot Programlama", 8, 0, 7, 4 },
                    { 58, " Yazılım Kalite Güvencesi", 8, 0, 12, 4 },
                    { 60, "Bitirme Çalışması", 8, 0, 12, 4 }
                });

            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "KullaniciID", "AdSoyad", "Eposta", "Numara", "RolID", "Sifre", "SinifID" },
                values: new object[,]
                {
                    { 21, "Radwan Ali Abdulghani Saleh", "Radwan.Ali@uni.edu", null, 2, "1234", null },
                    { 22, " Adnan Kavak", "Adnan.Kavak@uni.edu", null, 2, "1234", null }
                });

            migrationBuilder.InsertData(
                table: "Dersler",
                columns: new[] { "DersID", "DersAdi", "DonemID", "Kredi", "OgretimElemaniID", "SinifID" },
                values: new object[,]
                {
                    { 53, " Yapay Zeka ve Uzman Sistemler", 8, 0, 21, 4 },
                    { 59, "Kablosuz Ağlar", 8, 0, 22, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 22);
        }
    }
}
