using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy___Mediator.Mediator
{
    internal class Member :IMember
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }

        private readonly IFacebookGroup mediator;

        public Member(string firstName, string lastName, string nickName, IFacebookGroup mediator)
        {
            FirstName = firstName;
            LastName = lastName;
            NickName = nickName;
            this.mediator = mediator;
        }

        public void Publish(string message)
        {
            Console.WriteLine($"{NickName} sending: {message}");
            this.mediator.SendMessage(message, this);
        }

        public void Receive(string message)
        {
            Console.WriteLine($"{NickName} received: {message}");
        }

    }
}
