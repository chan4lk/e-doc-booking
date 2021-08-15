using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using eDocBooking.Api.Persistance.Models;

namespace eDocBooking.Api.Persistance.Repository
{
    public interface IRepository<TModel> where TModel : Entity
    {
        Task<IEnumerable<TModel>> GetAllAsync();
        Task<TModel> GetAsync(Guid id);
        Task<Guid> AddAsync(TModel entity, CancellationToken cancellationToken = default);
        void Add(TModel entity);
        void Update(TModel entity);
        void Delete(TModel entity);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
