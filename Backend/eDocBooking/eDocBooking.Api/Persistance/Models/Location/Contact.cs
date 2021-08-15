using System.Text.Json.Serialization;

namespace eDocBooking.Api.Persistance.Models
{
    public class Contact
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("details")]
        public string Details { get; set; }
    }


}
