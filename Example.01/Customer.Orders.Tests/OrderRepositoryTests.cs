using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Customer.Orders.Tests
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
        
        [Fact]
        public void OrderRepository_GetOrder_MissingOrder()
        {
            var customerNumber = 5;
            var customerOrders = ResourceHelper.ReadTestObject<IDictionary<Guid, Order>>(
                $"Customers._{customerNumber}.Orders");
            var repository = new OrderRepository(customerOrders);
            var orderId = Guid.Parse("b7cdfb82-f28f-4c26-9d31-05f03b4cb6be");
            var order = repository.LoadOrder(orderId);
            
            Assert.True(false, "Customer tried to load missing order on their portable sales device");
        }
        
        [Fact]
        public void OrderRepository_GetOrder_Customer()
        {
            var customerNumber = 6;
            var customerOrders = ResourceHelper.ReadTestObject<IDictionary<Guid, Order>>(
                $"Customers._{customerNumber}.Orders");
            var repository = new OrderRepository(customerOrders);
            
            Assert.True(false, "Customer tried to load missing customer on their portable sales device");
        }
    }
}
