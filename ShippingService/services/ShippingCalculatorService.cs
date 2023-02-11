using ShippingService.models;
using ShippingService.utils.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingService.services
{
    public class ShippingCalculatorService
    {
        private readonly IShippingCalculator _shippingCalculator;

        public ShippingCalculatorService(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }

        public double CalculateShippingCost(Order order)
        {
            return _shippingCalculator.CalculateShippingCost(order);
        }
    }
}
