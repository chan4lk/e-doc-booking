using System;
using System.Collections.Generic;

namespace eDocBooking.Api.Handlers.ViewModels
{
    public class PaginatedResponse<T>
    {
        public List<T> Data { get; set; }
        public int Total { get; set; }
        public int Page { get; set; }
        public int Count { get; set; }
    }
}
