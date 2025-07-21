using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddDersToSinavOturmaPlani : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SinavOturmaPlanlari_Kullanicilar_OgretimElemaniID",
                table: "SinavOturmaPlanlari");

            migrationBuilder.RenameColumn(
                name: "OgretimElemaniID",
                table: "SinavOturmaPlanlari",
                newName: "DersID");

            migrationBuilder.RenameIndex(
                name: "IX_SinavOturmaPlanlari_OgretimElemaniID",
                table: "SinavOturmaPlanlari",
                newName: "IX_SinavOturmaPlanlari_DersID");

            migrationBuilder.AddForeignKey(
                name: "FK_SinavOturmaPlanlari_Dersler_DersID",
                table: "SinavOturmaPlanlari",
                column: "DersID",
                principalTable: "Dersler",
                principalColumn: "DersID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SinavOturmaPlanlari_Dersler_DersID",
                table: "SinavOturmaPlanlari");

            migrationBuilder.RenameColumn(
                name: "DersID",
                table: "SinavOturmaPlanlari",
                newName: "OgretimElemaniID");

            migrationBuilder.RenameIndex(
                name: "IX_SinavOturmaPlanlari_DersID",
                table: "SinavOturmaPlanlari",
                newName: "IX_SinavOturmaPlanlari_OgretimElemaniID");

            migrationBuilder.AddForeignKey(
                name: "FK_SinavOturmaPlanlari_Kullanicilar_OgretimElemaniID",
                table: "SinavOturmaPlanlari",
                column: "OgretimElemaniID",
                principalTable: "Kullanicilar",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
