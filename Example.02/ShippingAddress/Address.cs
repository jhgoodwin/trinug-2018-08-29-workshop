using System;

namespace ShippingAddress
{
    public class Address
    {
        public Guid AddressId { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public bool Existed { get; set; }

        public override string ToString()
        {
            return $"{AddressLine}, {City}, {State}, {Country}";
        }
    }
}
