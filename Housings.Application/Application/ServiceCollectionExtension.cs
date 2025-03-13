using Housings.Application.Housings;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housings.Application.Application;

public static class ServiceCollectionExtension
{
    public static void AddApplication(this IServiceCollection services) 
    {
        services.AddScoped<IHousingsService, HousingsService>();
    }
}
