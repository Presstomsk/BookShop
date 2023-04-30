namespace BookShop.Client.Services.StatsService
{
    public interface IStatsService
    {
        Task GetVisitsAsync();
        Task IncrementVisitsAsync(string email);
    }
}
