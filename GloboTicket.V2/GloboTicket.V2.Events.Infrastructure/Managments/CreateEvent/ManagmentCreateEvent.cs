using GloboTicket.V2.Events.Core.Managments.CreateEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.V2.Events.Infrastructure.Managments.CreateEvent
{
    public class ManagmentCreateEvent : IManagmentCreateEvent
    {
        public async Task<Guid> ExecuteAsync()
        {
           //insert the new event in the databse
           //publish event of new Event.
           return await Task.FromResult(Guid.NewGuid());
        }
    }
}
