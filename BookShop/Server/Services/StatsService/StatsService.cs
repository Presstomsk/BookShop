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

        public async Task IncrementVisitsAsync(string email)
        {
            var stats = await _context.Stats.FirstOrDefaultAsync(s => s.Email.Equals(email));

            if (stats == null)
            {
                _context.Stats.Add(new Stats
                {
                    Visits = 1,
                    Email = email,
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
