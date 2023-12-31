﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web12412412.Models;

#nullable disable

namespace WebOdev.Migrations
{
    [DbContext(typeof(BiletContext))]
    [Migration("20240101063128_mg2m7")]
    partial class mg2m7
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Web12412412.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"), 1L, 1);

                    b.Property<string>("AdminName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("AdminTbl");
                });

            modelBuilder.Entity("Web12412412.Models.Bilet", b =>
                {
                    b.Property<int>("BiletId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BiletId"), 1L, 1);

                    b.Property<DateTime>("DonusTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("GidisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("KalkisSaat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KalkisYeri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KoltukNumarasi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UcakId")
                        .HasColumnType("int");

                    b.Property<string>("VarisYeri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BiletId");

                    b.HasIndex("UcakId");

                    b.ToTable("BiletTbl");
                });

            modelBuilder.Entity("Web12412412.Models.Koltuk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Dolumu")
                        .HasColumnType("bit");

                    b.Property<int>("KoltukNo")
                        .HasColumnType("int");

                    b.Property<int>("UcakId")
                        .HasColumnType("int");

                    b.Property<int?>("UcusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UcakId");

                    b.HasIndex("UcusId");

                    b.ToTable("Koltuk");
                });

            modelBuilder.Entity("Web12412412.Models.Kullanici", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("CPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("KullaniciTbl");
                });

            modelBuilder.Entity("Web12412412.Models.Sehir", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("SehirAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UcusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UcusId");

                    b.ToTable("Sehir");
                });

            modelBuilder.Entity("Web12412412.Models.Ucak", b =>
                {
                    b.Property<int>("UcakId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UcakId"), 1L, 1);

                    b.Property<double>("Fiyat")
                        .HasColumnType("float");

                    b.Property<int>("KoltukSayisi")
                        .HasColumnType("int");

                    b.Property<string>("UcakAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("doluKoltukSayisi")
                        .HasColumnType("int");

                    b.HasKey("UcakId");

                    b.ToTable("Ucaklar");
                });

            modelBuilder.Entity("Web12412412.Models.Ucus", b =>
                {
                    b.Property<int>("UcusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UcusId"), 1L, 1);

                    b.Property<DateTime>("DonusTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("GidisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("KalkisSaat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nereden")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nereye")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UcakId")
                        .HasColumnType("int");

                    b.Property<string>("VarisSaat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("doluKoltukSayisi")
                        .HasColumnType("int");

                    b.HasKey("UcusId");

                    b.HasIndex("UcakId");

                    b.ToTable("Ucuslar");
                });

            modelBuilder.Entity("Web12412412.Models.Bilet", b =>
                {
                    b.HasOne("Web12412412.Models.Ucak", "Ucak")
                        .WithMany()
                        .HasForeignKey("UcakId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ucak");
                });

            modelBuilder.Entity("Web12412412.Models.Koltuk", b =>
                {
                    b.HasOne("Web12412412.Models.Ucak", "Ucak")
                        .WithMany("Koltuk")
                        .HasForeignKey("UcakId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Web12412412.Models.Ucus", null)
                        .WithMany("Koltuk")
                        .HasForeignKey("UcusId");

                    b.Navigation("Ucak");
                });

            modelBuilder.Entity("Web12412412.Models.Sehir", b =>
                {
                    b.HasOne("Web12412412.Models.Ucus", null)
                        .WithMany("Sehir")
                        .HasForeignKey("UcusId");
                });

            modelBuilder.Entity("Web12412412.Models.Ucus", b =>
                {
                    b.HasOne("Web12412412.Models.Ucak", "Ucak")
                        .WithMany()
                        .HasForeignKey("UcakId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ucak");
                });

            modelBuilder.Entity("Web12412412.Models.Ucak", b =>
                {
                    b.Navigation("Koltuk");
                });

            modelBuilder.Entity("Web12412412.Models.Ucus", b =>
                {
                    b.Navigation("Koltuk");

                    b.Navigation("Sehir");
                });
#pragma warning restore 612, 618
        }
    }
}
