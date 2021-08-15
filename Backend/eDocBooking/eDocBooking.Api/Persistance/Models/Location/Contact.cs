using System;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace eDocBooking.Api.Persistance.Models
{
    [Owned]
    public class Contact : Entity
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("locationId")]
        public Guid LocationId { get; set; }
    }


}
