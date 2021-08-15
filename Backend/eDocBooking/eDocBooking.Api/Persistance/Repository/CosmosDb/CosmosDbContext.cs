using System;
using System.Diagnostics.CodeAnalysis;
using eDocBooking.Api.Persistance.Configuration;
using eDocBooking.Api.Persistance.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace eDocBooking.Api.Persistance.Repository.CosmosDb
{
    public class CosmosDbContext : DbContext, IApplicationDbContext
    {
        private readonly IConfiguration configuration;

        public CosmosDbContext([NotNull] DbContextOptions options, IConfiguration configuration) : base(options)
        {
            this.configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var accountEndpoint = configuration["CosmosDB:AccountEndpoint"];
            var accountKey = configuration["CosmosDB:AccountKey"];
            var dbName = configuration["CosmosDB:DBName"];
            optionsBuilder.UseCosmos(accountEndpoint, accountKey, dbName);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultContainer(configuration["CosmosDB:Container"]);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LocationConfiguration).Assembly);
        }

        public void SetEntryState<TEntry>(TEntry entry, EntityState entityState)
        {
            this.Entry(entry).State = entityState;
        }

        public DbSet<Location> Locations { get; set; }
    }
}
