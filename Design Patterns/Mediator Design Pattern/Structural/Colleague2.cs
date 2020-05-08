using System;

namespace Mediator_Design_Pattern.Structural
{
    public class Colleague2 : Colleague
    {
        //public Colleague2(Mediator mediator) : base(mediator)
        //{
        //}

        public override void HandleNotification(string message)
        {
            Console.WriteLine("Colleague 2 receives notification " + message);
        }
    }
}
