using System;
using System.Threading;
using System.Threading.Tasks;
using eDocBooking.Api.Persistance.Models;
using Microsoft.EntityFrameworkCore;

namespace eDocBooking.Api.Persistance.Repository
{
    public interface IApplicationDbContext
    {
        public DbSet<Location> Locations { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        void SetEntryState<TEntry>(TEntry entry, EntityState entityState);
        DbSet<TModel> Set<TModel>() where TModel : class;
    }
}
