using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy___Mediator.Proxy
{
    internal interface IInteriorOffice
    {
        void AddPerson(Person person);
        void CreatePassport(Person person);
    }
}
