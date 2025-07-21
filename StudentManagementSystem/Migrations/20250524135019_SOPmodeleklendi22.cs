using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class SOPmodeleklendi22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SinavOturmaPlanlari_Kullanicilar_OgrenciID",
                table: "SinavOturmaPlanlari");

            migrationBuilder.CreateIndex(
                name: "IX_SinavOturmaPlanlari_SinifID",
                table: "SinavOturmaPlanlari",
                column: "SinifID");

            migrationBuilder.AddForeignKey(
                name: "FK_SinavOturmaPlanlari_Kullanicilar_OgrenciID",
                table: "SinavOturmaPlanlari",
                column: "OgrenciID",
                principalTable: "Kullanicilar",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SinavOturmaPlanlari_Siniflar_SinifID",
                table: "SinavOturmaPlanlari",
                column: "SinifID",
                principalTable: "Siniflar",
                principalColumn: "SinifID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SinavOturmaPlanlari_Kullanicilar_OgrenciID",
                table: "SinavOturmaPlanlari");

            migrationBuilder.DropForeignKey(
                name: "FK_SinavOturmaPlanlari_Siniflar_SinifID",
                table: "SinavOturmaPlanlari");

            migrationBuilder.DropIndex(
                name: "IX_SinavOturmaPlanlari_SinifID",
                table: "SinavOturmaPlanlari");

            migrationBuilder.AddForeignKey(
                name: "FK_SinavOturmaPlanlari_Kullanicilar_OgrenciID",
                table: "SinavOturmaPlanlari",
                column: "OgrenciID",
                principalTable: "Kullanicilar",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
