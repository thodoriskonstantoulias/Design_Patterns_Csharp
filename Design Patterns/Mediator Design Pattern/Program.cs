using Mediator_Design_Pattern.Structural;
using System;

namespace Mediator_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();

            var c1 = new Colleague1();
            var c2 = new Colleague2();
            //mediator.Colleague1 = c1;
            //mediator.Colleague2 = c2;

            mediator.Register(c1);
            mediator.Register(c2);

            c1.Send("Hello from c1");
            c2.Send("Hola from c2");
            //mediator.Send("Hola", c2);
        }
    }
}
