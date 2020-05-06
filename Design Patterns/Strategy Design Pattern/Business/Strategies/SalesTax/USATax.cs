﻿using System;
using System.Collections.Generic;
using System.Text;
using Strategy_Pattern_First_Look.Business.Models;

namespace Strategy_Design_Pattern.Business.Strategies.SalesTax
{
    class USATax : ISalesTaxStrategy
    {
        public decimal GetTaxFor(Order order)
        {
            switch (order.ShippingDetails.DestinationState.ToLowerInvariant())
            {
                case "la": return order.TotalPrice * 0.095m;
                case "ny": return order.TotalPrice * 0.04m;
                case "nyc": return order.TotalPrice * 0.045m;
                default: return 0m;
            }
        }
    }
}
