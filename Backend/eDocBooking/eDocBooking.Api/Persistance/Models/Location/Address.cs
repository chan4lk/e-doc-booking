using System;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace eDocBooking.Api.Persistance.Models
{
    [Owned]    
    public class Address : Entity
    {
        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("locationId")]
        public Guid LocationId { get; set; }
    }

}
