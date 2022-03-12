using Microsoft.VisualStudio.TestTools.UnitTesting;
using microsvc.services.DbRepos.Order;
using microsvc.services.Services.Interfaces;
using System.Linq;

namespace microsvc.services.Services.Imp.Tests
{
    [TestClass()]
    public class OrderSvcTests
    {
        private IOrderSvc testMe;

        [TestInitialize]
        public void Initialize()
        {
            orderContext orderDb = new orderContext();
            testMe = new OrderSvc(orderDb);
        }

        [TestMethod()]
        public void ListUsersTest()
        {
            var expectedCount = 10;
            var users = testMe.ListOrders();
            Assert.AreEqual(expectedCount, users.Count());
        }
    }
}