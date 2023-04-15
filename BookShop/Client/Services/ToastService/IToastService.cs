namespace BookShop.Client.Services.ToastService
{
    public interface IToastService
    {
        event Action<string, ToastLevel>? OnShow;
        event Action? OnHide;
        void ShowToast(string message, ToastLevel level);
    }
}
