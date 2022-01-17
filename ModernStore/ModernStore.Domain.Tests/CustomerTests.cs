using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModernStore.Domain.Entities;
using ModernStore.Domain.ValueObjects;

namespace ModernStore.Domain.Tests
{
    [TestClass]
    public class CustomerTests
    {
        private readonly Document document = new Document("33641846820");
        private readonly User user = new User("atim", "atim123");

        [TestMethod]
        [TestCategory("Customer - New Customer")]
        public void GivenAnIvalidFirstNameShouldReturnANotification()
        {
            var email = new Email("atim@cabum.com");
            var name = new Name("", "Cabum");
            var customer = new Customer(name, email, document, user);
            Assert.AreEqual(1, customer.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("Customer - New Customer")]
        public void GivenAnIvalidLastNameShouldReturnANotification()
        {
            var email = new Email("atim@cabum.com");
            var name = new Name("Atim", "");
            var customer = new Customer(name, email, document, user);
            Assert.IsFalse (customer.IsValid());
        }

        [TestMethod]
        [TestCategory("Customer - New Customer")]
        public void GivenAnIvalidEmailShouldReturnANotification()
        {
            var email = new Email("atimcabum.com");
            var name = new Name("Atim", "Cabum");
            var customer = new Customer(name, email, document, user);
            Assert.IsFalse(customer.IsValid());
        }
    }
}
