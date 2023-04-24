using BookShop.Server.Data;
using BookShop.Shared;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Server.Services.EditionService
{
    public class EditionService : IEditionService
    {
        private readonly DataContext _context;

        public EditionService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Edition>> GetAllEditionsAsync()
        {
            return await _context.Editions.ToListAsync();
        }
    }
}
