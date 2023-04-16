using BookShop.Server.Data;
using BookShop.Shared;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Server.Services.StatsService
{
    public class StatsService : IStatsService
    {
        private readonly DataContext _context;

        public StatsService(DataContext context)
        {
            _context = context;
        }

        public async Task<int> GetVisitsAsync()
        {
            return await _context.Stats.SumAsync(s => s.Visits);           
        }

        public async Task IncrementVisitsAsync(string username)
        {
            var stats = await _context.Stats.FirstOrDefaultAsync(s => s.Username.Equals(username));

            if (stats == null)
            {
                _context.Stats.Add(new Stats
                {
                    Visits = 1,
                    Username = username,
                    LastVisit = DateTime.UtcNow,
                });
            }
            else if (stats.LastVisit != null && ((DateTime)stats.LastVisit).Date != DateTime.UtcNow.Date)
            {
                stats.Visits++;
                stats.LastVisit = DateTime.UtcNow;
            }

            await _context.SaveChangesAsync();
        }
    }
}
