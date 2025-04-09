using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class SEEDderslik : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Derslikler",
                keyColumn: "DerslikID",
                keyValue: 1,
                column: "DerslikAdi",
                value: "Amfi");

            migrationBuilder.UpdateData(
                table: "Derslikler",
                keyColumn: "DerslikID",
                keyValue: 2,
                column: "DerslikAdi",
                value: "Lab");

            migrationBuilder.InsertData(
                table: "Derslikler",
                columns: new[] { "DerslikID", "DerslikAdi", "Kapasite" },
                values: new object[] { 3, "D-108", 40 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Derslikler",
                keyColumn: "DerslikID",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Derslikler",
                keyColumn: "DerslikID",
                keyValue: 1,
                column: "DerslikAdi",
                value: "Amfi 1");

            migrationBuilder.UpdateData(
                table: "Derslikler",
                keyColumn: "DerslikID",
                keyValue: 2,
                column: "DerslikAdi",
                value: "Lab 2");
        }
    }
}
