using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Design_Pattern.Structural
{
    public class Colleague1 : Colleague
    {
        public Colleague1(Mediator mediator) : base(mediator)
        {
        }

        public override void HandleNotification(string message)
        {
            Console.WriteLine("Colleague 1 receives notification " + message);
        }
    }
}
