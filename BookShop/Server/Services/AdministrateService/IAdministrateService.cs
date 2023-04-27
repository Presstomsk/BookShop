using BookShop.Shared;

namespace BookShop.Server.Services.AdministrateService
{
    public interface IAdministrateService
    {
        Task<AdmResult> CreateProductAsync(ExtendedProduct extendedProduct);
        Task<AdmResult> UpdateProductAsync(ExtendedProduct extendedProduct);
        Task<AdmResult> DeleteProductAsync(ExtendedProduct extendedProduct);
    }
}
