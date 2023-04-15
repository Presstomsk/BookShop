using Blazored.LocalStorage;
using Blazored.Toast;
using BookShop.Client.Services.CategoryService;
using BookShop.Client.Services.ProductService;
using BookShop.Client.Services.ToastService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


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
            builder.Services.AddScoped<IToastService, ToastService>();
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddBlazoredToast();
            

            await builder.Build().RunAsync();
        }
    }
}