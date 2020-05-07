using Strategy_Design_Pattern.Business.Strategies.Invoice;
using Strategy_Design_Pattern.Business.Strategies.SalesTax;
using Strategy_Pattern_First_Look.Business.Models;
using System;

//Strategy pattern : Create an interface for common behavior. Create classes that implement this interface. 
//Create a context class that uses that interface. In main we decide which concrete class to use and call the behavior through the interface.
namespace Strategy_Pattern_First_Look
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order
            {
                ShippingDetails = new ShippingDetails
                {
                    //OriginCountry = "la",
                    //DestinationCountry = "la"
                    DestinationState = "la"
                },
                //SalesTaxStrategy = new SwedenTax()
                SalesTaxStrategy = new USATax(),
                InvoiceStrategy = new FileInvoiceStrategy()
            };
            
            order.LineItems.Add(new Item("CSHARP_SMORGASBORD", "C# Smorgasbord", 100m, ItemType.Literature), 1);
            order.LineItems.Add(new Item("CONSULTING", "Building a website", 100m, ItemType.Service), 1);

            Console.WriteLine(order.GetTax());

            //Second strategy example
            order.GetInvoice();
        }
    }
}
