using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy___Mediator.Proxy
{
    internal class InteriorOffice : IInteriorOffice, IServiceMachine
    {
        private readonly List<Person> Citizens = new();

        public void AddPerson(Person person)
        {
            CreatePassport(person);
            Citizens.Add(person);
        }

        public void CreatePassport(Person person)
        {
            person.PassPort = new Passport();
            person.PassPort.PassportId = $"IL{person.PersonId}";
            person.PassPort.ExpirationDate = DateTime.Now.AddYears(2);
        }

    }
}
