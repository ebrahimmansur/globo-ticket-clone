using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.V2.Events.Api.Customers.ViewEvents
{

    [ApiController]
    [Route("api/events/customer")]
    public class CustomerViewEventController : ControllerBase
    {

        [HttpGet("events")]
        public IActionResult Execute() => Ok();
    }
}
