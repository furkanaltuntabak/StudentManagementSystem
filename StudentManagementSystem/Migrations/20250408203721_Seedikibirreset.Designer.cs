﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentManagementSystem.Data;

#nullable disable

namespace StudentManagementSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250408203721_Seedikibirreset")]
    partial class Seedikibirreset
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.3");

            modelBuilder.Entity("Donem", b =>
                {
                    b.Property<int>("DonemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DonemAdi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("DonemID");

                    b.ToTable("Donemler");

                    b.HasData(
                        new
                        {
                            DonemID = 1,
                            DonemAdi = "1. Sınıf Güz Dönemi"
                        },
                        new
                        {
                            DonemID = 2,
                            DonemAdi = "1. Sınıf Bahar Dönemi"
                        },
                        new
                        {
                            DonemID = 3,
                            DonemAdi = "2. Sınıf Güz Dönemi"
                        },
                        new
                        {
                            DonemID = 4,
                            DonemAdi = "2. Sınıf Bahar Dönemi"
                        },
                        new
                        {
                            DonemID = 5,
                            DonemAdi = "3. Sınıf Güz Dönemi"
                        },
                        new
                        {
                            DonemID = 6,
                            DonemAdi = "3. Sınıf Bahar Dönemi"
                        },
                        new
                        {
                            DonemID = 7,
                            DonemAdi = "4. Sınıf Güz Dönemi"
                        },
                        new
                        {
                            DonemID = 8,
                            DonemAdi = "4. Sınıf Bahar Dönemi"
                        });
                });

            modelBuilder.Entity("Sinif", b =>
                {
                    b.Property<int>("SinifID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("SinifAdi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SinifID");

                    b.ToTable("Siniflar");

                    b.HasData(
                        new
                        {
                            SinifID = 1,
                            SinifAdi = "1. Sınıf"
                        },
                        new
                        {
                            SinifID = 2,
                            SinifAdi = "2. Sınıf"
                        },
                        new
                        {
                            SinifID = 3,
                            SinifAdi = "3. Sınıf"
                        },
                        new
                        {
                            SinifID = 4,
                            SinifAdi = "4. Sınıf"
                        });
                });

            modelBuilder.Entity("StudentManagementSystem.Data.Ders", b =>
                {
                    b.Property<int>("DersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DersAdi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("DonemID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Kredi")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OgretimElemaniID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SinifID")
                        .HasColumnType("INTEGER");

                    b.HasKey("DersID");

                    b.HasIndex("DonemID");

                    b.HasIndex("OgretimElemaniID");

                    b.HasIndex("SinifID");

                    b.ToTable("Dersler");

                    b.HasData(
                        new
                        {
                            DersID = 1,
                            DersAdi = "Programlama II",
                            DonemID = 2,
                            Kredi = 0,
                            OgretimElemaniID = 2,
                            SinifID = 1
                        },
                        new
                        {
                            DersID = 2,
                            DersAdi = "Matematik II",
                            DonemID = 2,
                            Kredi = 0,
                            OgretimElemaniID = 3,
                            SinifID = 1
                        },
                        new
                        {
                            DersID = 3,
                            DersAdi = "Fizik II",
                            DonemID = 2,
                            Kredi = 0,
                            OgretimElemaniID = 4,
                            SinifID = 1
                        },
                        new
                        {
                            DersID = 4,
                            DersAdi = "Programlama Laboratuvarı II",
                            DonemID = 2,
                            Kredi = 0,
                            OgretimElemaniID = 2,
                            SinifID = 1
                        },
                        new
                        {
                            DersID = 5,
                            DersAdi = "Lineer Cebir",
                            DonemID = 2,
                            Kredi = 0,
                            OgretimElemaniID = 5,
                            SinifID = 1
                        },
                        new
                        {
                            DersID = 6,
                            DersAdi = "Web Teknolojileri",
                            DonemID = 2,
                            Kredi = 0,
                            OgretimElemaniID = 6,
                            SinifID = 1
                        },
                        new
                        {
                            DersID = 7,
                            DersAdi = "Kariyer Planlama ",
                            DonemID = 2,
                            Kredi = 0,
                            OgretimElemaniID = 7,
                            SinifID = 1
                        },
                        new
                        {
                            DersID = 8,
                            DersAdi = "Türk Dili II",
                            DonemID = 2,
                            Kredi = 0,
                            OgretimElemaniID = 8,
                            SinifID = 1
                        },
                        new
                        {
                            DersID = 9,
                            DersAdi = "Atatürk İlkeleri ve İnkılap Tarihi II",
                            DonemID = 2,
                            Kredi = 0,
                            OgretimElemaniID = 9,
                            SinifID = 1
                        },
                        new
                        {
                            DersID = 10,
                            DersAdi = "Atatürk İlkeleri ve İnkılap Tarihi I",
                            DonemID = 1,
                            Kredi = 0,
                            OgretimElemaniID = 9,
                            SinifID = 1
                        },
                        new
                        {
                            DersID = 11,
                            DersAdi = "	Fizik I",
                            DonemID = 1,
                            Kredi = 0,
                            OgretimElemaniID = 4,
                            SinifID = 1
                        },
                        new
                        {
                            DersID = 12,
                            DersAdi = "Matematik I",
                            DonemID = 1,
                            Kredi = 0,
                            OgretimElemaniID = 3,
                            SinifID = 1
                        },
                        new
                        {
                            DersID = 13,
                            DersAdi = "Mesleki İngilizce",
                            DonemID = 1,
                            Kredi = 0,
                            OgretimElemaniID = 10,
                            SinifID = 1
                        },
                        new
                        {
                            DersID = 14,
                            DersAdi = "Programlama I",
                            DonemID = 1,
                            Kredi = 0,
                            OgretimElemaniID = 2,
                            SinifID = 1
                        },
                        new
                        {
                            DersID = 15,
                            DersAdi = "Programlama Laboratuvarı I",
                            DonemID = 1,
                            Kredi = 0,
                            OgretimElemaniID = 6,
                            SinifID = 1
                        },
                        new
                        {
                            DersID = 16,
                            DersAdi = "Türk Dili I (UE)",
                            DonemID = 1,
                            Kredi = 0,
                            OgretimElemaniID = 8,
                            SinifID = 1
                        },
                        new
                        {
                            DersID = 17,
                            DersAdi = "Yazılım Mühendisliğine Giriş",
                            DonemID = 1,
                            Kredi = 0,
                            OgretimElemaniID = 11,
                            SinifID = 1
                        },
                        new
                        {
                            DersID = 18,
                            DersAdi = "Bilgisayar Mimarisi ve Mantıksal Tasarım",
                            DonemID = 3,
                            Kredi = 0,
                            OgretimElemaniID = 12,
                            SinifID = 2
                        },
                        new
                        {
                            DersID = 19,
                            DersAdi = "Diferansiyel Denklemler",
                            DonemID = 3,
                            Kredi = 0,
                            OgretimElemaniID = 3,
                            SinifID = 2
                        },
                        new
                        {
                            DersID = 20,
                            DersAdi = "Nesneye Yönelik Programlama",
                            DonemID = 3,
                            Kredi = 0,
                            OgretimElemaniID = 7,
                            SinifID = 2
                        },
                        new
                        {
                            DersID = 21,
                            DersAdi = "Programlama Laboratuvarı III",
                            DonemID = 3,
                            Kredi = 0,
                            OgretimElemaniID = 11,
                            SinifID = 2
                        },
                        new
                        {
                            DersID = 22,
                            DersAdi = "Sayısal Analiz",
                            DonemID = 3,
                            Kredi = 0,
                            OgretimElemaniID = 10,
                            SinifID = 2
                        },
                        new
                        {
                            DersID = 23,
                            DersAdi = "Veri Yapıları ve Algoritmalar",
                            DonemID = 3,
                            Kredi = 0,
                            OgretimElemaniID = 13,
                            SinifID = 2
                        },
                        new
                        {
                            DersID = 24,
                            DersAdi = "Yazılım Gereksinimleri Analizi",
                            DonemID = 3,
                            Kredi = 0,
                            OgretimElemaniID = 11,
                            SinifID = 2
                        });
                });

            modelBuilder.Entity("StudentManagementSystem.Data.DersProgrami", b =>
                {
                    b.Property<int>("DersProgramiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DersID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DerslikID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Gun")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Saat")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("DersProgramiID");

                    b.HasIndex("DersID");

                    b.HasIndex("DerslikID");

                    b.ToTable("DersProgramlari");

                    b.HasData(
                        new
                        {
                            DersProgramiID = 1,
                            DersID = 1,
                            DerslikID = 1,
                            Gun = "Pazartesi",
                            Saat = "10:00"
                        },
                        new
                        {
                            DersProgramiID = 2,
                            DersID = 2,
                            DerslikID = 2,
                            Gun = "Çarşamba",
                            Saat = "13:00"
                        });
                });

            modelBuilder.Entity("StudentManagementSystem.Data.Derslik", b =>
                {
                    b.Property<int>("DerslikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DerslikAdi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Kapasite")
                        .HasColumnType("INTEGER");

                    b.HasKey("DerslikID");

                    b.ToTable("Derslikler");

                    b.HasData(
                        new
                        {
                            DerslikID = 1,
                            DerslikAdi = "Amfi",
                            Kapasite = 100
                        },
                        new
                        {
                            DerslikID = 2,
                            DerslikAdi = "Lab",
                            Kapasite = 40
                        },
                        new
                        {
                            DerslikID = 3,
                            DerslikAdi = "D-108",
                            Kapasite = 40
                        });
                });

            modelBuilder.Entity("StudentManagementSystem.Data.Kullanici", b =>
                {
                    b.Property<int>("KullaniciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AdSoyad")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Eposta")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Numara")
                        .HasColumnType("TEXT");

                    b.Property<int>("RolID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("SinifID")
                        .HasColumnType("INTEGER");

                    b.HasKey("KullaniciID");

                    b.HasIndex("RolID");

                    b.HasIndex("SinifID");

                    b.ToTable("Kullanicilar");

                    b.HasData(
                        new
                        {
                            KullaniciID = 2,
                            AdSoyad = "İrfan Kösesoy",
                            Eposta = "İrfan.Kosesoy@uni.edu",
                            RolID = 2,
                            Sifre = "1234"
                        },
                        new
                        {
                            KullaniciID = 3,
                            AdSoyad = "Arzu Coşkun",
                            Eposta = "Arzu.Coşkun@uni.edu",
                            RolID = 2,
                            Sifre = "1234"
                        },
                        new
                        {
                            KullaniciID = 4,
                            AdSoyad = "Tayfun Güray",
                            Eposta = "Tayfun.Güray@uni.edu",
                            RolID = 2,
                            Sifre = "1234"
                        },
                        new
                        {
                            KullaniciID = 5,
                            AdSoyad = "Banu PAZAR",
                            Eposta = "Banu.pazar@uni.edu",
                            RolID = 2,
                            Sifre = "1234"
                        },
                        new
                        {
                            KullaniciID = 6,
                            AdSoyad = "Hakan Gündüz",
                            Eposta = "Hakan.Gündüz@uni.edu",
                            RolID = 2,
                            Sifre = "1234"
                        },
                        new
                        {
                            KullaniciID = 7,
                            AdSoyad = "Levent Bayındır",
                            Eposta = "Levent.Bayındır@uni.edu",
                            RolID = 2,
                            Sifre = "1234"
                        },
                        new
                        {
                            KullaniciID = 8,
                            AdSoyad = "Fatma Üçler",
                            Eposta = "Fatma.Üçler@uni.edu",
                            RolID = 2,
                            Sifre = "1234"
                        },
                        new
                        {
                            KullaniciID = 9,
                            AdSoyad = "Gülten Madendağ",
                            Eposta = "Gülten.Madendag@uni.edu",
                            RolID = 2,
                            Sifre = "1234"
                        },
                        new
                        {
                            KullaniciID = 10,
                            AdSoyad = "Kaplan Kaplan",
                            Eposta = "Kaplan.Kaplan@uni.edu",
                            RolID = 2,
                            Sifre = "1234"
                        },
                        new
                        {
                            KullaniciID = 11,
                            AdSoyad = "Zeki Konyar",
                            Eposta = "Zeki.Konyar@uni.edu",
                            RolID = 2,
                            Sifre = "1234"
                        },
                        new
                        {
                            KullaniciID = 12,
                            AdSoyad = "Kerem Küçük",
                            Eposta = "Kerem.Küçük@uni.edu",
                            RolID = 2,
                            Sifre = "1234"
                        },
                        new
                        {
                            KullaniciID = 13,
                            AdSoyad = "Samet Diri",
                            Eposta = "Samet.Diri@uni.edu",
                            RolID = 2,
                            Sifre = "1234"
                        });
                });

            modelBuilder.Entity("StudentManagementSystem.Data.Rol", b =>
                {
                    b.Property<int>("RolID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("RolAdi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("RolID");

                    b.ToTable("Roller");

                    b.HasData(
                        new
                        {
                            RolID = 1,
                            RolAdi = "Öğrenci"
                        },
                        new
                        {
                            RolID = 2,
                            RolAdi = "Öğretim Elemanı"
                        },
                        new
                        {
                            RolID = 3,
                            RolAdi = "Bölüm Sekreteri"
                        },
                        new
                        {
                            RolID = 4,
                            RolAdi = "Bölüm Başkanı"
                        });
                });

            modelBuilder.Entity("StudentManagementSystem.Data.Sinav", b =>
                {
                    b.Property<int>("SinavID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DersID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DerslikID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Saat")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("TEXT");

                    b.HasKey("SinavID");

                    b.HasIndex("DersID");

                    b.HasIndex("DerslikID");

                    b.ToTable("Sinavlar");
                });

            modelBuilder.Entity("StudentManagementSystem.Data.Ders", b =>
                {
                    b.HasOne("Donem", "Donem")
                        .WithMany("Dersler")
                        .HasForeignKey("DonemID");

                    b.HasOne("StudentManagementSystem.Data.Kullanici", "OgretimElemani")
                        .WithMany()
                        .HasForeignKey("OgretimElemaniID");

                    b.HasOne("Sinif", "Sinif")
                        .WithMany("Dersler")
                        .HasForeignKey("SinifID");

                    b.Navigation("Donem");

                    b.Navigation("OgretimElemani");

                    b.Navigation("Sinif");
                });

            modelBuilder.Entity("StudentManagementSystem.Data.DersProgrami", b =>
                {
                    b.HasOne("StudentManagementSystem.Data.Ders", "Ders")
                        .WithMany("DersProgramlari")
                        .HasForeignKey("DersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentManagementSystem.Data.Derslik", "Derslik")
                        .WithMany("DersProgramlari")
                        .HasForeignKey("DerslikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ders");

                    b.Navigation("Derslik");
                });

            modelBuilder.Entity("StudentManagementSystem.Data.Kullanici", b =>
                {
                    b.HasOne("StudentManagementSystem.Data.Rol", "Rol")
                        .WithMany("Kullanicilar")
                        .HasForeignKey("RolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sinif", "Sinif")
                        .WithMany("Kullanicilar")
                        .HasForeignKey("SinifID");

                    b.Navigation("Rol");

                    b.Navigation("Sinif");
                });

            modelBuilder.Entity("StudentManagementSystem.Data.Sinav", b =>
                {
                    b.HasOne("StudentManagementSystem.Data.Ders", "Ders")
                        .WithMany()
                        .HasForeignKey("DersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentManagementSystem.Data.Derslik", "Derslik")
                        .WithMany("Sinavlar")
                        .HasForeignKey("DerslikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ders");

                    b.Navigation("Derslik");
                });

            modelBuilder.Entity("Donem", b =>
                {
                    b.Navigation("Dersler");
                });

            modelBuilder.Entity("Sinif", b =>
                {
                    b.Navigation("Dersler");

                    b.Navigation("Kullanicilar");
                });

            modelBuilder.Entity("StudentManagementSystem.Data.Ders", b =>
                {
                    b.Navigation("DersProgramlari");
                });

            modelBuilder.Entity("StudentManagementSystem.Data.Derslik", b =>
                {
                    b.Navigation("DersProgramlari");

                    b.Navigation("Sinavlar");
                });

            modelBuilder.Entity("StudentManagementSystem.Data.Rol", b =>
                {
                    b.Navigation("Kullanicilar");
                });
#pragma warning restore 612, 618
        }
    }
}
