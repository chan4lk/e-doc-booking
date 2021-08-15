using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace eDocBooking.Api.Persistance.Models
{

    public class Location : Entity
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("addresses")]
        public ICollection<Address> Addresses { get; set; }

        [JsonProperty("contacts")]
        public ICollection<Contact> Contacts { get; set; }

        [JsonProperty("organizationId")]
        public Guid OrganizationId { get; set; }
    }


}
