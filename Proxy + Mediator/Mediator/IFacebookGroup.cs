using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy___Mediator.Mediator
{
    internal interface IFacebookGroup
    {
        void SendMessage(string message, IMember user);
        void RegisterMember(IMember member);

    }
}
