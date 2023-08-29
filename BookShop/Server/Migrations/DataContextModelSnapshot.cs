﻿// <auto-generated />
using System;
using BookShop.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookShop.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BookShop.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "camera-sir",
                            Name = "Телевизоры",
                            Url = "tv"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "camera-sir",
                            Name = "Холодильники",
                            Url = "fridge"
                        });
                });

            modelBuilder.Entity("BookShop.Shared.Edition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Editions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Default"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Paperback"
                        },
                        new
                        {
                            Id = 3,
                            Name = "E-Book"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Audiobook"
                        });
                });

            modelBuilder.Entity("BookShop.Shared.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TextOrderStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BookShop.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DateCreated = new DateTime(2023, 7, 21, 18, 7, 15, 860, DateTimeKind.Utc).AddTicks(9438),
                            Description = "Reproduces over a billion accurate colors resulting in picture quality that is natural and precise, and closer than ever to real life, enhanced by TRILUMINOS Pro.",
                            Image = "https://m.media-amazon.com/images/I/8127maI-DWL._AC_UY218_.jpg",
                            Title = "Sony 65 Inch 4K Ultra HD TV X80K",
                            Views = 0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            DateCreated = new DateTime(2023, 7, 21, 18, 7, 15, 860, DateTimeKind.Utc).AddTicks(9450),
                            Description = "Experience the magic of the big screen right from your couch. Every LG OLED comes loaded with Dolby Vision for extraordinary color, contrast and brightness, plus Dolby Atmos* for wrap-around sound. Land in the center of the action with LG's FILMMAKER MODE, allowing you to see films just as the director intended. ",
                            Image = "https://m.media-amazon.com/images/I/61fdYYpVYIL._AC_UY218_.jpg",
                            Title = "LG C3 Series 55-Inch Class OLED evo Smart TV OLED55C3PUA",
                            Views = 0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            DateCreated = new DateTime(2023, 7, 21, 18, 7, 15, 860, DateTimeKind.Utc).AddTicks(9453),
                            Description = "Enjoy the sleek throwback design and vibrant color of this COMMERCIAL COOL retro refrigerator (21.5” x 23” x 35.2”) while relishing its modern-day functionality. Complete with 4.0 cubic feet of storage and a stylish chrome plated door handle, our vintage style refrigerator (68.1 lbs.) combines old school charm with contemporary capabilities in three colors—cool red, sleek black, and stunning white. ",
                            Image = "https://m.media-amazon.com/images/I/51C83H1qy6L._AC_UY218_.jpg",
                            Title = "Commercial Cool CCRR4LR 4.0 Cu. Ft Freezer",
                            Views = 0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            DateCreated = new DateTime(2023, 7, 21, 18, 7, 15, 860, DateTimeKind.Utc).AddTicks(9455),
                            Description = "Vintage Coca-Cola Style: Featuring the iconic contoured glass bottle first introduced over 100 years ago, this vibrant red mini-fridge is a keystone piece for Coke memorabilia fans and collectors! ",
                            Image = "https://m.media-amazon.com/images/I/61ZnUOtbK7L._AC_SX569_.jpg",
                            Title = "Coca-Cola Classic Coke Bottle 4L Mini Fridge w/ 12V DC and 110V AC Cords",
                            Views = 0
                        });
                });

            modelBuilder.Entity("BookShop.Shared.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("EditionId")
                        .HasColumnType("int");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "EditionId");

                    b.HasIndex("EditionId");

                    b.ToTable("ProductVariant");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            EditionId = 1,
                            OriginalPrice = 165m,
                            Price = 140m
                        },
                        new
                        {
                            ProductId = 2,
                            EditionId = 1,
                            OriginalPrice = 189m,
                            Price = 170m
                        },
                        new
                        {
                            ProductId = 3,
                            EditionId = 1,
                            OriginalPrice = 307m,
                            Price = 285m
                        },
                        new
                        {
                            ProductId = 4,
                            EditionId = 1,
                            OriginalPrice = 73m,
                            Price = 64m
                        });
                });

            modelBuilder.Entity("BookShop.Shared.RegModel", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfirmPwd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Email");

                    b.ToTable("regModels");

                    b.HasData(
                        new
                        {
                            Email = "admin@admin.ru",
                            Address = "Admin",
                            ConfirmPwd = "$2a$11$C27HMxTt.DsulwPiJPw9I.6IUmV55MKvhulZrDMq.7Npy7N.YxQny",
                            Name = "Admin",
                            Password = "$2a$11$tlb4BCJV9W1FehsLY644AuEhBZg3F7HVwx.f2.4v4fSkzNJBjPEmi",
                            Role = 0,
                            Surname = "Admin"
                        });
                });

            modelBuilder.Entity("BookShop.Shared.Stats", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("LastVisit")
                        .HasColumnType("datetime2");

                    b.Property<int>("Visits")
                        .HasColumnType("int");

                    b.HasKey("Email");

                    b.ToTable("Stats");
                });

            modelBuilder.Entity("BookShop.Shared.Product", b =>
                {
                    b.HasOne("BookShop.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BookShop.Shared.ProductVariant", b =>
                {
                    b.HasOne("BookShop.Shared.Edition", "Edition")
                        .WithMany()
                        .HasForeignKey("EditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShop.Shared.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Edition");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BookShop.Shared.Product", b =>
                {
                    b.Navigation("Variants");
                });
#pragma warning restore 612, 618
        }
    }
}
