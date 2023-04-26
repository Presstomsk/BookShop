using BookShop.Server.Data;
using BookShop.Shared;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Server.Services.AdministrateService
{
    public class AdministrateService : IAdministrateService
    {
        private readonly DataContext _dataContext;

        public AdministrateService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task CreateProductAsync(ExtendedProduct extendedProduct)
        {
            var categoryId = _dataContext.Categories.First(c => c.Name!.Equals(extendedProduct.CategoryName)).Id;
            var editionId = _dataContext.Editions.First(e => e.Name!.Equals(extendedProduct.EditionName)).Id;

            var product = new Product
            {
                Title = extendedProduct.Title,
                Description = extendedProduct.Description,
                Image = extendedProduct.Image,
                CategoryId = categoryId,                
                Views = 0
            };

            var productVariant = new ProductVariant
            {
                Price = extendedProduct.Price,
                OriginalPrice = extendedProduct.OriginalPrice,
                EditionId = editionId,
                Product = product
            };

            await _dataContext.AddAsync(productVariant);
            await _dataContext.AddAsync(product);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(ExtendedProduct extendedProduct)
        {
            var product = _dataContext.Products.Include(p => p.Variants).First(p => p.Id == extendedProduct.ProductId);
            var edition = product.Variants.First(pv => pv.ProductId == product.Id
                                                    && pv.EditionId == extendedProduct.EditionId);
            if (product.Variants.Count > 0)
            {
                product.Variants.Remove(edition);

                if (product.Variants.Count == 0)
                {
                    _dataContext.Products.Remove(product);
                }
            }

            await _dataContext.SaveChangesAsync();
        }

        public async Task UpdateProductAsync(ExtendedProduct extendedProduct)
        {
            var categoryId = _dataContext.Categories.First(c => c.Name!.Equals(extendedProduct.CategoryName)).Id;
            var product = _dataContext.Products.Include(p => p.Variants).First(p => p.Id == extendedProduct.ProductId);
            product.Title = extendedProduct.Title;
            product.Description = extendedProduct.Description;
            product.Image = extendedProduct.Image;
            product.CategoryId = categoryId;
            product.DateUpdated = DateTime.UtcNow;
            var edition = product.Variants.First(pv => pv.ProductId == product.Id
                                                    && pv.EditionId == extendedProduct.EditionId);
            edition.OriginalPrice = extendedProduct.OriginalPrice;
            edition.Price = extendedProduct.Price;
            await _dataContext.SaveChangesAsync();
        }
    }
}
