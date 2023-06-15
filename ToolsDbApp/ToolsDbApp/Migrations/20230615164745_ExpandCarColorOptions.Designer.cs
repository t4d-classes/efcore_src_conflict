﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToolsDbApp.Models;

#nullable disable

namespace ToolsDbApp.Migrations
{
    [DbContext(typeof(ToolsAppDbContext))]
    [Migration("20230615164745_ExpandCarColorOptions")]
    partial class ExpandCarColorOptions
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ToolsDbApp.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ExteriorColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InteriorColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Car");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExteriorColor = "blue",
                            InteriorColor = "tan",
                            Make = "Ford",
                            Model = "Fusion Hybrid",
                            Price = 45000m,
                            Year = 2022
                        },
                        new
                        {
                            Id = 2,
                            ExteriorColor = "red",
                            InteriorColor = "black",
                            Make = "Tesla",
                            Model = "S",
                            Price = 120000m,
                            Year = 2020
                        });
                });

            modelBuilder.Entity("ToolsDbApp.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("HexCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Color");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HexCode = "#FF0000",
                            Name = "red"
                        },
                        new
                        {
                            Id = 2,
                            HexCode = "#00FF00",
                            Name = "green"
                        },
                        new
                        {
                            Id = 3,
                            HexCode = "#0000FF",
                            Name = "blue"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
