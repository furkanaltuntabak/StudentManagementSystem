using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class dbguncelleme4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "KullaniciID", "AdSoyad", "Eposta", "Numara", "RolID", "Sifre", "SinifID" },
                values: new object[,]
                {
                    { 60, "Ali Yılmaz", "ali.yilmaz@uni.edu", "2020501060", 1, "1234", 1 },
                    { 61, "Ayşe Demir", "ayse.demir@uni.edu", "2020501061", 1, "1234", 1 },
                    { 62, "Mehmet Kara", "mehmet.kara@uni.edu", "2020501062", 1, "1234", 1 },
                    { 63, "Zeynep Şahin", "zeynep.sahin@uni.edu", "2020501063", 1, "1234", 1 },
                    { 64, "Emre Aydın", "emre.aydin@uni.edu", "2020501064", 1, "1234", 1 },
                    { 65, "Fatma Yıldız", "fatma.yildiz@uni.edu", "2020501065", 1, "1234", 1 },
                    { 66, "Ahmet Taş", "ahmet.tas@uni.edu", "2020501066", 1, "1234", 1 },
                    { 67, "Elif Kurt", "elif.kurt@uni.edu", "2020501067", 1, "1234", 1 },
                    { 68, "Mert Can", "mert.can@uni.edu", "2020501068", 1, "1234", 1 },
                    { 69, "Buse Yalçın", "buse.yalcin@uni.edu", "2020501069", 1, "1234", 1 },
                    { 70, "Oğuz Kaan", "oguz.kaan@uni.edu", "2020501070", 1, "1234", 1 },
                    { 71, "Selin Polat", "selin.polat@uni.edu", "2020501071", 1, "1234", 1 },
                    { 72, "Burak Güneş", "burak.gunes@uni.edu", "2020501072", 1, "1234", 1 },
                    { 73, "Ceren Aksoy", "ceren.aksoy@uni.edu", "2020501073", 1, "1234", 1 },
                    { 74, "Hasan Koç", "hasan.koc@uni.edu", "2020501074", 1, "1234", 1 },
                    { 75, "Melis Tan", "melis.tan@uni.edu", "2020501075", 1, "1234", 1 },
                    { 76, "Tuna Er", "tuna.er@uni.edu", "2020501076", 1, "1234", 1 },
                    { 77, "Nazlı Gül", "nazli.gul@uni.edu", "2020501077", 1, "1234", 1 },
                    { 78, "Onur Bayrak", "onur.bayrak@uni.edu", "2020501078", 1, "1234", 1 },
                    { 79, "Simge Acar", "simge.acar@uni.edu", "2020501079", 1, "1234", 1 },
                    { 80, "Baran Ateş", "baran.ates@uni.edu", "2020501080", 1, "1234", 1 },
                    { 81, "İlayda Kılıç", "ilayda.kilic@uni.edu", "2020501081", 1, "1234", 1 },
                    { 82, "Efe Demirtaş", "efe.demirtas@uni.edu", "2020501082", 1, "1234", 1 },
                    { 83, "Sude Yüce", "sude.yuce@uni.edu", "2020501083", 1, "1234", 1 },
                    { 84, "Kerem Bilgin", "kerem.bilgin@uni.edu", "2020501084", 1, "1234", 1 },
                    { 85, "Zeliha Tuncel", "zeliha.tuncel@uni.edu", "2020501085", 1, "1234", 1 },
                    { 86, "Hakan Özkan", "hakan.ozkan@uni.edu", "2020501086", 1, "1234", 1 },
                    { 87, "Dilara Yılmaz", "dilara.yilmaz@uni.edu", "2020501087", 1, "1234", 1 },
                    { 88, "Serkan Gültekin", "serkan.gultekin@uni.edu", "2020501088", 1, "1234", 1 },
                    { 89, "Melek Şimşek", "melek.simsek@uni.edu", "2020501089", 1, "1234", 1 },
                    { 90, "Enes Uçar", "enes.ucar@uni.edu", "2020501090", 1, "1234", 1 },
                    { 91, "Tuğçe Kaya", "tugce.kaya@uni.edu", "2020501091", 1, "1234", 1 },
                    { 92, "Yunus Emre", "yunus.emre@uni.edu", "2020501092", 1, "1234", 1 },
                    { 93, "Naz Arslan", "naz.arslan@uni.edu", "2020501093", 1, "1234", 1 },
                    { 94, "Berkay Gök", "berkay.gok@uni.edu", "2020501094", 1, "1234", 1 },
                    { 95, "Necla Bozkurt", "necla.bozkurt@uni.edu", "2020501095", 1, "1234", 1 },
                    { 96, "Taylan Ersoy", "taylan.ersoy@uni.edu", "2020501096", 1, "1234", 1 },
                    { 97, "Gamze Kılıç", "gamze.kilic@uni.edu", "2020501097", 1, "1234", 1 },
                    { 98, "Volkan Yalın", "volkan.yalin@uni.edu", "2020501098", 1, "1234", 1 },
                    { 99, "İrem Akın", "irem.akin@uni.edu", "2020501099", 1, "1234", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 99);
        }
    }
}
