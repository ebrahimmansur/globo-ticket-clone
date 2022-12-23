using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.V2.Accounts.Core.Customers.Registration
{
    public interface IRegistrCustomerPersistence
    {

        void Execute(
             string firstName,
             string lastName,
             string email
            );

    }
}
