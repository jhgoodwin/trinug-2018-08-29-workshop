using System;
using System.Collections.Generic;
using FluentAssertions;
using FluentAssertions.Extensions;
using Xunit;

namespace Customer.Data.Tests
{
    public class OrderRepositoryTests
    {
        [Fact]
        public void OrderRepository_GetOrder_ReturnsOrder()
        {
            var customerNumber = 5;
            var customerOrders = ResourceHelper.ReadTestObject<IDictionary<Guid, Order>>(
                $"Customers._{customerNumber}.Orders");
            var repository = new OrderRepository(customerOrders);
            var orderId = Guid.Parse("35977c28-c99a-4597-8ec3-06bc6cac2364");
            var order = repository.LoadOrder(orderId);
            var expectedOrderDate = DateTime.Parse("2018-06-01T13:44:12.124Z").ToUniversalTime();
            var expectedOrderItemCount = 2;

            order.OrderDate.Should().Be(expectedOrderDate);
            order.Items.Count.Should().Be(expectedOrderItemCount);
        }
    }
}
