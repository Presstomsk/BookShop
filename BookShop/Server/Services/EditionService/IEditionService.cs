using BookShop.Shared;

namespace BookShop.Server.Services.EditionService
{
    public interface IEditionService
    {
        Task<List<Edition>> GetAllEditionsAsync();
    }
}
