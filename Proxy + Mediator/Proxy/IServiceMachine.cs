using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy___Mediator.Proxy
{
    internal interface IServiceMachine
    {
        public void ChangeAdress(Person person, string adress)
        {
            person.Address = adress;
        }
        public void ChangeFirstName(Person person, string firstName)
        {
            person.FirstName = firstName;
        } 
        public void ChangeLastName(Person person, string lastName)
        {
            person.LastName = lastName;
        }
        public void PassportRenewal(Person person)
        {
            if (person.PersonId == null)
                return;
            person.PassPort.ExpirationDate = person.PassPort.ExpirationDate.AddYears(10);
        }

    }
}
