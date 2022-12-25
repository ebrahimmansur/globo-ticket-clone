using GloboTicket.V2.Events.Core.Customers.ViewEvents;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.V2.Events.Api.Customers.ViewEvents
{

    [Tags("Events")]
    [ApiController]
    [Route("api/customer")]
    public class CustomerViewEventsController : ControllerBase
    {

        private readonly CustomerViewEventsInteractor _customerViewEventsInteractor;

        public CustomerViewEventsController(CustomerViewEventsInteractor customerViewEventsInteractor)
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
