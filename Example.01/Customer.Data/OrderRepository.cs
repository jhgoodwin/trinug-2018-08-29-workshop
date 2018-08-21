using System;
using System.Collections.Generic;

namespace Customer.Data
{
    public class OrderRepository
    {
        private readonly IDictionary<Guid, Order> _source;
        public OrderRepository(IDictionary<Guid, Order> source)
        {
            _source = source;
        }

        public Order LoadOrder(Guid orderId)
        {
            return _source[orderId];
        }
    }
}