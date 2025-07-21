using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class Createsinav : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OgretimElemaniID",
                table: "Sinavlar",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sinavlar_OgretimElemaniID",
                table: "Sinavlar",
                column: "OgretimElemaniID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sinavlar_Kullanicilar_OgretimElemaniID",
                table: "Sinavlar",
                column: "OgretimElemaniID",
                principalTable: "Kullanicilar",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sinavlar_Kullanicilar_OgretimElemaniID",
                table: "Sinavlar");

            migrationBuilder.DropIndex(
                name: "IX_Sinavlar_OgretimElemaniID",
                table: "Sinavlar");

            migrationBuilder.DropColumn(
                name: "OgretimElemaniID",
                table: "Sinavlar");
        }
    }
}
