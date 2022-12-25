using GloboTicket.V2.Events.Core.Managments.CreateEvent;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.V2.Events.Api.Managments.CreateEvent
{

    [Tags("Events")]
    [ApiController]
    [Route("api/managment/events")]
    public class ManagmentCreateEventsController : ControllerBase
    {
        private readonly ManagmentCreateEventInteractor _managmentCreateEventInteractor;

        public ManagmentCreateEventsController(ManagmentCreateEventInteractor managmentCreateEventInteractor)
        {
            _managmentCreateEventInteractor = managmentCreateEventInteractor;
        }


        [ProducesResponseType(type:typeof(Guid),statusCode:StatusCodes.Status200OK)]
        [ProducesResponseType( statusCode: StatusCodes.Status400BadRequest)]
        [HttpPost()]
        public async Task<IActionResult> ExecuteAsync(ManagmentCreateEventRequest request)
        {

           var eventId = await  _managmentCreateEventInteractor
                .ExecuteAsync(
               title:request.Title,
               description:request.Description
               );

           return Ok(eventId);


        }
    }


    public record ManagmentCreateEventRequest(
        string Title,string Description);
}
