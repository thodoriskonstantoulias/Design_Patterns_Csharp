using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator_Design_Pattern.Structural
{
    public class ConcreteMediator : Mediator
    {
        //public Colleague1 Colleague1 { get; set; }
        //public Colleague2 Colleague2 { get; set; }

        private List<Colleague> colleagues = new List<Colleague>();

        public void Register(Colleague colleague)
        {
            colleague.SetMediator(this);
            colleagues.Add(colleague);
        }
        public override void Send(string message, Colleague colleague)
        {
            //if(colleague == this.Colleague1)
            //{
            //    this.Colleague2.HandleNotification(message);
            //}
            //else
            //{
            //    this.Colleague1.HandleNotification(message);
            //}

            //Send everyone notifications except for the creator
            colleagues.Where(c => c != colleague).ToList().ForEach(c => c.HandleNotification(message));
        }
    }
}
