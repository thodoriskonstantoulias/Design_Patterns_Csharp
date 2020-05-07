using System;
using System.Collections.Generic;
using System.Text;
using Strategy_Pattern_First_Look.Business.Models;

namespace Strategy_Design_Pattern.Business.Strategies.Invoice
{
    public class EmailInvoiceStrategy : InvoiceStrategy
    {
        public override void Generate(Order order)
        {
            var body = ShowDesignPattern();
            Console.WriteLine(body);
            Console.WriteLine("Sending email...");
        }
    }
}
