using GloboTicket.V2.CrossCuttingConcerns.Messages.MessagesHandlers;
using GloboTicket.V2.Events.Core.Managments.CreateEvent;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.V2.Events.Infrastructure.Extensions
{
    public static class EventInfruExtensions
    {

        public static IServiceCollection AddEventInfo(this IServiceCollection services)
        {
            services.AddScoped<IMessageHandler<EventCreated>,CreatedEventHandler>();
            return services;
        }
    }
}
