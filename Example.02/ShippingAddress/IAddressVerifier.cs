namespace ShippingAddress
{
    public interface IAddressVerifier
    {
        bool Verify(Address address);
    }
}
