﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Pharma.API.Data;

#nullable disable

namespace Pharma.API.Migrations
{
    [DbContext(typeof(PharmaContext))]
    [Migration("20220516215129_Migration_AlterForeignKeys")]
    partial class Migration_AlterForeignKeys
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Pharma.API.Model.PersonModel", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PersonId"));

                    b.Property<string>("Adress_City")
                        .HasColumnType("text");

                    b.Property<string>("Adress_Complement")
                        .HasColumnType("text");

                    b.Property<string>("Adress_District")
                        .HasColumnType("text");

                    b.Property<int?>("Adress_Number")
                        .HasColumnType("integer");

                    b.Property<string>("Adress_Street")
                        .HasColumnType("text");

                    b.Property<string>("Adress_Zipcode")
                        .HasColumnType("text");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PersonId");

                    b.ToTable("Person", (string)null);
                });

            modelBuilder.Entity("Pharma.API.Model.PharmaModel", b =>
                {
                    b.Property<int>("PharmaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PharmaId"));

                    b.Property<string>("PharmaName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PharmaId");

                    b.ToTable("Pharma", (string)null);
                });

            modelBuilder.Entity("Pharma.API.Model.UserModel", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer");

                    b.Property<int>("PharmaId")
                        .HasColumnType("integer");

                    b.Property<int>("UserTypeId")
                        .HasColumnType("integer");

                    b.HasKey("UserId");

                    b.HasIndex("PersonId");

                    b.HasIndex("PharmaId");

                    b.HasIndex("UserTypeId");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("Pharma.API.Model.UserTypeModel", b =>
                {
                    b.Property<int>("UserTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserTypeId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserTypeId");

                    b.ToTable("UserType", (string)null);
                });

            modelBuilder.Entity("Pharma.API.Model.UserModel", b =>
                {
                    b.HasOne("Pharma.API.Model.PersonModel", "Person")
                        .WithMany("User")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pharma.API.Model.PharmaModel", "Pharma")
                        .WithMany("Users")
                        .HasForeignKey("PharmaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pharma.API.Model.UserTypeModel", "UserType")
                        .WithMany("Users")
                        .HasForeignKey("UserTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("Pharma");

                    b.Navigation("UserType");
                });

            modelBuilder.Entity("Pharma.API.Model.PersonModel", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("Pharma.API.Model.PharmaModel", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Pharma.API.Model.UserTypeModel", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}