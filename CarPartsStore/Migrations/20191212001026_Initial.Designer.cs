﻿// <auto-generated />
using System;
using CarPartsStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CarPartsStore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191212001026_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("CarPartsStore.Data.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Mark")
                        .HasColumnType("text");

                    b.Property<string>("Model")
                        .HasColumnType("text");

                    b.Property<string>("Vin")
                        .HasColumnType("text");

                    b.HasKey("CarId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarPartsStore.Data.Models.Carpart", b =>
                {
                    b.Property<int>("CarpartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<int>("InStock")
                        .HasColumnType("integer");

                    b.Property<string>("LongDescription")
                        .HasColumnType("text");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("text");

                    b.Property<int?>("Vin")
                        .HasColumnType("integer");

                    b.HasKey("CarpartId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Vin");

                    b.ToTable("Carparts");
                });

            modelBuilder.Entity("CarPartsStore.Data.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CarPartsStore.Data.Models.ShopCartItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CarpartId")
                        .HasColumnType("integer");

                    b.Property<string>("ShopCartId")
                        .HasColumnType("text");

                    b.Property<int>("price")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("CarpartId");

                    b.ToTable("ShopCartItems");
                });

            modelBuilder.Entity("CarPartsStore.Data.Models.Carpart", b =>
                {
                    b.HasOne("CarPartsStore.Data.Models.Category", "Category")
                        .WithMany("CarParts")
                        .HasForeignKey("CategoryId");

                    b.HasOne("CarPartsStore.Data.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("Vin");
                });

            modelBuilder.Entity("CarPartsStore.Data.Models.ShopCartItem", b =>
                {
                    b.HasOne("CarPartsStore.Data.Models.Carpart", "carpart")
                        .WithMany()
                        .HasForeignKey("CarpartId");
                });
#pragma warning restore 612, 618
        }
    }
}
