using GloboTicket.V2.Events.Core.Customers.ViewEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.V2.Events.Infrastructure.Customers.ViewEvents
{
    public class CustomerViewEvent : ICustomerViewEvents
    {
        public async Task<IReadOnlySet<CustomerViewEventVM>> Execute()
        {
            return await Task.FromResult( new HashSet<CustomerViewEventVM>()
            {
                new CustomerViewEventVM(
                    Id:Guid.NewGuid(),
                    Title:"Test Title",
                    Desc:"Test Dec",
                    EventDate: DateTimeOffset.UtcNow
                    ),
                 new CustomerViewEventVM(
                    Id:Guid.NewGuid(),
                    Title:"Test Title 2",
                    Desc:"Test Dec 2",
                    EventDate: DateTimeOffset.UtcNow.AddHours(3)
                    )
            });
        }
    }
}
