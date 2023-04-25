using BookShop.Shared;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Edition> Editions { get; set; }
        public DbSet<Stats> Stats { get; set; }
        public DbSet<RegModel> regModels { get; set; }       

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {            

            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.EditionId });

            modelBuilder.Entity<Edition>().HasData(
                new Edition { Id = 1, Name = "Default" },
                new Edition { Id = 2, Name = "Paperback" },
                new Edition { Id = 3, Name = "E-Book" },
                new Edition { Id = 4, Name = "Audiobook" }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Романтика",
                    Url = "romantic",
                    Icon = "book"
                },
                new Category
                {
                    Id = 2,
                    Name = "Биография",
                    Url = "biography",
                    Icon = "book"
                },
                new Category
                {
                    Id = 3,
                    Name = "Кулинария",
                    Url = "cookbooks",
                    Icon = "book"
                });

            modelBuilder.Entity<RegModel>().HasData(
                new RegModel 
                {
                    Email = "admin@admin.ru",
                    Password = BCrypt.Net.BCrypt.HashPassword("admin"),
                    ConfirmPwd = BCrypt.Net.BCrypt.HashPassword("admin"),
                    Name = "Admin",
                    Surname = "Admin",
                    Address = "Admin",
                    Role = Role.Administrator
                });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Reminders of Him\r\nby Colleen Hoover",
                    Description = "Kenna Brown leaves prison after serving five years and tries to connect with her four-year-old daughter.",
                    Image = "https://a.allegroimg.com/s512/25ab2d/f78b89344b9e8aac238f8badf1eb/REMINDERS-OF-HIM-CZASTKA-CIEBIE-KTORA-ZNAM-Hoover"
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Title = "Hopeless\r\nby Colleen Hoover",
                    Description = "Sky, 17, fights her feelings for Dean, a boy who is not what he appears to be.",
                    Image = "https://m.media-amazon.com/images/I/71ZnF9mTahL._AC_UF1000,1000_QL80_.jpg"
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Title = "The Christmas Bookshop\r\nby Jenny Colgan",
                    Description = "After being laid off from her job, Carmen moves in with her successful sister Sofia.",
                    Image = "https://m.media-amazon.com/images/I/71c43tpsEaL.jpg"
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 2,
                    Title = "The Light We Carry\r\nby Michelle Obama",
                    Description = "Subtitle: \"Overcoming in Uncertain Times\"",
                    Image = "https://m.media-amazon.com/images/I/81YGTQ33HnL.jpg"
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 2,
                    Title = "Friends, Lovers, and the Big Terrible Thing\r\nby Matthew Perry",
                    Description = "The actor takes fans behind the scenes of \"Friends\" and opens up about his struggle with addiction and a life-threatening health scare.",
                    Image = "https://m.media-amazon.com/images/I/81tdvyI0MeL.jpg"
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 3,
                    Title = "Go-To Dinners\r\nby Ina Garten",
                    Description = "Subtitle: \"A Barefoot Contessa Cookbook\"",
                    Image = "https://m.media-amazon.com/images/I/81vsGXDc+FL._AC_UF1000,1000_QL80_.jpg"
                });                        

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant 
                {
                    ProductId = 1,
                    EditionId = 2,
                    Price = 1.50m,
                    OriginalPrice = 2.12m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 3,
                    Price = 1.50m,
                    OriginalPrice = 2.12m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 4,
                    Price = 10.00m,
                    OriginalPrice = 15.15m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 2,
                    Price = 4.20m,
                    OriginalPrice = 5.20m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 3,
                    Price = 3.50m,
                    OriginalPrice = 4.15m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 4,
                    Price = 8.99m,
                    OriginalPrice = 11.35m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 2,
                    Price = 12.00m,
                    OriginalPrice = 14.37m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 3,
                    Price = 9.00m,
                    OriginalPrice = 12.00m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 4,
                    Price = 47.99m,
                    OriginalPrice = 51.00m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    EditionId = 2,
                    Price = 12.15m,
                    OriginalPrice = 14.48m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    EditionId = 3,
                    Price = 7.50m,
                    OriginalPrice = 9.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    EditionId = 4,
                    Price = 17.00m,
                    OriginalPrice = 19.82m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    EditionId = 2,
                    Price = 11.70m,
                    OriginalPrice = 13.83m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    EditionId = 3,
                    Price = 9.50m,
                    OriginalPrice = 10.99m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    EditionId = 4,
                    Price = 27.99m,
                    OriginalPrice = 37.07m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    EditionId = 2,
                    Price = 9.15m,
                    OriginalPrice = 11.49m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    EditionId = 3,
                    Price = 7.13m,
                    OriginalPrice = 9.49m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    EditionId = 4,
                    Price = 22.99m,
                    OriginalPrice = 25.50m
                });
        }
    }
}
