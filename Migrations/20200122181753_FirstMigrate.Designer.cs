﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using myapp.Models;

namespace myapp.Migrations
{
    [DbContext(typeof(MyApiContext))]
    [Migration("20200122181753_FirstMigrate")]
    partial class FirstMigrate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("myapp.Models.Organization", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("myapp.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<string>("organizationId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("organizationId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("myapp.Models.User", b =>
                {
                    b.HasOne("myapp.Models.Organization", "organization")
                        .WithMany()
                        .HasForeignKey("organizationId");
                });
#pragma warning restore 612, 618
        }
    }
}
