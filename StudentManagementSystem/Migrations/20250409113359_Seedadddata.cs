using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class Seedadddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DersProgramlari",
                keyColumn: "DersProgramiID",
                keyValue: 1,
                column: "Saat",
                value: "10:00-11:30");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DersProgramlari",
                keyColumn: "DersProgramiID",
                keyValue: 1,
                column: "Saat",
                value: "10:00");
        }
    }
}
