
using Housings.Domain.Entities;
using Housings.Domain.Repositories;
using Microsoft.Extensions.Logging;

namespace Housings.Application.Housings;

internal class HousingsService(IHousingsRepository housingsRepository, ILogger<HousingsService> logger) : IHousingsService
{
    public async Task<IEnumerable<Housing>> GetAllHousings()
    {
        logger.LogInformation("Getting all Housings");
        var housings = await housingsRepository.GetAllAsync();
        return housings;
    }

    public async Task<Housing?> GetById(int id)
    {
        logger.LogInformation($"Getting housing with the id of {id} ");
        var housing = await housingsRepository.GetByIdAsync(id);
        return housing;
    }
}
