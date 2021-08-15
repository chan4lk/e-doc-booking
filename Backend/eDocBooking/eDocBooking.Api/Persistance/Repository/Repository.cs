using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using eDocBooking.Api.Persistance.Models;
using Microsoft.EntityFrameworkCore;

namespace eDocBooking.Api.Persistance.Repository
{
    public class Repository<TModel> : IRepository<TModel> where TModel : Entity
    {
        protected readonly IApplicationDbContext _context;

        public Repository(IApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(TModel entity)
        {
            _context.Set<TModel>().Add(entity);
        }

        public async Task<Guid> AddAsync(TModel entity, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await _context.Set<TModel>().AddAsync(entity, cancellationToken);
            return result.Entity.Id;
        }

        public void Delete(TModel entity)
        {
            _context.Set<TModel>().Remove(entity);
        }

        public async Task<IEnumerable<TModel>> FindAsync(Func<TModel, bool> predicate)
        {
            return await _context.Set<TModel>().Where(predicate).AsQueryable().ToListAsync();
        }

        public async Task<TModel> GetAsync(Guid id)
        {
            return await _context.Set<TModel>().FindAsync(id);
        }

        public async Task<IEnumerable<TModel>> GetAllAsync()
        {
            return await _context.Set<TModel>().ToListAsync();
        }      

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return _context.SaveChangesAsync(cancellationToken);
        }

        public void Update(TModel entity)
        {
            _context.SetEntryState(entity, EntityState.Modified);
        }
    }
}
