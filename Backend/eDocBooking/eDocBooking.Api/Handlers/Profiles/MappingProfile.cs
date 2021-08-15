using System;
using AutoMapper;
using eDocBooking.Api.Handlers.ViewModels;
using eDocBooking.Api.Persistance.Models;

namespace eDocBooking.Api.Handlers.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Location, LocationVM>();

            CreateMap<Address, AddressVM>();

            CreateMap<Contact, ContactVM>();
        }
    }
}
