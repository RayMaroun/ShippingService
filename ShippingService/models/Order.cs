using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingService.models
{
    public class Order
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public string Destination { get; set; }
    }
}
