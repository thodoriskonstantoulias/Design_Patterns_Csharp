using Strategy_Pattern_First_Look.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Design_Pattern.Business.Strategies.SalesTax
{
    public interface ISalesTaxStrategy
    {
        decimal GetTaxFor(Order order);
    }
}
