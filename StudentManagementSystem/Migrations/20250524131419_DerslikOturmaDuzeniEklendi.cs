using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class DerslikOturmaDuzeniEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KoltukSayisi",
                table: "Derslikler",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SiraSayisi",
                table: "Derslikler",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Derslikler",
                keyColumn: "DerslikID",
                keyValue: 1,
                columns: new[] { "KoltukSayisi", "SiraSayisi" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Derslikler",
                keyColumn: "DerslikID",
                keyValue: 2,
                columns: new[] { "KoltukSayisi", "SiraSayisi" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Derslikler",
                keyColumn: "DerslikID",
                keyValue: 3,
                columns: new[] { "KoltukSayisi", "SiraSayisi" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Derslikler",
                keyColumn: "DerslikID",
                keyValue: 4,
                columns: new[] { "KoltukSayisi", "SiraSayisi" },
                values: new object[] { 0, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KoltukSayisi",
                table: "Derslikler");

            migrationBuilder.DropColumn(
                name: "SiraSayisi",
                table: "Derslikler");
        }
    }
}
