using GloboTicket.V2.CrossCuttingConcerns.Messages.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.V2.CrossCuttingConcerns.Messages.MessageDispatchers
{
    public interface IMessageDispatcher
    {
        Task PublishAsync<TMessage>(TMessage @event) where TMessage : class,IMessage;
    }
}
