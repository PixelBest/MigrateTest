﻿// <auto-generated />
using Excel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MigrateTest.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230829092816_migrate")]
    partial class migrate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Excel.EIs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("EI")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PokazatelsId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PokazatelsId");

                    b.ToTable("EIs");
                });

            modelBuilder.Entity("Excel.Gosts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Gost")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Gosts");
                });

            modelBuilder.Entity("Excel.Pokazatels", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("GostsId")
                        .HasColumnType("integer");

                    b.Property<string>("Pokazatel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("GostsId");

                    b.ToTable("Pokazatels");
                });

            modelBuilder.Entity("Excel.EIs", b =>
                {
                    b.HasOne("Excel.Pokazatels", null)
                        .WithMany("EIs")
                        .HasForeignKey("PokazatelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Excel.Pokazatels", b =>
                {
                    b.HasOne("Excel.Gosts", null)
                        .WithMany("Pokazatels")
                        .HasForeignKey("GostsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Excel.Gosts", b =>
                {
                    b.Navigation("Pokazatels");
                });

            modelBuilder.Entity("Excel.Pokazatels", b =>
                {
                    b.Navigation("EIs");
                });
#pragma warning restore 612, 618
        }
    }
}
