using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModernStore.Domain.Entities;

namespace ModernStore.Domain.Tests
{
    [TestClass]
    public class CustomerTests
    {
        private readonly User user = new User("atim", "atim123");

        [TestMethod]
        [TestCategory("Customer - New Customer")]
        public void GivenAnIvalidFirstNameShouldReturnANotification()
        {
            var customer = new Customer("", "Cabum", "atim@cabum.com", user);
            Assert.AreEqual(1, customer.Notifications.Count);
        }

        [TestMethod]
        [TestCategory("Customer - New Customer")]
        public void GivenAnIvalidLastNameShouldReturnANotification()
        {
            var customer = new Customer("Atim", "", "atim@cabum.com", user);
            Assert.IsFalse (customer.IsValid());
        }

        [TestMethod]
        [TestCategory("Customer - New Customer")]
        public void GivenAnIvalidEmailShouldReturnANotification()
        {
            var customer = new Customer("Atim", "Cabum", "atimcabum.com", user);
            Assert.IsFalse(customer.IsValid());
        }
    }
}
