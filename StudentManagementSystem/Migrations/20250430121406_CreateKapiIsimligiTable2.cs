using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class CreateKapiIsimligiTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OgretimElemaniID",
                table: "KapiIsimlikleri",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SinifAdi",
                table: "KapiIsimlikleri",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_KapiIsimlikleri_OgretimElemaniID",
                table: "KapiIsimlikleri",
                column: "OgretimElemaniID");

            migrationBuilder.AddForeignKey(
                name: "FK_KapiIsimlikleri_Kullanicilar_OgretimElemaniID",
                table: "KapiIsimlikleri",
                column: "OgretimElemaniID",
                principalTable: "Kullanicilar",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KapiIsimlikleri_Kullanicilar_OgretimElemaniID",
                table: "KapiIsimlikleri");

            migrationBuilder.DropIndex(
                name: "IX_KapiIsimlikleri_OgretimElemaniID",
                table: "KapiIsimlikleri");

            migrationBuilder.DropColumn(
                name: "OgretimElemaniID",
                table: "KapiIsimlikleri");

            migrationBuilder.DropColumn(
                name: "SinifAdi",
                table: "KapiIsimlikleri");
        }
    }
}
