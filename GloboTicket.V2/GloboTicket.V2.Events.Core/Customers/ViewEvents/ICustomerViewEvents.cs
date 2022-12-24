using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.V2.Events.Core.Customers.ViewEvents
{
    public interface ICustomerViewEvents
    {
        Task< IReadOnlySet<CustomerViewEventVM>> Execute();
    }
}
