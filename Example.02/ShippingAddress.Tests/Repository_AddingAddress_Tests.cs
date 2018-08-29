using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Xunit;

namespace ShippingAddress.Tests
{
    public class Repository_AddingAddress_Tests
    {
        private readonly Address _address = new Address();

        [Fact]
        public void AddingAddress_AddressValid()
        {
            var alwaysExistingVerifier = new Moq.Mock<IAddressVerifier>();
            alwaysExistingVerifier.Setup(x => x.Verify(_address)).Returns(() => { return true; });

            var repo = new InMemoryRepository(alwaysExistingVerifier.Object);
            repo.AddAddress(_address);

            Assert.Single(repo.ShippingAddresses);
            Assert.True(repo.ShippingAddresses.First().Existed);
        }

        [Fact]
        public void AddingAddress_AddressNotValid()
        {
            var alwaysNotExistingVerifier = new Moq.Mock<IAddressVerifier>();
            alwaysNotExistingVerifier.Setup(x => x.Verify(_address)).Returns(() => { return false; });

            var repo = new InMemoryRepository(alwaysNotExistingVerifier.Object);
            repo.AddAddress(_address);

            Assert.Single(repo.ShippingAddresses);
            Assert.False(repo.ShippingAddresses.First().Existed);
        }

        [Fact]
        public void AddingAddress_ServiceException()
        {
            var alwaysExceptionVerifier = new Moq.Mock<IAddressVerifier>();
            alwaysExceptionVerifier.Setup(x => x.Verify(_address)).Returns(() => { throw new WebException("500 Internal Server Error"); });

            var repo = new InMemoryRepository(alwaysExceptionVerifier.Object);
            repo.AddAddress(_address);

            Assert.Single(repo.ShippingAddresses);
        }
    }
}
