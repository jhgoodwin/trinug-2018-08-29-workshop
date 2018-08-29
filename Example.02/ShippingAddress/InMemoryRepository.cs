using System.Collections.Generic;

namespace ShippingAddress
{
    public class InMemoryRepository
    {
        private readonly IAddressVerifier _addressVerifier;

        public List<Address> ShippingAddresses { get; private set; }

        public InMemoryRepository(IAddressVerifier addressVerifier)
        {
            _addressVerifier = addressVerifier;

            ShippingAddresses = new List<Address>();
        }

        public void AddAddress(Address address)
        {
            address.Existed = _addressVerifier.Verify(address);

            ShippingAddresses.Add(address);
        }
    }
}
