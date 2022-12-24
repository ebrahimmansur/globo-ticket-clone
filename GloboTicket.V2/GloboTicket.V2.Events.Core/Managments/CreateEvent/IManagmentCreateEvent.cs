using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.V2.Events.Core.Managments.CreateEvent
{
    public interface IManagmentCreateEvent
    {
        Task<Guid> ExecuteAsync();
    }
}
