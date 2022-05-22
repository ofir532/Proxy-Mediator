using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy___Mediator.Mediator
{
    internal interface IMember
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string NickName { get; set; }
        void Publish(string message);
        void Receive(string message);

    }
}
