using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class renamelessons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 8,
                column: "DersAdi",
                value: "Türk Dili II");

            migrationBuilder.UpdateData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 9,
                column: "DersAdi",
                value: "Atatürk İlkeleri ve İnkılap Tarihi II");

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 5,
                column: "AdSoyad",
                value: "Banu PAZAR");

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 6,
                column: "AdSoyad",
                value: "Hakan Gündüz");

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 7,
                column: "AdSoyad",
                value: "Levent Bayındır");

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 8,
                column: "AdSoyad",
                value: "Fatma Üçler");

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 9,
                column: "AdSoyad",
                value: "Gülten Madendağ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 8,
                column: "DersAdi",
                value: "Türk Dili I");

            migrationBuilder.UpdateData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 9,
                column: "DersAdi",
                value: " Atatürk İlkeleri ve İnkılap Tarihi II");

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 5,
                column: "AdSoyad",
                value: " Banu PAZAR");

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 6,
                column: "AdSoyad",
                value: " Hakan Gündüz");

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 7,
                column: "AdSoyad",
                value: " Levent Bayındır");

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 8,
                column: "AdSoyad",
                value: " Fatma Üçler");

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "KullaniciID",
                keyValue: 9,
                column: "AdSoyad",
                value: " Gülten Madendağ");
        }
    }
}
