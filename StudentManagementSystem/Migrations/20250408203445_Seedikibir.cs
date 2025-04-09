using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class Seedikibir : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dersler",
                columns: new[] { "DersID", "DersAdi", "DonemID", "Kredi", "OgretimElemaniID", "SinifID" },
                values: new object[,]
                {
                    { 19, "Diferansiyel Denklemler", 1, 0, 3, 2 },
                    { 20, "Nesneye Yönelik Programlama", 1, 0, 7, 2 },
                    { 21, "Programlama Laboratuvarı III", 1, 0, 11, 2 },
                    { 22, "Sayısal Analiz", 1, 0, 10, 2 },
                    { 24, "Yazılım Gereksinimleri Analizi", 1, 0, 11, 2 }
                });

            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "KullaniciID", "AdSoyad", "Eposta", "Numara", "RolID", "Sifre", "SinifID" },
                values: new object[,]
                {
                    { 12, "Kerem Küçük", "Kerem.Küçük@uni.edu", null, 2, "1234", null },
                    { 13, "Samet Diri", "Samet.Diri@uni.edu", null, 2, "1234", null }
                });

            migrationBuilder.InsertData(
                table: "Dersler",
                columns: new[] { "DersID", "DersAdi", "DonemID", "Kredi", "OgretimElemaniID", "SinifID" },
                values: new object[,]
                {
                    { 18, "Bilgisayar Mimarisi ve Mantıksal Tasarım", 1, 0, 12, 2 },
                    { 23, "Veri Yapıları ve Algoritmalar", 1, 0, 13, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 13);
        }
    }
}
