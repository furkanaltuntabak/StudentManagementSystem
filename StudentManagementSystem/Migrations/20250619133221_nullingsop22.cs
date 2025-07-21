using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class nullingsop22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NotMetni",
                table: "SinavNotlari",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "OgretimElemaniID",
                table: "SinavNotlari",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SinavNotlari_OgretimElemaniID",
                table: "SinavNotlari",
                column: "OgretimElemaniID");

            migrationBuilder.AddForeignKey(
                name: "FK_SinavNotlari_Kullanicilar_OgretimElemaniID",
                table: "SinavNotlari",
                column: "OgretimElemaniID",
                principalTable: "Kullanicilar",
                principalColumn: "KullaniciID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SinavNotlari_Kullanicilar_OgretimElemaniID",
                table: "SinavNotlari");

            migrationBuilder.DropIndex(
                name: "IX_SinavNotlari_OgretimElemaniID",
                table: "SinavNotlari");

            migrationBuilder.DropColumn(
                name: "OgretimElemaniID",
                table: "SinavNotlari");

            migrationBuilder.AlterColumn<string>(
                name: "NotMetni",
                table: "SinavNotlari",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
