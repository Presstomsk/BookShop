using BookShop.Shared;

namespace BookShop.Client.Services.AdministrateService
{
    public interface IAdministrateService
    {
        Task<List<ExtendedProduct>> LoadExtendedProductsAsync();
        Task<AdmResult> CreateProductAsync(ExtendedProduct extendedProduct);
        Task<AdmResult> UpdateProductAsync(ExtendedProduct extendedProduct);
        Task<AdmResult> DeleteProductAsync(ExtendedProduct extendedProduct);
    }
}
