using System;
namespace eDocBooking.Api.Handlers.ViewModels
{
    public class PaginatedRequest
    {
        public int Count { get; set; }

        public int Page { get; set; }
    }
}
