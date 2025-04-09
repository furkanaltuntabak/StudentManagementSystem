using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeeducbirUE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Derslikler",
                keyColumn: "DerslikID",
                keyValue: 2,
                column: "Kapasite",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Derslikler",
                keyColumn: "DerslikID",
                keyValue: 3,
                column: "Kapasite",
                value: 100);

            migrationBuilder.InsertData(
                table: "Derslikler",
                columns: new[] { "DerslikID", "DerslikAdi", "Kapasite" },
                values: new object[] { 4, "Uzaktan Eğitim (UE)", 300 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Derslikler",
                keyColumn: "DerslikID",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Derslikler",
                keyColumn: "DerslikID",
                keyValue: 2,
                column: "Kapasite",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Derslikler",
                keyColumn: "DerslikID",
                keyValue: 3,
                column: "Kapasite",
                value: 40);
        }
    }
}
