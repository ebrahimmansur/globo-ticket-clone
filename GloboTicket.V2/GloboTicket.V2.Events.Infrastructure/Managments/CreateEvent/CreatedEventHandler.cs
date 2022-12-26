using GloboTicket.V2.CrossCuttingConcerns.Messages.MessagesHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.V2.Events.Core.Managments.CreateEvent
{
    public class CreatedEventHandler : IMessageHandler<EventCreated>
    {
        public Task HandleAsync(EventCreated message)
        {
            Console.WriteLine($"Message recived -> {message.Id}, {message.Title}");
            return Task.CompletedTask;
        }
    }
}
