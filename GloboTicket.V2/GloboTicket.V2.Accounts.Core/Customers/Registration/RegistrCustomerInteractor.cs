using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GloboTicket.V2.Accounts.Core.Customers.Registration
{
    ////
    /// Bussines process and  Rules for Regsitration the customer
    ///
    public class RegistrCustomerInteractor
    {
        private readonly IRegistrCustomerPersistence _registrCustomerPersistence;
        private readonly IRegistrCustomerPublisher _registrCustomerPublisher;

        public RegistrCustomerInteractor(
            IRegistrCustomerPersistence registrCustomerPersistence,
            IRegistrCustomerPublisher registrCustomerPublisher)
        {
            _registrCustomerPersistence = registrCustomerPersistence;
            _registrCustomerPublisher = registrCustomerPublisher;
        }


        void Execute(
            string firstName,
            string lastName,
            string email,
            string password
            )
        {
            //proces business rules -> pass in strong types [value objects]
            // process buseiness rules command
            _registrCustomerPersistence.Execute(firstName: firstName, lastName: lastName,email: email);

            // publish event
            _registrCustomerPublisher.Execute();


        
        }
    }
}
