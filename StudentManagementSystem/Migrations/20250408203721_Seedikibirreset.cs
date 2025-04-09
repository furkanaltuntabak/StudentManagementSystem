using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class Seedikibirreset : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 18,
                column: "DonemID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 19,
                column: "DonemID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 20,
                column: "DonemID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 21,
                column: "DonemID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 22,
                column: "DonemID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 23,
                column: "DonemID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 24,
                column: "DonemID",
                value: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 18,
                column: "DonemID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 19,
                column: "DonemID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 20,
                column: "DonemID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 21,
                column: "DonemID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 22,
                column: "DonemID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 23,
                column: "DonemID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Dersler",
                keyColumn: "DersID",
                keyValue: 24,
                column: "DonemID",
                value: 1);
        }
    }
}
