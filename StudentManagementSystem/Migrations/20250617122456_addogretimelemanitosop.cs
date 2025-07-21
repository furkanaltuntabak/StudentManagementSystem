using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class addogretimelemanitosop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OgretimElemaniID",
                table: "SinavOturmaPlanlari",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SinavOturmaPlanlari_OgretimElemaniID",
                table: "SinavOturmaPlanlari",
                column: "OgretimElemaniID");

            migrationBuilder.AddForeignKey(
                name: "FK_SinavOturmaPlanlari_Kullanicilar_OgretimElemaniID",
                table: "SinavOturmaPlanlari",
                column: "OgretimElemaniID",
                principalTable: "Kullanicilar",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SinavOturmaPlanlari_Kullanicilar_OgretimElemaniID",
                table: "SinavOturmaPlanlari");

            migrationBuilder.DropIndex(
                name: "IX_SinavOturmaPlanlari_OgretimElemaniID",
                table: "SinavOturmaPlanlari");

            migrationBuilder.DropColumn(
                name: "OgretimElemaniID",
                table: "SinavOturmaPlanlari");
        }
    }
}
