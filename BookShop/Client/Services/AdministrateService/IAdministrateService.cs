﻿using BookShop.Shared;

namespace BookShop.Client.Services.AdministrateService
{
    public interface IAdministrateService
    {
        Task<List<ExtendedProduct>> LoadExtendedProductsAsync();
        Task CreateProductAsync(ExtendedProduct extendedProduct);
    }
}
