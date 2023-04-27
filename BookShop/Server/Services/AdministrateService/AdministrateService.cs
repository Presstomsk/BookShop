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

        public async Task<AdmResult> CreateProductAsync(ExtendedProduct extendedProduct)
        {           
            try
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

                throw new Exception();

                return new AdmResult
                {
                    Success = true
                };
            }
            catch(Exception)
            {
                return new AdmResult
                {
                    Success = false,
                    Message = StringConsts.ERROR_ADD_TO_DB
                };
            }
        }

        public async Task<AdmResult> DeleteProductAsync(ExtendedProduct extendedProduct)
        {
            try
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

                return new AdmResult
                {
                    Success = true
                };
            }
            catch(Exception)
            {
                return new AdmResult
                {
                    Success = false,
                    Message = StringConsts.ERROR_DELETE_TO_DB
                };
            }
        }

        public async Task<AdmResult> UpdateProductAsync(ExtendedProduct extendedProduct)
        {
            try
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

                return new AdmResult
                {
                    Success = true
                };
            }
            catch(Exception)
            {
                return new AdmResult
                {
                    Success = false,
                    Message = StringConsts.ERROR_UPDATE_TO_DB
                };
            }
        }
    }
}
