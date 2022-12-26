using GloboTicket.V2.CrossCuttingConcerns.Messages.MessageDispatchers;
using GloboTicket.V2.Events.Core.Managments.CreateEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.V2.Events.Infrastructure.Managments.CreateEvent
{
    public class ManagmentCreateEvent : IManagmentCreateEvent
    {
        private readonly IMessageDispatcher _messageDispatcher;

        public ManagmentCreateEvent(IMessageDispatcher messageDispatcher)
        {
            _messageDispatcher = messageDispatcher;
        }

        public async Task<Guid> ExecuteAsync(string titel, string description)
        {
          var id = Guid.NewGuid();
          await _messageDispatcher.PublishAsync(new EventCreated(id, description));
          return id;
        }
    }
}
