using GloboTicket.V2.CrossCuttingConcerns.Messages.MessagesHandlers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.V2.CrossCuttingConcerns.Messages.MessageDispatchers
{


    public class MessageDispatcher : IMessageDispatcher
    {
        private readonly IServiceProvider _serviceProvider;

        public MessageDispatcher(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        async Task IMessageDispatcher.PublishAsync<TMessage>(TMessage @event)
        {
            using var scope = _serviceProvider.CreateScope();
            var handlers = scope.ServiceProvider.GetServices<IMessageHandler<TMessage>>();
            var tasks = handlers.Select(x => x.HandleAsync(@event));

            await Task.WhenAll(tasks);

        }
    }
}
