using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class dbguncelleme5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "KullaniciID", "AdSoyad", "Eposta", "Numara", "RolID", "Sifre", "SinifID" },
                values: new object[,]
                {
                    { 100, "Cansu Demirtaş", "cansu.demirtas@uni.edu", "2020501100", 1, "1234", 1 },
                    { 101, "Yusuf Akman", "yusuf.akman@uni.edu", "2020501101", 1, "1234", 1 },
                    { 102, "Sena Karaca", "sena.karaca@uni.edu", "2020501102", 1, "1234", 1 },
                    { 103, "Kaan Erdem", "kaan.erdem@uni.edu", "2020501103", 1, "1234", 1 },
                    { 104, "Merve Çetin", "merve.cetin@uni.edu", "2020501104", 1, "1234", 1 },
                    { 105, "Okan Yüce", "okan.yuce@uni.edu", "2020501105", 1, "1234", 1 },
                    { 106, "Beril Korkmaz", "beril.korkmaz@uni.edu", "2020501106", 1, "1234", 1 },
                    { 107, "Furkan Duru", "furkan.duru@uni.edu", "2020501107", 1, "1234", 1 },
                    { 108, "Gizem Uslu", "gizem.uslu@uni.edu", "2020501108", 1, "1234", 1 },
                    { 109, "Ömer Faruk", "omer.faruk@uni.edu", "2020501109", 1, "1234", 1 },
                    { 110, "Zehra Gök", "zehra.gok@uni.edu", "2020501110", 1, "1234", 1 },
                    { 111, "Burcu Altın", "burcu.altin@uni.edu", "2020501111", 1, "1234", 1 },
                    { 112, "Harun Bilgi", "harun.bilgi@uni.edu", "2020501112", 1, "1234", 1 },
                    { 113, "Yasemin Tuna", "yasemin.tuna@uni.edu", "2020501113", 1, "1234", 1 },
                    { 114, "Halil İbrahim", "halil.ibrahim@uni.edu", "2020501114", 1, "1234", 1 },
                    { 115, "İlayda Şahin", "ilayda.sahin@uni.edu", "2020501115", 1, "1234", 1 },
                    { 116, "Deniz Yaman", "deniz.yaman@uni.edu", "2020501116", 1, "1234", 1 },
                    { 117, "Tunahan Erol", "tunahan.erol@uni.edu", "2020501117", 1, "1234", 1 },
                    { 118, "Tuana Bal", "tuana.bal@uni.edu", "2020501118", 1, "1234", 1 },
                    { 119, "Doğukan Keskin", "dogukan.keskin@uni.edu", "2020501119", 1, "1234", 1 },
                    { 120, "Meltem Gür", "meltem.gur@uni.edu", "2020501120", 1, "1234", 1 },
                    { 121, "Barış Kaya", "baris.kaya@uni.edu", "2020501121", 1, "1234", 1 },
                    { 122, "Sibel Koç", "sibel.koc@uni.edu", "2020501122", 1, "1234", 1 },
                    { 123, "Batuhan Arı", "batuhan.ari@uni.edu", "2020501123", 1, "1234", 1 },
                    { 124, "Mina Dursun", "mina.dursun@uni.edu", "2020501124", 1, "1234", 1 },
                    { 125, "Recep Acar", "recep.acar@uni.edu", "2020501125", 1, "1234", 1 },
                    { 126, "Arda Toprak", "arda.toprak@uni.edu", "2020501126", 1, "1234", 1 },
                    { 127, "Nisanur Bilge", "nisanur.bilge@uni.edu", "2020501127", 1, "1234", 1 },
                    { 128, "Caner Tetik", "caner.tetik@uni.edu", "2020501128", 1, "1234", 1 },
                    { 129, "Yaren Aydemir", "yaren.aydemir@uni.edu", "2020501129", 1, "1234", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 129);
        }
    }
}
