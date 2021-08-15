using System;
using System.Collections.Generic;

namespace eDocBooking.Api.Handlers.ViewModels
{

    public class LocationVM
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public List<AddressVM> Addresses { get; set; }
        public List<ContactVM> Contacts { get; set; }
        public string OrganizationId { get; set; }
    }

}
