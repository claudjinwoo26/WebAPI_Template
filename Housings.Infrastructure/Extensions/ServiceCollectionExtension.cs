using Housings.Domain.Repositories;
using Housings.Infrastructure.Persistence;
using Housings.Infrastructure.Repositories;
using Housings.Infrastructure.Seeder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Housings.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration) 
        {
            //Get Connection string from appsettings.development.json
            var connectionString = configuration.GetConnectionString("HousingsDb");
            services.AddDbContext<HousingsDbContext>(options => options.UseSqlServer(connectionString));

            services.AddScoped<IHousingSeeder, HousingSeeder>();
            services.AddScoped<IHousingsRepository, HousingsRepository>();
        }
    }
}
