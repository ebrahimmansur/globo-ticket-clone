using GloboTicket.V2.Events.Core.Customers.ViewEvents;
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

        private readonly CustomerViewEventsInteractor _customerViewEventsInteractor;

        public CustomerViewEventController(CustomerViewEventsInteractor customerViewEventsInteractor)
        {
            _customerViewEventsInteractor = customerViewEventsInteractor;
        }

        [HttpGet("events")]
        public async Task<IActionResult> Execute()
        {
            var result = await _customerViewEventsInteractor.ExecuteAsync();
           return result.Result<IActionResult>(
                (r)=> Ok(r), (l) => BadRequest());
            
        }
    }
}
