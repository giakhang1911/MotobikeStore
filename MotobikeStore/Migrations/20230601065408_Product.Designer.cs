﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MotobikeStore.Data;

#nullable disable

namespace MotobikeStore.Migrations
{
    [DbContext(typeof(MotobikeStoreContext))]
    [Migration("20230601065408_Product")]
    partial class Product
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MotobikeStore.Models.DongXe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Dongxe")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DongXe");
                });

            modelBuilder.Entity("MotobikeStore.Models.HangXe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("hangxe")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HangXe");
                });

            modelBuilder.Entity("MotobikeStore.Models.SanPham", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("DongxeId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mieuta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tenxe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("soluong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DongxeId");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("MotobikeStore.Models.SanPham", b =>
                {
                    b.HasOne("MotobikeStore.Models.DongXe", "Dongxe")
                        .WithMany()
                        .HasForeignKey("DongxeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dongxe");
                });
#pragma warning restore 612, 618
        }
    }
}