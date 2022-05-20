using System;
using Proxy___Mediator.Proxy;

namespace Proxy___Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Proxy
            IInteriorOffice interiorOffice = new InteriorOffice();
            IServiceMachine serviceMachine = new ServiceMachine();
            var p1 = Person.GeneratePerson();
            Console.WriteLine(p1);
            interiorOffice.CreatePassport(p1);
            Console.WriteLine(p1);
            serviceMachine.ChangeFirstName(p1, "Haim");
            serviceMachine.ChangeLastName(p1, "Cohen");
            serviceMachine.ChangeAdress(p1, "Yigal Alon St 60, Tel Aviv-Yafo");
            Console.WriteLine(p1);
            serviceMachine.PassportRenewal(p1);
            Console.WriteLine(p1);
            #endregion
            #region Mediator

            #endregion



        }
    }
}
