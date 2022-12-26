using GloboTicket.V2.CrossCuttingConcerns.Messages.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.V2.CrossCuttingConcerns.Messages.MessagesHandlers
{
    public interface IMessageHandler< in TMessageType> where TMessageType : class, IMessage
    {
        Task HandleAsync( TMessageType @message );
    }
}
