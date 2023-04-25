using Blazored.LocalStorage;
using BookShop.Client.Services.CategoryService;
using BookShop.Client.Services.EditionService;
using BookShop.Client.Services.ProductService;
using BookShop.Shared;
using System.Linq.Dynamic.Core.Tokenizer;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace BookShop.Client.Services.AdministrateService
{
    public class AdministrateService : IAdministrateService
    {
        private readonly IProductService _productService;
        private readonly HttpClient _http;
        private readonly ICategoryService _categoryService;
        private readonly IEditionService _editionService;
        private readonly ILocalStorageService _localStorageService;

        public AdministrateService(IProductService productService
                                   , HttpClient http 
                                   , ICategoryService categoryService
                                   , IEditionService editionService
                                   , ILocalStorageService localStorageService)
        {
            _productService = productService;
            _http = http;
            _categoryService = categoryService;
            _editionService = editionService;
            _localStorageService = localStorageService;
        }

        public async Task<List<ExtendedProduct>> LoadExtendedProductsAsync()
        {
            var extendedProducts = new List<ExtendedProduct>();
            var products = await _http.GetFromJsonAsync<List<Product>?>("Product");

            if (products != null)
            {
                foreach (var product in products)
                {
                    foreach (var variant in product.Variants)
                    {
                        extendedProducts?.Add(new ExtendedProduct
                        {
                            ProductId = product.Id,
                            EditionId = variant.EditionId,
                            Title = product.Title,
                            Description = product.Description,
                            Image = product.Image,
                            CategoryName = product.Category?.Name,
                            EditionName = variant.Edition?.Name,
                            Price = variant.Price,
                            OriginalPrice = variant.OriginalPrice,
                            DateCreated = product.DateCreated,
                            DateUpdated = product.DateUpdated,
                            Views = product.Views
                        });
                    }
                }
            }

            return extendedProducts;
        }

        public async Task CreateProductAsync(ExtendedProduct extendedProduct)
        {
            await _categoryService.LoadCategoriesAsync();
            var editions = await _editionService.GetAllEditionsAsync();

            var product = new Product
            {
                Title = extendedProduct.Title,
                Description = extendedProduct.Description,
                Image = extendedProduct.Image,
                Category = _categoryService.Categories?.FirstOrDefault(c => c.Name!.ToLower().Equals(extendedProduct.CategoryName)),
                Variants = new List<ProductVariant>(),
                IsDeleted = false,
                Views = 0                
            };

            product.Variants.Add(new ProductVariant
            {
                Price = extendedProduct.Price,
                OriginalPrice = extendedProduct.OriginalPrice,
                Edition = editions?.FirstOrDefault(e => e.Name!.ToLower().Equals(extendedProduct.EditionName)),
                Product = product
            });

            var request = new HttpRequestMessage(HttpMethod.Post, "/Administrate/addbook");

            request.Headers.Add("Authorization", "Bearer " + await _localStorageService.GetItemAsync<string>("token"));
            Console.WriteLine(await _localStorageService.GetItemAsync<string>("token"));
            Console.WriteLine("Bearer " + await _localStorageService.GetItemAsync<string>("token"));
            using (var response = await _http.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
            }
        }
    }
}
