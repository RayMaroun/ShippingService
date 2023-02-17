using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingService.models
{
    public class MyTestData : IEnumerable<object[]>
    {
        private readonly Order[] _testObjects = new Order[]
        {
            new Order { Total = 100, Destination = "USA" },
            new Order { Total = 200, Destination = "Asia" },
            new Order { Total = 300, Destination = "Europe" }
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            foreach (var obj in _testObjects)
            {
                yield return new object[] { obj };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
