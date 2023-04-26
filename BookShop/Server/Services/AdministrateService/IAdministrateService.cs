using BookShop.Shared;

namespace BookShop.Server.Services.AdministrateService
{
    public interface IAdministrateService
    {
        Task CreateProductAsync(ExtendedProduct extendedProduct);
        Task UpdateProductAsync(ExtendedProduct extendedProduct);
        Task DeleteProductAsync(ExtendedProduct extendedProduct);
    }
}
