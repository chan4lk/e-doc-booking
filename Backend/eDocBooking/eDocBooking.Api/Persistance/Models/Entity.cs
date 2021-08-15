using System;
using Newtonsoft.Json;

namespace eDocBooking.Api.Persistance.Models
{
    public abstract class Entity
    {
        [JsonProperty("id")]
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
