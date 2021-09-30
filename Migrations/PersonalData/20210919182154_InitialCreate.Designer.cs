﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MineApi.Data;

namespace MineApi.Migrations.PersonalData
{
    [DbContext(typeof(PersonalDataContext))]
    [Migration("20210919182154_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MineApi.Models.PersonalData", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

                    b.Property<long>("AuthId")
                        .HasColumnType("bigint");

                    b.Property<long>("ContectNo")
                        .HasColumnType("bigint");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MyAddress")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("MyEmail")
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("MyName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<long>("PIN")
                        .HasColumnType("bigint");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("imagePath")
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("ID");

                    b.ToTable("PersonalData");
                });
#pragma warning restore 612, 618
        }
    }
}