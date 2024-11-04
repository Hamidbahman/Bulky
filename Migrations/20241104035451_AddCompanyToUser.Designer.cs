﻿// <auto-generated />
using System;
using Bulky.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bulky.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241104035451_AddCompanyToUser")]
    partial class AddCompanyToUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bulky.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "داستان"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "شعر"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "فلسفه"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "جامعه شناسی"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 5,
                            Name = "تئاتر"
                        },
                        new
                        {
                            Id = 6,
                            DisplayOrder = 6,
                            Name = "سینما"
                        },
                        new
                        {
                            Id = 7,
                            DisplayOrder = 7,
                            Name = "هنر"
                        },
                        new
                        {
                            Id = 8,
                            DisplayOrder = 8,
                            Name = "عکاسی"
                        },
                        new
                        {
                            Id = 9,
                            DisplayOrder = 9,
                            Name = "معماری"
                        },
                        new
                        {
                            Id = 10,
                            DisplayOrder = 10,
                            Name = "جستار"
                        });
                });

            modelBuilder.Entity("Bulky.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            City = "تهران",
                            Name = "بیدگل",
                            PhoneNumber = "021-66212141",
                            PostalCode = "110",
                            State = "تهران",
                            StreetAddress = "فرشته-خیابان مریم"
                        },
                        new
                        {
                            Id = 3,
                            City = "تهران",
                            Name = "چشمه",
                            PhoneNumber = "021-22343465",
                            PostalCode = "764",
                            State = "تهران",
                            StreetAddress = "خیابان انقلاب-12فروردین-پلاک22"
                        },
                        new
                        {
                            Id = 4,
                            City = "تهران",
                            Name = "مروارید",
                            PhoneNumber = "021-21621032",
                            PostalCode = "545",
                            State = "تهران",
                            StreetAddress = "خیابان سهروردی-بالاتر از مطهری"
                        },
                        new
                        {
                            Id = 5,
                            City = "تهران",
                            Name = "گیلگمش",
                            PhoneNumber = "021-77317731",
                            PostalCode = "655",
                            State = "تهران",
                            StreetAddress = "خیابان انقلاب-روبروی دانشگاه"
                        },
                        new
                        {
                            Id = 6,
                            City = "تهران",
                            Name = "نی",
                            PhoneNumber = "021-22343421",
                            PostalCode = "412",
                            State = "تهران",
                            StreetAddress = "خیابان کریم خان-روبروی ایرانشهر"
                        },
                        new
                        {
                            Id = 7,
                            City = "رشت",
                            Name = "ارمغان",
                            PhoneNumber = "021-44766781",
                            PostalCode = "212",
                            State = "رشت",
                            StreetAddress = "ژاندارمری-خیابان اول"
                        });
                });

            modelBuilder.Entity("Bulky.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "فرانتس کافکا",
                            CategoryId = 1,
                            Description = "ژوزف ک را به جرمی که نمیدادیم گرفته اند",
                            ImageUrl = "",
                            ListPrice = 30.0,
                            Price = 40.0,
                            Price100 = 20.0,
                            Price50 = 25.0,
                            Publisher = "مروارید",
                            Title = "محاکمه"
                        },
                        new
                        {
                            Id = 2,
                            Author = "فرانتس کافکا",
                            CategoryId = 1,
                            Description = "گرگور زامزا از خواب بیدار می شود",
                            ImageUrl = "",
                            ListPrice = 25.0,
                            Price = 35.0,
                            Price100 = 19.0,
                            Price50 = 22.0,
                            Publisher = "مروارید",
                            Title = "مسخ"
                        },
                        new
                        {
                            Id = 3,
                            Author = "آدرین مارتین",
                            CategoryId = 6,
                            Description = "بررسی میزانسن از سینمای کلاسیک تا معاصر",
                            ImageUrl = "",
                            ListPrice = 90.0,
                            Price = 100.0,
                            Price100 = 75.0,
                            Price50 = 85.0,
                            Publisher = "بیدگل",
                            Title = "میزانسن و سبک فیلم"
                        },
                        new
                        {
                            Id = 4,
                            Author = "میشل فوکو",
                            CategoryId = 4,
                            Description = "تولد زندان",
                            ImageUrl = "",
                            ListPrice = 88.0,
                            Price = 100.0,
                            Price100 = 73.0,
                            Price50 = 80.0,
                            Publisher = "نی",
                            Title = "مراقبت و تنبیه"
                        },
                        new
                        {
                            Id = 5,
                            Author = "علی اکبر علیزاد",
                            CategoryId = 5,
                            Description = "مجموعه مقالات",
                            ImageUrl = "",
                            ListPrice = 130.0,
                            Price = 150.0,
                            Price100 = 99.0,
                            Price50 = 120.0,
                            Publisher = "بیدگل",
                            Title = "رویکردهایی به نظریه اجرا"
                        },
                        new
                        {
                            Id = 6,
                            Author = "ماگدا سابو",
                            CategoryId = 1,
                            Description = "درها و حرف ها",
                            ImageUrl = "",
                            ListPrice = 45.0,
                            Price = 50.0,
                            Price100 = 32.0,
                            Price50 = 39.0,
                            Publisher = "بیدگل",
                            Title = "در"
                        },
                        new
                        {
                            Id = 7,
                            Author = "هاروکی موراکامی",
                            CategoryId = 1,
                            Description = "رمان جریان ساز",
                            ImageUrl = "",
                            ListPrice = 80.0,
                            Price = 100.0,
                            Price100 = 70.0,
                            Price50 = 75.0,
                            Publisher = "چشمه",
                            Title = "کافکا در ساحل"
                        },
                        new
                        {
                            Id = 8,
                            Author = "جودیت باتلر",
                            CategoryId = 4,
                            Description = "تحولات اجتماعی",
                            ImageUrl = "",
                            ListPrice = 59.0,
                            Price = 70.0,
                            Price100 = 45.0,
                            Price50 = 49.0,
                            Publisher = "نی",
                            Title = "نیروی خشونت گریز"
                        },
                        new
                        {
                            Id = 9,
                            Author = "ون دایکسترا",
                            CategoryId = 10,
                            Description = "اصول ابتدایی",
                            ImageUrl = "",
                            ListPrice = 40.0,
                            Price = 45.0,
                            Price100 = 30.0,
                            Price50 = 35.0,
                            Publisher = "ارمغان",
                            Title = "ریاضیات برای کودکان"
                        },
                        new
                        {
                            Id = 10,
                            Author = "ایمانوئل کانت",
                            CategoryId = 3,
                            Description = "اثر سترگ ایمانوئل کانت",
                            ImageUrl = "",
                            ListPrice = 100.0,
                            Price = 120.0,
                            Price100 = 99.0,
                            Price50 = 110.0,
                            Publisher = "نی",
                            Title = "نقد عقل محض"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator().HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Bulky.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("CompanyId");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Bulky.Models.Product", b =>
                {
                    b.HasOne("Bulky.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bulky.Models.ApplicationUser", b =>
                {
                    b.HasOne("Bulky.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.Navigation("Company");
                });
#pragma warning restore 612, 618
        }
    }
}
