using GloboTicket.V2.CrossCuttingConcerns.Messages.MessageDispatchers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.V2.CrossCuttingConcerns.Messages.Extensions
{
    public static class MessageExtensions
    {


        public static IServiceCollection AddMessagesScaner(this IServiceCollection services)
        {
            services.AddSingleton<IMessageDispatcher, MessageDispatcher>();
            return services;
        }

       
    }
}
