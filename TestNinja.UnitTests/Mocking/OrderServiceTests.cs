using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    class OrderServiceTests
    {
        [Test]
        public void PlaceOrder_WhenCalled_StoreThatOrder()
        {
            var storage = new Mock<IStorage>();
            var service = new OrderService(storage.Object);

            Order order = new Order();
            service.PlaceOrder(order);

            storage.Verify(s => s.Store(order));
        }
    }
}
