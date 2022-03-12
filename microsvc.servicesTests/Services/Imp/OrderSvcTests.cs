using Fop.FopExpression;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using microsvc.services.DbRepos.Order;
using microsvc.services.DbRepos.User;
using microsvc.services.Models;
using microsvc.services.Services.Interfaces;
using Moq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace microsvc.services.Services.Imp.Tests
{
    [TestClass()]
    public class OrderSvcTests
    {
        private Mock<IUserSvc> userMockSvc;

        private IOrderSvc testMe;

        [TestInitialize]
        public void Initialize()
        {
            orderContext orderDb = new orderContext(); 
            userMockSvc = new Mock<IUserSvc>(MockBehavior.Strict);
            testMe = new OrderSvc(orderDb, userMockSvc.Object);
        }

        [TestMethod()]
        public void ListOrdersFilteredByNameContains()
        {
            List<UserEntity> users = new List<UserEntity> { new UserEntity { Id = 3, Name = "Carla" } };
            List<OrderEntityExtended> expected = new List<OrderEntityExtended>() { new OrderEntityExtended { Id = 3, Name = "Carla", TotalSpent = 300, UserId = 3 } };
            var fopRequest = FopExpressionBuilder<OrderEntityExtended>.Build("name~=arla", order: null, pageNumber: 0, pageSize: 0);
            userMockSvc.Setup(lib => lib.ListUsers()).Returns(users);
            var (filteredOrders, totalCount) = testMe.ListOrdersExtended(fopRequest);
            Assert.AreEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(filteredOrders));
        }

        [TestMethod()]
        public void ListOrdersFilteredByNameEqual()
        {
            List<UserEntity> users = new List<UserEntity> { new UserEntity { Id = 7, Name = "Luciana" } };
            List<OrderEntityExtended> expected = new List<OrderEntityExtended>() { new OrderEntityExtended { Id = 7, Name = "Luciana", TotalSpent = 447.3, UserId = 7 } };
            var fopRequest = FopExpressionBuilder<OrderEntityExtended>.Build("name==Luciana", order: null, pageNumber: 0, pageSize: 0);
            userMockSvc.Setup(lib => lib.ListUsers()).Returns(users);
            var (filteredOrders, totalCount) = testMe.ListOrdersExtended(fopRequest);
            Assert.AreEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(filteredOrders));
        }

        [TestMethod()]
        public void ListOrdersPaged()
        {
            userContext usersDb = new userContext();
            List<OrderEntityExtended> expected = new List<OrderEntityExtended>() {
                new OrderEntityExtended { Id = 5, Name = "Paulo", TotalSpent = 584, UserId = 6 } ,
                new OrderEntityExtended { Id = 6, Name="Jose", TotalSpent=221.5, UserId=4}
            };
            var fopRequest = FopExpressionBuilder<OrderEntityExtended>.Build(filter: null, order: null, pageNumber: 3, pageSize: 2);
            userMockSvc.Setup(lib => lib.ListUsers()).Returns(usersDb.UserEntity.ToList());
            var (filteredOrders, totalCount) = testMe.ListOrdersExtended(fopRequest);
            Assert.AreEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(filteredOrders));
        }

        [TestMethod()]
        public void ListOrdersPagedOrder()
        {
            userContext usersDb = new userContext();
            List<OrderEntityExtended> expected = new List<OrderEntityExtended>() {
                new OrderEntityExtended { Id = 5, Name = "Paulo", TotalSpent = 584, UserId = 6 } ,
                new OrderEntityExtended { Id = 1, Name="Vitor", TotalSpent=200.25, UserId=1}
            };
            var fopRequest = FopExpressionBuilder<OrderEntityExtended>.Build(filter: null, order: "Name", pageNumber: 3, pageSize: 2);
            userMockSvc.Setup(lib => lib.ListUsers()).Returns(usersDb.UserEntity.ToList());
            var (filteredOrders, totalCount) = testMe.ListOrdersExtended(fopRequest);
            Assert.AreEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(filteredOrders));
        }
    }
}