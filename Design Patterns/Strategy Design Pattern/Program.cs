using Strategy_Design_Pattern.Business.Strategies.SalesTax;
using Strategy_Pattern_First_Look.Business.Models;
using System;

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
                SalesTaxStrategy = new USATax()
            };
            
            order.LineItems.Add(new Item("CSHARP_SMORGASBORD", "C# Smorgasbord", 100m, ItemType.Literature), 1);
            order.LineItems.Add(new Item("CONSULTING", "Building a website", 100m, ItemType.Service), 1);

            Console.WriteLine(order.GetTax());
        }
    }
}
