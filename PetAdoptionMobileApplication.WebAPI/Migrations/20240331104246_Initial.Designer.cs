﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetAdoptionMobileApplication.WebAPI.Data;

#nullable disable

namespace PetAdoptionMobileApplication.WebAPI.Migrations
{
    [DbContext(typeof(PetAppDbContext))]
    [Migration("20240331104246_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PetAdoptionMobileApplication.WebAPI.Data.Entities.Pet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AdoptionStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("PetName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("View")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pets");

                    b.HasData(
                        new
                        {
                            Id = new Guid("25c1865e-3b63-474f-8ab4-ecf7c7e8108c"),
                            AdoptionStatus = 1,
                            BirthDate = new DateTime(2015, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Breed = "Dog - Alaskan Klee Kai",
                            Description = "loyal, intelligent, vigilant",
                            Gender = 0,
                            Image = "alaskan_klee_kai.jpg",
                            IsActive = true,
                            PetName = "Bushu",
                            Price = 250.0,
                            View = 0
                        },
                        new
                        {
                            Id = new Guid("7cc2b416-8aef-46ac-8d75-f51ce86ca2b7"),
                            AdoptionStatus = 1,
                            BirthDate = new DateTime(2007, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Breed = "Cat - Siamese",
                            Description = "judgemental, loving, intelligent, fighter",
                            Gender = 1,
                            Image = "ioana.png",
                            IsActive = true,
                            PetName = "Ioana",
                            Price = 5000.0,
                            View = 0
                        },
                        new
                        {
                            Id = new Guid("4a9d468c-0e2a-4adb-8abe-af565af54587"),
                            AdoptionStatus = 1,
                            BirthDate = new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Breed = "Dog - Belgian Malinois",
                            Description = "confident, smart, hardworking",
                            Gender = 0,
                            Image = "jack.jpg",
                            IsActive = true,
                            PetName = "Jack",
                            Price = 500.0,
                            View = 0
                        },
                        new
                        {
                            Id = new Guid("a34ec152-1816-40fb-a0c3-5954e4e875b3"),
                            AdoptionStatus = 1,
                            BirthDate = new DateTime(2017, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Breed = "Cat - Snowshoe",
                            Description = "Loving, curious, family-oriented, vocal",
                            Gender = 1,
                            Image = "pearl.jpg",
                            IsActive = true,
                            PetName = "Pearl",
                            Price = 500.0,
                            View = 0
                        },
                        new
                        {
                            Id = new Guid("9e0b663c-35e1-4628-b734-b0b35defd012"),
                            AdoptionStatus = 1,
                            BirthDate = new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Breed = "Bunny - House Bunny",
                            Description = "Playful, caring, loving",
                            Gender = 0,
                            Image = "bobo.jpg",
                            IsActive = true,
                            PetName = "Bobo",
                            Price = 150.0,
                            View = 0
                        },
                        new
                        {
                            Id = new Guid("031d2caa-c85d-47f8-a9b3-a2f3d4ee965b"),
                            AdoptionStatus = 1,
                            BirthDate = new DateTime(2000, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Breed = "Turtle - Pond Slider",
                            Description = "Easy-going, chill, peaceful, loves cabbage",
                            Gender = 1,
                            Image = "tess.jpg",
                            IsActive = true,
                            PetName = "Tess",
                            Price = 160.0,
                            View = 0
                        },
                        new
                        {
                            Id = new Guid("605a2ad7-6934-4be1-aeef-ba91cbf9f914"),
                            AdoptionStatus = 1,
                            BirthDate = new DateTime(2018, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Breed = "Parrot - Amazon Parrot",
                            Description = "Loves to sing, adores seeds, likes to fly freely and always finds his way back home",
                            Gender = 0,
                            Image = "parrot.jpg",
                            IsActive = true,
                            PetName = "Alonso",
                            Price = 300.0,
                            View = 0
                        });
                });

            modelBuilder.Entity("PetAdoptionMobileApplication.WebAPI.Data.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Pass")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PetAdoptionMobileApplication.WebAPI.Data.Entities.UserAdoptions", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AdoptedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PetId");

                    b.HasIndex("UserId");

                    b.ToTable("Adoptions");
                });

            modelBuilder.Entity("PetAdoptionMobileApplication.WebAPI.Data.Entities.UserFavs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid>("PetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PetId");

                    b.HasIndex("UserId");

                    b.ToTable("Favs");
                });

            modelBuilder.Entity("PetAdoptionMobileApplication.WebAPI.Data.Entities.UserAdoptions", b =>
                {
                    b.HasOne("PetAdoptionMobileApplication.WebAPI.Data.Entities.Pet", "Pet")
                        .WithMany()
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetAdoptionMobileApplication.WebAPI.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pet");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PetAdoptionMobileApplication.WebAPI.Data.Entities.UserFavs", b =>
                {
                    b.HasOne("PetAdoptionMobileApplication.WebAPI.Data.Entities.Pet", "Pet")
                        .WithMany()
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetAdoptionMobileApplication.WebAPI.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pet");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}