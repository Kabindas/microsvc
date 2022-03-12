using Fop;
using microsvc.services.DbRepos.Order;
using microsvc.services.DbRepos.User;
using microsvc.services.Models;
using microsvc.services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microsvc.services.Services.Imp
{
    public class OrderSvc : IOrderSvc
    {
        private readonly orderContext orderdb;
        private readonly IUserSvc usersvc;

        public OrderSvc(orderContext orderdb, IUserSvc usersvc)
        {
            this.orderdb = orderdb;
            this.usersvc = usersvc;
        }
        public IEnumerable<OrderEntity> ListOrders()
        {
            return orderdb.OrderEntity;
        }

        public (IEnumerable<OrderEntityExtended>, int) ListOrdersExtended(IFopRequest request)
        {
            var data = (from o in ListOrders()
                        join u in usersvc.ListUsers() on o.UserId equals u.Id
                        select new OrderEntityExtended
                        {
                            Id = o.Id,
                            UserId = o.UserId,
                            Name = u.Name,
                            TotalSpent = o.TotalSpent
                        }).AsQueryable();

            var (filteredOrders, totalCount) = data.ApplyFop(request);
            return (filteredOrders, totalCount);
        }

    }
}
