using BookShop.Shared;

namespace BookShop.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        void LoadProducts();
    }
}
