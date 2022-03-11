using microsvc.services.DbRepos.Order;
using microsvc.services.DbRepos.User;
using microsvc.services.Models;
using microsvc.services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace microsvc.services.Services.Imp
{
    public class OrderSvc : IOrderSvc
    {
        private readonly OrderContext orderdb;
        private readonly IUserSvc usersvc;

        public OrderSvc(OrderContext orderdb, IUserSvc usersvc)
        {
            this.orderdb = orderdb;
            this.usersvc = usersvc;
        }
        public IEnumerable<OrderEntity> ListOrders()
        {
            return orderdb.OrderEntity;
        }

        public IEnumerable<OrderEntityExtended> ListOrdersExtended()
        {
            var data = from o in ListOrders() join u in usersvc.ListUsers() on o.UserId equals u.Id
                       select new OrderEntityExtended
                       {
                           Id = o.Id,
                           UserId = o.UserId,
                           Name = u.Name,
                           TotalSpent = o.TotalSpent
                       };
            //var data = from o in orderdb.OrderEntity
            //           join u in userdb.UserEntity on o.UserId equals u.Id
            //           select new OrderEntityExtended
            //           {
            //               Id = o.Id,
            //               UserId = o.UserId,
            //               Name = u.Name,
            //               TotalSpent = o.TotalSpent
            //           };
            return data;
        }
    }
}
