﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Stuco.Infrastructure.Persistence;

#nullable disable

namespace Stuco.Infrastructure.Migrations
{
    [DbContext(typeof(StucoDBContext))]
    [Migration("20240604215507_new")]
    partial class @new
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Stuco.Domain.Entities.Klant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Klanten");
                });

            modelBuilder.Entity("Stuco.Domain.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("KlantId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("KlantId");

                    b.ToTable("Projecten");
                });

            modelBuilder.Entity("Stuco.Domain.Entities.Stukadoor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Stukadoren");
                });

            modelBuilder.Entity("Stuco.Domain.Entities.Project", b =>
                {
                    b.HasOne("Stuco.Domain.Entities.Klant", "Klant")
                        .WithMany("Projecten")
                        .HasForeignKey("KlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Klant");
                });

            modelBuilder.Entity("Stuco.Domain.Entities.Stukadoor", b =>
                {
                    b.HasOne("Stuco.Domain.Entities.Project", "Project")
                        .WithMany("Stukadoren")
                        .HasForeignKey("ProjectId");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Stuco.Domain.Entities.Klant", b =>
                {
                    b.Navigation("Projecten");
                });

            modelBuilder.Entity("Stuco.Domain.Entities.Project", b =>
                {
                    b.Navigation("Stukadoren");
                });
#pragma warning restore 612, 618
        }
    }
}
