﻿// <auto-generated />
using System;
using BookShop.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BookShop.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230503143131_UpdateOrder")]
    partial class UpdateOrder
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BookShop.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Icon")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "book",
                            Name = "Романтика",
                            Url = "romantic"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "book",
                            Name = "Биография",
                            Url = "biography"
                        },
                        new
                        {
                            Id = 3,
                            Icon = "book",
                            Name = "Кулинария",
                            Url = "cookbooks"
                        });
                });

            modelBuilder.Entity("BookShop.Shared.Edition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

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
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("TextOrderStatus")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BookShop.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<int>("Views")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DateCreated = new DateTime(2023, 5, 3, 14, 31, 30, 834, DateTimeKind.Utc).AddTicks(772),
                            Description = "Kenna Brown leaves prison after serving five years and tries to connect with her four-year-old daughter.",
                            Image = "https://a.allegroimg.com/s512/25ab2d/f78b89344b9e8aac238f8badf1eb/REMINDERS-OF-HIM-CZASTKA-CIEBIE-KTORA-ZNAM-Hoover",
                            Title = "Reminders of Him\r\nby Colleen Hoover",
                            Views = 0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            DateCreated = new DateTime(2023, 5, 3, 14, 31, 30, 834, DateTimeKind.Utc).AddTicks(782),
                            Description = "Sky, 17, fights her feelings for Dean, a boy who is not what he appears to be.",
                            Image = "https://m.media-amazon.com/images/I/71ZnF9mTahL._AC_UF1000,1000_QL80_.jpg",
                            Title = "Hopeless\r\nby Colleen Hoover",
                            Views = 0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            DateCreated = new DateTime(2023, 5, 3, 14, 31, 30, 834, DateTimeKind.Utc).AddTicks(784),
                            Description = "After being laid off from her job, Carmen moves in with her successful sister Sofia.",
                            Image = "https://m.media-amazon.com/images/I/71c43tpsEaL.jpg",
                            Title = "The Christmas Bookshop\r\nby Jenny Colgan",
                            Views = 0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            DateCreated = new DateTime(2023, 5, 3, 14, 31, 30, 834, DateTimeKind.Utc).AddTicks(785),
                            Description = "Subtitle: \"Overcoming in Uncertain Times\"",
                            Image = "https://m.media-amazon.com/images/I/81YGTQ33HnL.jpg",
                            Title = "The Light We Carry\r\nby Michelle Obama",
                            Views = 0
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            DateCreated = new DateTime(2023, 5, 3, 14, 31, 30, 834, DateTimeKind.Utc).AddTicks(786),
                            Description = "The actor takes fans behind the scenes of \"Friends\" and opens up about his struggle with addiction and a life-threatening health scare.",
                            Image = "https://m.media-amazon.com/images/I/81tdvyI0MeL.jpg",
                            Title = "Friends, Lovers, and the Big Terrible Thing\r\nby Matthew Perry",
                            Views = 0
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            DateCreated = new DateTime(2023, 5, 3, 14, 31, 30, 834, DateTimeKind.Utc).AddTicks(787),
                            Description = "Subtitle: \"A Barefoot Contessa Cookbook\"",
                            Image = "https://m.media-amazon.com/images/I/81vsGXDc+FL._AC_UF1000,1000_QL80_.jpg",
                            Title = "Go-To Dinners\r\nby Ina Garten",
                            Views = 0
                        });
                });

            modelBuilder.Entity("BookShop.Shared.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("EditionId")
                        .HasColumnType("integer");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("numeric(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric(18,2)");

                    b.HasKey("ProductId", "EditionId");

                    b.HasIndex("EditionId");

                    b.ToTable("ProductVariant");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            EditionId = 2,
                            OriginalPrice = 2.12m,
                            Price = 1.50m
                        },
                        new
                        {
                            ProductId = 1,
                            EditionId = 3,
                            OriginalPrice = 2.12m,
                            Price = 1.50m
                        },
                        new
                        {
                            ProductId = 1,
                            EditionId = 4,
                            OriginalPrice = 15.15m,
                            Price = 10.00m
                        },
                        new
                        {
                            ProductId = 2,
                            EditionId = 2,
                            OriginalPrice = 5.20m,
                            Price = 4.20m
                        },
                        new
                        {
                            ProductId = 2,
                            EditionId = 3,
                            OriginalPrice = 4.15m,
                            Price = 3.50m
                        },
                        new
                        {
                            ProductId = 2,
                            EditionId = 4,
                            OriginalPrice = 11.35m,
                            Price = 8.99m
                        },
                        new
                        {
                            ProductId = 3,
                            EditionId = 2,
                            OriginalPrice = 14.37m,
                            Price = 12.00m
                        },
                        new
                        {
                            ProductId = 3,
                            EditionId = 3,
                            OriginalPrice = 12.00m,
                            Price = 9.00m
                        },
                        new
                        {
                            ProductId = 3,
                            EditionId = 4,
                            OriginalPrice = 51.00m,
                            Price = 47.99m
                        },
                        new
                        {
                            ProductId = 4,
                            EditionId = 2,
                            OriginalPrice = 14.48m,
                            Price = 12.15m
                        },
                        new
                        {
                            ProductId = 4,
                            EditionId = 3,
                            OriginalPrice = 9.99m,
                            Price = 7.50m
                        },
                        new
                        {
                            ProductId = 4,
                            EditionId = 4,
                            OriginalPrice = 19.82m,
                            Price = 17.00m
                        },
                        new
                        {
                            ProductId = 5,
                            EditionId = 2,
                            OriginalPrice = 13.83m,
                            Price = 11.70m
                        },
                        new
                        {
                            ProductId = 5,
                            EditionId = 3,
                            OriginalPrice = 10.99m,
                            Price = 9.50m
                        },
                        new
                        {
                            ProductId = 5,
                            EditionId = 4,
                            OriginalPrice = 37.07m,
                            Price = 27.99m
                        },
                        new
                        {
                            ProductId = 6,
                            EditionId = 2,
                            OriginalPrice = 11.49m,
                            Price = 9.15m
                        },
                        new
                        {
                            ProductId = 6,
                            EditionId = 3,
                            OriginalPrice = 9.49m,
                            Price = 7.13m
                        },
                        new
                        {
                            ProductId = 6,
                            EditionId = 4,
                            OriginalPrice = 25.50m,
                            Price = 22.99m
                        });
                });

            modelBuilder.Entity("BookShop.Shared.RegModel", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ConfirmPwd")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Email");

                    b.ToTable("regModels");

                    b.HasData(
                        new
                        {
                            Email = "admin@admin.ru",
                            Address = "Admin",
                            ConfirmPwd = "$2a$11$LjavvJCooa2xnLd4XGlB/.ByLaRrUc1uhDFhSFjyVC65ZhUnmeQJC",
                            Name = "Admin",
                            Password = "$2a$11$ULIbgWCmC5UIHza2uK8rPOiBHaBCRKF5lzxpDF7ApksdjRoH0lj/2",
                            Role = 0,
                            Surname = "Admin"
                        });
                });

            modelBuilder.Entity("BookShop.Shared.Stats", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastVisit")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Visits")
                        .HasColumnType("integer");

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
