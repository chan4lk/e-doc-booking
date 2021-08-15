using System;
using eDocBooking.Api.Persistance.Repository;
using eDocBooking.Api.Persistance.Repository.CosmosDb;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace eDocBooking.Api.Persistance
{
    public static class Extensitons
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IApplicationDbContext, CosmosDbContext>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            return services;
        }
    }
}
