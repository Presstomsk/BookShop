﻿using BookShop.Shared;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Edition> Editions { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books",
                    Icon = "book"
                });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "The Hitchhiker's Guide to the Galaxy",
                    Description = "The Hitchhiker's Guide to the Galaxy (sometimes referred to as HG2G, HHGTTG, H2G2, or tHGttG) is a comedy science fiction series created by Douglas Adams.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Title = "Ready Player One",
                    Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Title = "Nineteen Eighty-Four",
                    Description = "Nineteen Eighty-Four: A Novel, often published as 1984, is a dystopian social science fiction novel by English novelist George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime.",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                });

            modelBuilder.Entity<Edition>().HasData(
                new Edition { Id = 1, Name = "Paperback" },
                new Edition { Id = 2, Name = "E-Book"},
                new Edition { Id = 3, Name = "Audiobook"}
                );

            modelBuilder.SharedTypeEntity<Dictionary<string, object>>("EditionProduct")
                .HasData(
                new { EditionsId = 1, ProductsId = 1 },
                new { EditionsId = 2, ProductsId = 1 },
                new { EditionsId = 3, ProductsId = 1 },
                new { EditionsId = 1, ProductsId = 2 },
                new { EditionsId = 2, ProductsId = 2 },
                new { EditionsId = 3, ProductsId = 2 },
                new { EditionsId = 1, ProductsId = 3 },
                new { EditionsId = 2, ProductsId = 3 },
                new { EditionsId = 3, ProductsId = 3 }
                );
        }
    }
}
