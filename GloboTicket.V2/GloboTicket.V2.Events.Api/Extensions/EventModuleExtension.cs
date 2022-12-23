using GloboTicket.V2.Events.Api.Customers.ViewEvents;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.V2.Events.Api.Extensions
{
    public static class EventModuleExtension
    {
        public static WebApplicationBuilder AddEventMoudle(this WebApplicationBuilder builder)
        {

            ConfigControllers(builder);
            ConfigureSettingFiles(builder);
            return builder;
        }


        private static void ConfigControllers(WebApplicationBuilder builder)
        {
            builder.Services.AddControllers()
              .AddApplicationPart(typeof(CustomerViewEventController).Assembly);
        }


        private static void ConfigureSettingFiles(WebApplicationBuilder builder)
        {
            var assemblePath = typeof(EventModuleExtension).Assembly.Location;
            var directory = Path.GetDirectoryName(assemblePath);
            var fileProvider = new PhysicalFileProvider(directory);
            builder.Services.AddSingleton<IFileProvider>(fileProvider);
            builder.Configuration.AddJsonFile(fileProvider, "eventsettings.json", false, true);
        }

    }
}
