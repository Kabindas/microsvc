﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using microsvc.services.DbRepos.User;
using microsvc.services.Services.Imp;
using microsvc.services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace microsvc.services.Services.Imp.Tests
{
    [TestClass()]
    public class UserSvcTests
    {
        private IUserSvc testMe;

        [TestInitialize]
        public void Initialize()
        {
            userContext orderDb = new userContext();
            testMe = new UserSvc(orderDb);
        }

        [TestMethod()]
        public void ListUsersTest()
        {
            var expectedCount = 7;
            var users = testMe.ListUsers();
            Assert.AreEqual(expectedCount, users.Count());
        }
    }
}