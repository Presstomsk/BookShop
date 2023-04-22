using BookShop.Shared;

namespace BookShop.Client.Services.AuthService
{
    public interface IAuthService
    {
        Task<LoginResult?> RegistrationAsync(RegModel regModel);
        Task<LoginResult?> LoginAsync(LoginModel loginModel);        
    }
}
