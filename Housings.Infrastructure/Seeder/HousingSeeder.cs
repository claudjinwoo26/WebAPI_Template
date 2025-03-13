using Housings.Domain.Entities;
using Housings.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housings.Infrastructure.Seeder
{
    internal class HousingSeeder(HousingsDbContext dbContext) : IHousingSeeder
    {
        public async Task Seed()
        {
            if (await dbContext.Database.CanConnectAsync())
            {
                if (!dbContext.Housing.Any())
                {
                    var housings = GetHousings();
                    dbContext.Housing.AddRange(housings);
                    await dbContext.SaveChangesAsync();
                }
            }
        }

        private IEnumerable<Housing> GetHousings()
        {
            List<Housing> housings =
            [
                new()
                {
                    Name = "Kadamay",
                    Description = "Taga Bulacan",
                    Furnitures =
                    [
                        new()
                        {
                            Name = "Bed",
                            Description = "King size bed",
                        },
                        new()
                        {
                            Name = "Sofa",
                            Description = "Single Sofa",
                        },
                    ],
                    Address =  new()
                    {
                        City ="Bulacan City",
                        Street = "Nacalub",
                        PostalCode = "1105"
                    }
                },
                new Housing()
                {
                    Name = "NHA",
                    Description = "Taga Laguna",
                    Address = new Address()
                    {
                        City = "Laguna",
                        Street = "Anugal",
                        PostalCode = "1110",
                    }
                }
           ];

            return housings;
        }
    }
}
