using BookShop.Shared;

namespace BookShop.Client.Services.EditionService
{
    public interface IEditionService
    {
        Task<List<Edition>?> GetAllEditionsAsync();
    }
}
