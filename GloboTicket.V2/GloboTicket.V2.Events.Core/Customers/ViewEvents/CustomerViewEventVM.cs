using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.V2.Events.Core.Customers.ViewEvents
{
    public record CustomerViewEventVM(
        Guid Id,
        string Title,
        string Desc,
        DateTimeOffset EventDate
        );
}
