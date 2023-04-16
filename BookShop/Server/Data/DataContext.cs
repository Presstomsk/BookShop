﻿using BookShop.Shared;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Edition> Editions { get; set; }
        public DbSet<Stats> Stats { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.EditionId });

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
                    Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg"                    
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Title = "Ready Player One",
                    Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg"                    
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Title = "Nineteen Eighty-Four",
                    Description = "Nineteen Eighty-Four: A Novel, often published as 1984, is a dystopian social science fiction novel by English novelist George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime.",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg"                    
                });

            modelBuilder.Entity<Edition>().HasData(
                new Edition { Id = 1, Name = "Default" },
                new Edition { Id = 2, Name = "Paperback" },
                new Edition { Id = 3, Name = "E-Book"},
                new Edition { Id = 4, Name = "Audiobook"}
                );            

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant 
                {
                    ProductId = 1,
                    EditionId = 2,
                    Price = 50.99m,
                    OriginalPrice = 60.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 3,
                    Price = 30.99m,
                    OriginalPrice = 40.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 4,
                    Price = 40.99m,
                    OriginalPrice = 50.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 2,
                    Price = 50.99m,
                    OriginalPrice = 60.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 3,
                    Price = 30.99m,
                    OriginalPrice = 40.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 4,
                    Price = 40.99m,
                    OriginalPrice = 50.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 2,
                    Price = 50.99m,
                    OriginalPrice = 60.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 3,
                    Price = 30.99m,
                    OriginalPrice = 40.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 4,
                    Price = 40.99m,
                    OriginalPrice = 50.99m
                }
                );
        }
    }
}
