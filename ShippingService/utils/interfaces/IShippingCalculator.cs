using ShippingService.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingService.utils.interfaces
{
    public interface IShippingCalculator
    {
        double CalculateShippingCost(Order order);
    }
}
