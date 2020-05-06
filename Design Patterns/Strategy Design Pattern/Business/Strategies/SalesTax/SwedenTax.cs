using System;
using System.Collections.Generic;
using System.Text;
using Strategy_Pattern_First_Look.Business.Models;

namespace Strategy_Design_Pattern.Business.Strategies.SalesTax
{
    public class SwedenTax : ISalesTaxStrategy
    {
        public decimal GetTaxFor(Order order)
        {
            var destination = order.ShippingDetails.DestinationCountry.ToLowerInvariant();

            if (destination == order.ShippingDetails.OriginCountry.ToLowerInvariant())
            {
                return order.TotalPrice * 0.25m;
            }
            return 0;
        }
    }
}
