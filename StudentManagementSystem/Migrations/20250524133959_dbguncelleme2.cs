using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class dbguncelleme2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SinavOturmaPlanlari_DerslikID",
                table: "SinavOturmaPlanlari",
                column: "DerslikID");

            migrationBuilder.CreateIndex(
                name: "IX_SinavOturmaPlanlari_OgrenciID",
                table: "SinavOturmaPlanlari",
                column: "OgrenciID");

            migrationBuilder.AddForeignKey(
                name: "FK_SinavOturmaPlanlari_Derslikler_DerslikID",
                table: "SinavOturmaPlanlari",
                column: "DerslikID",
                principalTable: "Derslikler",
                principalColumn: "DerslikID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SinavOturmaPlanlari_Kullanicilar_OgrenciID",
                table: "SinavOturmaPlanlari",
                column: "OgrenciID",
                principalTable: "Kullanicilar",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SinavOturmaPlanlari_Derslikler_DerslikID",
                table: "SinavOturmaPlanlari");

            migrationBuilder.DropForeignKey(
                name: "FK_SinavOturmaPlanlari_Kullanicilar_OgrenciID",
                table: "SinavOturmaPlanlari");

            migrationBuilder.DropIndex(
                name: "IX_SinavOturmaPlanlari_DerslikID",
                table: "SinavOturmaPlanlari");

            migrationBuilder.DropIndex(
                name: "IX_SinavOturmaPlanlari_OgrenciID",
                table: "SinavOturmaPlanlari");
        }
    }
}
