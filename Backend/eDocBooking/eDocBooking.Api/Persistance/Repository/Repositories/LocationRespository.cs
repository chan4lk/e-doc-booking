using System;
using eDocBooking.Api.Persistance.Models;

namespace eDocBooking.Api.Persistance.Repository.Repositories
{
    public class LocationRespository : Repository<Location>
    {
        public LocationRespository(IApplicationDbContext context): base(context)
        {
        }
    }
}
