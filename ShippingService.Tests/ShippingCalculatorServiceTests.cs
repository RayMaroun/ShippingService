using Moq;
using ShippingService.models;
using ShippingService.services;
using ShippingService.utils.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ShippingService.Tests
{
    public class ShippingCalculatorServiceTests
    {
        [Theory]
        [ClassData(typeof(MyTestData))]
        public void CalculateShippingCost_ReturnsExpectedCost(Order order)
        {
            // Arrange
            var mockShippingCalculator = new Mock<IShippingCalculator>();
            mockShippingCalculator.Setup(x => x.CalculateShippingCost(It.IsAny<Order>())).Returns(20.0);

            var shippingService = new ShippingCalculatorService(mockShippingCalculator.Object);
            //var order = new Order { Total = 100, Destination = "Asia" };

            // Act
            var result = shippingService.CalculateShippingCost(order);

            // Assert
            Assert.Equal(20.0, result);
        }
    }
}
