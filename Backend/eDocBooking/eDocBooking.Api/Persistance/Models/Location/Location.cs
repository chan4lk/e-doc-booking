using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace eDocBooking.Api.Persistance.Models
{

    public class Location : Entity
    {

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("addresses")]
        public List<Address> Addresses { get; set; }

        [JsonPropertyName("contacts")]
        public List<Contact> Contacts { get; set; }

        [JsonPropertyName("organizationId")]
        public Guid OrganizationId { get; set; }
    }


}
