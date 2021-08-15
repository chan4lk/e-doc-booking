using System;
using System.Collections.Generic;
using eDocBooking.Api.Persistance.Models;
using eDocBooking.Api.Persistance.Repository;
using eDocBooking.Api.Persistance.Repository.CosmosDb;
using Microsoft.EntityFrameworkCore;
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

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Location>()
                .HasData(
                new Location
                {
                    Id = new Guid("cc46e30b-11b2-448c-8bff-bff527c13066"),
                    Type = nameof(Location),
                    Name = "North Ryde",
                    OrganizationId = new Guid("bbd11a5a-7ec8-4e4e-b8ba-a7ec31ed32e9")
                }
            );

            modelBuilder
                .Entity<Location>()
                .OwnsMany(x => x.Addresses)
                .HasData(new HashSet<Address>
                    {
                        new Address
                        {
                            Id = new Guid("b55ba40a-53e5-42e3-acff-7432b876ae7a"),
                            City = "North Ryde",
                            LocationId = new Guid("cc46e30b-11b2-448c-8bff-bff527c13066")
                        }
                    });

            modelBuilder
                .Entity<Location>()
                .OwnsMany(x => x.Contacts)
                .HasData(new HashSet<Contact>
                    {
                        new Contact
                        {
                            Id = new Guid("e5f617be-30c0-4ef7-8564-18cfb1af90e1"),
                            Type = "Mobile",
                            Details = "0714411600",
                            LocationId = new Guid("cc46e30b-11b2-448c-8bff-bff527c13066")
                        }
                    });
        }
    }
}
