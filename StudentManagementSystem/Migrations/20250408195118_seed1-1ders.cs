using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class seed11ders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dersler",
                columns: new[] { "DersID", "DersAdi", "DonemID", "Kredi", "OgretimElemaniID", "SinifID" },
                values: new object[,]
                {
                    { 10, "Atatürk İlkeleri ve İnkılap Tarihi I", 1, 0, 9, 1 },
                    { 11, "	Fizik I", 1, 0, 4, 1 },
                    { 12, "Matematik I", 1, 0, 3, 1 },
                    { 14, "Programlama I", 1, 0, 2, 1 },
                    { 15, "Programlama Laboratuvarı I", 1, 0, 6, 1 },
                    { 16, "Türk Dili I (UE)", 1, 0, 8, 1 }
                });

            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "KullaniciID", "AdSoyad", "Eposta", "Numara", "RolID", "Sifre", "SinifID" },
                values: new object[,]
                {
                    { 10, "Kaplan Kaplan", "Kaplan.Kaplan@uni.edu", null, 2, "1234", null },
                    { 11, "Zeki Konyar", "Zeki.Konyar@uni.edu", null, 2, "1234", null }
                });

            migrationBuilder.InsertData(
                table: "Dersler",
                columns: new[] { "DersID", "DersAdi", "DonemID", "Kredi", "OgretimElemaniID", "SinifID" },
                values: new object[,]
                {
                    { 13, "Mesleki İngilizce", 1, 0, 10, 1 },
                    { 17, "Yazılım Mühendisliğine Giriş", 1, 0, 11, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 11);
        }
    }
}
