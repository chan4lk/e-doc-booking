using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using eDocBooking.Api.Handlers.ViewModels;
using eDocBooking.Api.Persistance.Models;
using eDocBooking.Api.Persistance.Repository;
using MediatR;

namespace eDocBooking.Api.Handlers.Queries.Locations
{
    public class GetLocationsQuery : IRequest<LocationsResponse>
    {       
    }

    public class GetLocationsQueryHandler : IRequestHandler<GetLocationsQuery, LocationsResponse>
    {
        private readonly IRepository<Location> locationRepository;
        private readonly IMapper mapper;

        public GetLocationsQueryHandler(IRepository<Location> locationRepository, IMapper mapper)
        {
            this.locationRepository = locationRepository;
            this.mapper = mapper;
        }
        public async Task<LocationsResponse> Handle(GetLocationsQuery request, CancellationToken cancellationToken)
        {
            var locations = await locationRepository.GetAllAsync();
            var data = locations.Select(x => mapper.Map<LocationVM>(x)).ToList();
            var result = new LocationsResponse
            {
                Data = data,
                Total = data.Count
            };

            return result;
        }
    }
}
