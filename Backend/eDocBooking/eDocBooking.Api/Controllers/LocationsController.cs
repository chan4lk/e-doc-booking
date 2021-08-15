using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eDocBooking.Api.Handlers.Queries.Locations;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eDocBooking.Api.Controllers
{
    [Route("api/[controller]")]
    public class LocationsController : BaseController
    {
        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<LocationsResponse>> GetAsync()
        {
            return await Mediator.Send(new GetLocationsQuery());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

    }
}
