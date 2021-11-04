﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyGarage.WebApi.Models;

namespace MyGarage.WebApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyGarage.Shared.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsGood")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            ClientId = 1,
                            Comment = "Po naprawie przynosi ciasto",
                            Email = "mackowiak.dominika@onet.pl",
                            IsGood = true,
                            Name = "Dominika Maćkowiak",
                            PhoneNumber = "123456789"
                        },
                        new
                        {
                            ClientId = 2,
                            Comment = "Nasrał mi do ryżu",
                            Email = "proallone76@gmail.com",
                            IsGood = false,
                            Name = "Bartosz Jakubski",
                            PhoneNumber = "123456789"
                        });
                });

            modelBuilder.Entity("MyGarage.Shared.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ExitDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("JobCategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("JoinedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("JobCategoryId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            BirthDate = new DateTime(1979, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Brussels",
                            Comment = "Lorem Ipsum",
                            Email = "bethany@bethanyspieshop.com",
                            FirstName = "Bethany",
                            JobCategoryId = 1,
                            JoinedDate = new DateTime(2015, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Smith",
                            PhoneNumber = "324777888773",
                            Street = "Grote Markt 1",
                            Zip = "1000"
                        },
                        new
                        {
                            EmployeeId = 2,
                            BirthDate = new DateTime(1979, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Antwerp",
                            Comment = "Lorem Ipsum",
                            Email = "gill@bethanyspieshop.com",
                            FirstName = "Gill",
                            JobCategoryId = 2,
                            JoinedDate = new DateTime(2017, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Cleeren",
                            PhoneNumber = "33999909923",
                            Street = "New Street",
                            Zip = "2000"
                        });
                });

            modelBuilder.Entity("MyGarage.Shared.JobCategory", b =>
                {
                    b.Property<int>("JobCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("JobCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobCategoryId");

                    b.ToTable("JobCategories");

                    b.HasData(
                        new
                        {
                            JobCategoryId = 1,
                            JobCategoryName = "Electromechanic"
                        },
                        new
                        {
                            JobCategoryId = 2,
                            JobCategoryName = "Mechanic"
                        },
                        new
                        {
                            JobCategoryId = 3,
                            JobCategoryName = "Accountant"
                        },
                        new
                        {
                            JobCategoryId = 4,
                            JobCategoryName = "Car tinsmith"
                        },
                        new
                        {
                            JobCategoryId = 5,
                            JobCategoryName = "Car painter"
                        },
                        new
                        {
                            JobCategoryId = 6,
                            JobCategoryName = "Customer service office"
                        });
                });

            modelBuilder.Entity("MyGarage.Shared.Repair", b =>
                {
                    b.Property<int>("RepairId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CarInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RepairId");

                    b.ToTable("Repairs");

                    b.HasData(
                        new
                        {
                            RepairId = 1,
                            CarInfo = "Volkswagen Ogór",
                            Comment = "Wymiana silnika",
                            Email = "wojciech.sz2@o2.pl",
                            Name = "Wojciech Szurgot",
                            PhoneNumber = "123456789"
                        });
                });

            modelBuilder.Entity("MyGarage.Shared.Employee", b =>
                {
                    b.HasOne("MyGarage.Shared.JobCategory", "JobCategory")
                        .WithMany()
                        .HasForeignKey("JobCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
