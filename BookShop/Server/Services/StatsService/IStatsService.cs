namespace BookShop.Server.Services.StatsService
{
    public interface IStatsService
    {
        Task<int> GetVisitsAsync();
        Task IncrementVisitsAsync(string username);
    }
}
