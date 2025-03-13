using Housings.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housings.Domain.Repositories
{
    public interface IHousingsRepository
    {
        Task<IEnumerable<Housing>> GetAllAsync();

        Task<Housing?> GetByIdAsync(int id);
    }
}
