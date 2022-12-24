using GloboTicket.V2.Events.Core.Managments.CreateEvent;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.V2.Events.Api.Managments.CreateEvent
{

    [ApiController]
    [Route("api/managment/events")]
    public class EventsController : ControllerBase
    {
        private readonly ManagmentCreateEventInteractor _managmentCreateEventInteractor;

        public EventsController(ManagmentCreateEventInteractor managmentCreateEventInteractor)
        {
            _managmentCreateEventInteractor = managmentCreateEventInteractor;
        }

        [HttpPost()]
        public async Task<IActionResult> ExecuteAsync()
        {

           var eventId = await  _managmentCreateEventInteractor.ExecuteAsync();
           return Ok(eventId);


        }
    }
}
