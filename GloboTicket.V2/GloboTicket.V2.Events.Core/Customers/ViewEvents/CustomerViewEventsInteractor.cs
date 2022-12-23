using GloboTicket.V2.CrossCuttingConcerns.Core.Results;
using OneOf;
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

       public EitherResult<IReadOnlySet<CustomerViewEventVM>,CustomerViewEventsFailure> Execute(
           CancellationToken? cancellationToken = null
           )
        {
            //process businss rules 
            //publish events
            var customerViewEvents = _customerViewEvents.Execute();
            return new EitherResult<IReadOnlySet<CustomerViewEventVM>, CustomerViewEventsFailure>( customerViewEvents);

        }
    }
}
