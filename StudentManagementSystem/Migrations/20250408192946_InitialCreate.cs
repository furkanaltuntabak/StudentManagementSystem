using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Derslikler",
                columns: table => new
                {
                    DerslikID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DerslikAdi = table.Column<string>(type: "TEXT", nullable: false),
                    Kapasite = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Derslikler", x => x.DerslikID);
                });

            migrationBuilder.CreateTable(
                name: "Donemler",
                columns: table => new
                {
                    DonemID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DonemAdi = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donemler", x => x.DonemID);
                });

            migrationBuilder.CreateTable(
                name: "Roller",
                columns: table => new
                {
                    RolID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RolAdi = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roller", x => x.RolID);
                });

            migrationBuilder.CreateTable(
                name: "Siniflar",
                columns: table => new
                {
                    SinifID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SinifAdi = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siniflar", x => x.SinifID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AdSoyad = table.Column<string>(type: "TEXT", nullable: false),
                    Eposta = table.Column<string>(type: "TEXT", nullable: false),
                    Sifre = table.Column<string>(type: "TEXT", nullable: false),
                    Numara = table.Column<string>(type: "TEXT", nullable: true),
                    RolID = table.Column<int>(type: "INTEGER", nullable: false),
                    SinifID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.KullaniciID);
                    table.ForeignKey(
                        name: "FK_Kullanicilar_Roller_RolID",
                        column: x => x.RolID,
                        principalTable: "Roller",
                        principalColumn: "RolID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kullanicilar_Siniflar_SinifID",
                        column: x => x.SinifID,
                        principalTable: "Siniflar",
                        principalColumn: "SinifID");
                });

            migrationBuilder.CreateTable(
                name: "Dersler",
                columns: table => new
                {
                    DersID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DersAdi = table.Column<string>(type: "TEXT", nullable: false),
                    Kredi = table.Column<int>(type: "INTEGER", nullable: false),
                    OgretimElemaniID = table.Column<int>(type: "INTEGER", nullable: true),
                    DonemID = table.Column<int>(type: "INTEGER", nullable: true),
                    SinifID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dersler", x => x.DersID);
                    table.ForeignKey(
                        name: "FK_Dersler_Donemler_DonemID",
                        column: x => x.DonemID,
                        principalTable: "Donemler",
                        principalColumn: "DonemID");
                    table.ForeignKey(
                        name: "FK_Dersler_Kullanicilar_OgretimElemaniID",
                        column: x => x.OgretimElemaniID,
                        principalTable: "Kullanicilar",
                        principalColumn: "KullaniciID");
                    table.ForeignKey(
                        name: "FK_Dersler_Siniflar_SinifID",
                        column: x => x.SinifID,
                        principalTable: "Siniflar",
                        principalColumn: "SinifID");
                });

            migrationBuilder.CreateTable(
                name: "DersProgramlari",
                columns: table => new
                {
                    DersProgramiID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DersID = table.Column<int>(type: "INTEGER", nullable: false),
                    DerslikID = table.Column<int>(type: "INTEGER", nullable: false),
                    Gun = table.Column<string>(type: "TEXT", nullable: false),
                    Saat = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersProgramlari", x => x.DersProgramiID);
                    table.ForeignKey(
                        name: "FK_DersProgramlari_Dersler_DersID",
                        column: x => x.DersID,
                        principalTable: "Dersler",
                        principalColumn: "DersID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DersProgramlari_Derslikler_DerslikID",
                        column: x => x.DerslikID,
                        principalTable: "Derslikler",
                        principalColumn: "DerslikID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sinavlar",
                columns: table => new
                {
                    SinavID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DersID = table.Column<int>(type: "INTEGER", nullable: false),
                    Tarih = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Saat = table.Column<string>(type: "TEXT", nullable: false),
                    DerslikID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sinavlar", x => x.SinavID);
                    table.ForeignKey(
                        name: "FK_Sinavlar_Dersler_DersID",
                        column: x => x.DersID,
                        principalTable: "Dersler",
                        principalColumn: "DersID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sinavlar_Derslikler_DerslikID",
                        column: x => x.DerslikID,
                        principalTable: "Derslikler",
                        principalColumn: "DerslikID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Derslikler",
                columns: new[] { "DerslikID", "DerslikAdi", "Kapasite" },
                values: new object[,]
                {
                    { 1, "Amfi 1", 100 },
                    { 2, "Lab 2", 40 }
                });

            migrationBuilder.InsertData(
                table: "Donemler",
                columns: new[] { "DonemID", "DonemAdi" },
                values: new object[,]
                {
                    { 1, "1. Sınıf Güz Dönemi" },
                    { 2, "1. Sınıf Bahar Dönemi" },
                    { 3, "2. Sınıf Güz Dönemi" },
                    { 4, "2. Sınıf Bahar Dönemi" },
                    { 5, "3. Sınıf Güz Dönemi" },
                    { 6, "3. Sınıf Bahar Dönemi" },
                    { 7, "4. Sınıf Güz Dönemi" },
                    { 8, "4. Sınıf Bahar Dönemi" }
                });

            migrationBuilder.InsertData(
                table: "Roller",
                columns: new[] { "RolID", "RolAdi" },
                values: new object[,]
                {
                    { 1, "Öğrenci" },
                    { 2, "Öğretim Elemanı" },
                    { 3, "Bölüm Sekreteri" },
                    { 4, "Bölüm Başkanı" }
                });

            migrationBuilder.InsertData(
                table: "Siniflar",
                columns: new[] { "SinifID", "SinifAdi" },
                values: new object[,]
                {
                    { 1, "1. Sınıf" },
                    { 2, "2. Sınıf" },
                    { 3, "3. Sınıf" },
                    { 4, "4. Sınıf" }
                });

            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "KullaniciID", "AdSoyad", "Eposta", "Numara", "RolID", "Sifre", "SinifID" },
                values: new object[,]
                {
                    { 2, "İrfan Kösesoy", "İrfan.Kosesoy@uni.edu", null, 2, "1234", null },
                    { 3, "Arzu Coşkun", "Arzu.Coşkun@uni.edu", null, 2, "1234", null },
                    { 4, "Tayfun Güray", "Tayfun.Güray@uni.edu", null, 2, "1234", null },
                    { 5, " Banu PAZAR", "Banu.pazar@uni.edu", null, 2, "1234", null },
                    { 6, " Hakan Gündüz", "Hakan.Gündüz@uni.edu", null, 2, "1234", null },
                    { 7, " Levent Bayındır", "Levent.Bayındır@uni.edu", null, 2, "1234", null },
                    { 8, " Fatma Üçler", "Fatma.Üçler@uni.edu", null, 2, "1234", null },
                    { 9, " Gülten Madendağ", "Gülten.Madendag@uni.edu", null, 2, "1234", null }
                });

            migrationBuilder.InsertData(
                table: "Dersler",
                columns: new[] { "DersID", "DersAdi", "DonemID", "Kredi", "OgretimElemaniID", "SinifID" },
                values: new object[,]
                {
                    { 1, "Programlama II", 2, 0, 2, 1 },
                    { 2, "Matematik II", 2, 0, 3, 1 },
                    { 3, "Fizik II", 2, 0, 4, 1 },
                    { 4, "Programlama Laboratuvarı II", 2, 0, 2, 1 },
                    { 5, "Lineer Cebir", 2, 0, 5, 1 },
                    { 6, "Web Teknolojileri", 2, 0, 6, 1 },
                    { 7, "Kariyer Planlama ", 2, 0, 7, 1 },
                    { 8, "Türk Dili I", 2, 0, 8, 1 },
                    { 9, " Atatürk İlkeleri ve İnkılap Tarihi II", 2, 0, 9, 1 }
                });

            migrationBuilder.InsertData(
                table: "DersProgramlari",
                columns: new[] { "DersProgramiID", "DersID", "DerslikID", "Gun", "Saat" },
                values: new object[,]
                {
                    { 1, 1, 1, "Pazartesi", "10:00" },
                    { 2, 2, 2, "Çarşamba", "13:00" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dersler_DonemID",
                table: "Dersler",
                column: "DonemID");

            migrationBuilder.CreateIndex(
                name: "IX_Dersler_OgretimElemaniID",
                table: "Dersler",
                column: "OgretimElemaniID");

            migrationBuilder.CreateIndex(
                name: "IX_Dersler_SinifID",
                table: "Dersler",
                column: "SinifID");

            migrationBuilder.CreateIndex(
                name: "IX_DersProgramlari_DersID",
                table: "DersProgramlari",
                column: "DersID");

            migrationBuilder.CreateIndex(
                name: "IX_DersProgramlari_DerslikID",
                table: "DersProgramlari",
                column: "DerslikID");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_RolID",
                table: "Kullanicilar",
                column: "RolID");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_SinifID",
                table: "Kullanicilar",
                column: "SinifID");

            migrationBuilder.CreateIndex(
                name: "IX_Sinavlar_DersID",
                table: "Sinavlar",
                column: "DersID");

            migrationBuilder.CreateIndex(
                name: "IX_Sinavlar_DerslikID",
                table: "Sinavlar",
                column: "DerslikID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DersProgramlari");

            migrationBuilder.DropTable(
                name: "Sinavlar");

            migrationBuilder.DropTable(
                name: "Dersler");

            migrationBuilder.DropTable(
                name: "Derslikler");

            migrationBuilder.DropTable(
                name: "Donemler");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "Roller");

            migrationBuilder.DropTable(
                name: "Siniflar");
        }
    }
}
