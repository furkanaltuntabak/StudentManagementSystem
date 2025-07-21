using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class sinavnot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SinavOturmaPlanlari_Dersler_DersID",
                table: "SinavOturmaPlanlari");

            migrationBuilder.DropIndex(
                name: "IX_SinavOturmaPlanlari_DersID",
                table: "SinavOturmaPlanlari");

            migrationBuilder.DropColumn(
                name: "DersID",
                table: "SinavOturmaPlanlari");

            migrationBuilder.CreateTable(
                name: "SinavNotlari",
                columns: table => new
                {
                    SinavNotID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SinavID = table.Column<int>(type: "INTEGER", nullable: false),
                    NotMetni = table.Column<string>(type: "TEXT", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinavNotlari", x => x.SinavNotID);
                    table.ForeignKey(
                        name: "FK_SinavNotlari_Sinavlar_SinavID",
                        column: x => x.SinavID,
                        principalTable: "Sinavlar",
                        principalColumn: "SinavID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SinavNotlari_SinavID",
                table: "SinavNotlari",
                column: "SinavID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SinavNotlari");

            migrationBuilder.AddColumn<int>(
                name: "DersID",
                table: "SinavOturmaPlanlari",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SinavOturmaPlanlari_DersID",
                table: "SinavOturmaPlanlari",
                column: "DersID");

            migrationBuilder.AddForeignKey(
                name: "FK_SinavOturmaPlanlari_Dersler_DersID",
                table: "SinavOturmaPlanlari",
                column: "DersID",
                principalTable: "Dersler",
                principalColumn: "DersID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
