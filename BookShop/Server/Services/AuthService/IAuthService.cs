using BookShop.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Server.Services.AuthService
{
    public interface IAuthService
    {
        Task<LoginResult> RegistrationAsync(RegModel regModel);
        Task<LoginResult> LoginAsync(LoginModel loginModel);       
    }
}
