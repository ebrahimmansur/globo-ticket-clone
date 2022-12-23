using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.V2.Events.Core.Customers.ViewEvents
{


    /// <summary>
    /// Handles The Business logic for this core use case.
    /// </summary>
    public class CustomerViewEventsInteractor
    {
        private readonly ICustomerViewEvents _customerViewEvents;

        public CustomerViewEventsInteractor(ICustomerViewEvents customerViewEvents)
        {
            _customerViewEvents = customerViewEvents;
        }

       public IReadOnlySet<CustomerViewEventVM> Execute(
           CancellationToken? cancellationToken = null
           )
        {
            var customerViewEvents = _customerViewEvents.Execute();
            return customerViewEvents;

        }
    }
}
