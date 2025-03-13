using Housings.Domain.Entities;

namespace Housings.Application.Housings
{
    public interface IHousingsService
    {
        Task<IEnumerable<Housing>> GetAllHousings();
        Task<Housing?> GetById(int id);
    }
}