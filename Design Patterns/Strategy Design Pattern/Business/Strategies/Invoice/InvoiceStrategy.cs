using System;
using System.Collections.Generic;
using System.Text;
using Strategy_Pattern_First_Look.Business.Models;

namespace Strategy_Design_Pattern.Business.Strategies.Invoice
{
    public abstract class InvoiceStrategy : IInvoiceStrategy
    {
        public abstract void Generate(Order order);

        public string ShowDesignPattern()
        {
            return "Hello Strategy";
        }
    }
}
