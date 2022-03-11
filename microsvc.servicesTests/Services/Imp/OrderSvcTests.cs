using Microsoft.VisualStudio.TestTools.UnitTesting;
using microsvc.services.Services.Imp;
using microsvc.services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace microsvc.services.Services.Imp.Tests
{
    [TestClass()]
    public class OrderSvcTests
    {
        private IOrderSvc ordersSvc;

        public OrderSvcTests(IOrderSvc ordersSvc)
        {
            this.ordersSvc = ordersSvc;
        }


        [TestMethod()]
        public void ListOrdersTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ListOrdersExtendedTest()
        {            
            Assert.Fail();
        }
    }
}