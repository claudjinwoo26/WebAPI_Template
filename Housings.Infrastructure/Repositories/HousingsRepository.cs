using Housings.Domain.Entities;
using Housings.Domain.Repositories;
using Housings.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace Housings.Infrastructure.Repositories;

internal class HousingsRepository(HousingsDbContext dbContext) : IHousingsRepository
{
    public async Task<IEnumerable<Housing>> GetAllAsync() 
    {
        var housings = await dbContext.Housing.ToListAsync();
        return housings;
    }

    public async Task<Housing?> GetByIdAsync(int id)
    {
       var housings = await dbContext.Housing.FirstOrDefaultAsync(h => h.Id == id);
       return housings;
    }
}
