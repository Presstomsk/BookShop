using Blazored.LocalStorage;
using Blazored.Toast;
using BookShop.Client.Services.AdministrateService;
using BookShop.Client.Services.AuthService;
using BookShop.Client.Services.CartService;
using BookShop.Client.Services.CategoryService;
using BookShop.Client.Services.EditionService;
using BookShop.Client.Services.OrderService;
using BookShop.Client.Services.ProductService;
using BookShop.Client.Services.StatsService;
using BookShop.Client.Services.Validators;
using BookShop.Shared;
using FluentValidation;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;

namespace BookShop.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<ICartService, CartService>();
            builder.Services.AddScoped<IStatsService, StatsService>();
            builder.Services.AddScoped<IAuthService, AuthService>();
            builder.Services.AddScoped<IAdministrateService, AdministrateService>();
            builder.Services.AddScoped<IEditionService, EditionService>();
            builder.Services.AddScoped<IOrderService, OrderService>();
            builder.Services.AddScoped<IRegModel, RegModel>();
            builder.Services.AddScoped<ILoginModel, LoginModel>();
            builder.Services.AddScoped<IExtendedProduct, ExtendedProduct>();
            builder.Services.AddScoped<AbstractValidator<IRegModel>, RegModelValidator>();
            builder.Services.AddScoped<AbstractValidator<ILoginModel>, LoginModelValidator>();
            builder.Services.AddScoped<AbstractValidator<IExtendedProduct>, ExtendedProductValidator>();
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddBlazoredToast();
            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
            builder.Services.AddScoped<DialogService>();


            await builder.Build().RunAsync();
        }
    }
}