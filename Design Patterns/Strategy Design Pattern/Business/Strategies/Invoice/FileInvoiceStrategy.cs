using System;
using System.Collections.Generic;
using System.Text;
using Strategy_Pattern_First_Look.Business.Models;

namespace Strategy_Design_Pattern.Business.Strategies.Invoice
{
    public class FileInvoiceStrategy : InvoiceStrategy
    {
        public override void Generate(Order order)
        {
            Console.WriteLine("File order");
        }
    }
}
