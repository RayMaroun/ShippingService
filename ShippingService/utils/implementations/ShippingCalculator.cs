using ShippingService.models;
using ShippingService.utils.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingService.utils.implementations
{
    public class ShippingCalculator : IShippingCalculator
    {
        public double CalculateShippingCost(Order order)
        {
            double shippingCost = 0;
            if (order.Destination == "USA")
            {
                shippingCost = order.Total * 0.1;
            }
            else if (order.Destination == "Europe")
            {
                shippingCost = order.Total * 0.15;
            }
            else if (order.Destination == "Asia")
            {
                shippingCost = order.Total * 0.2;
            }
            else
            {
                shippingCost = order.Total * 0.25;
            }

            return shippingCost;
        }
    }
}
