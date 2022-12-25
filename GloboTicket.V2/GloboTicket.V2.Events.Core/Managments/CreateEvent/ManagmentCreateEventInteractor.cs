using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.V2.Events.Core.Managments.CreateEvent
{
    public class ManagmentCreateEventInteractor
    {
        private readonly IManagmentCreateEvent _managmentCreateEvent;
public ManagmentCreateEventInteractor(IManagmentCreateEvent managmentCreateEvent)
        {
            _managmentCreateEvent = managmentCreateEvent;
        }

        public  Task<Guid> ExecuteAsync(string title, string description)
        {
          return  _managmentCreateEvent.ExecuteAsync(
              title:title,
              description:description
              );
        }
    }
}
