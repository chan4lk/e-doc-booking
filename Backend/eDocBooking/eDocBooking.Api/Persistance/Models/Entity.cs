using System;
using System.Text.Json.Serialization;

namespace eDocBooking.Api.Persistance.Models
{
    public abstract class Entity
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }
    }
}
