using Fop;
using microsvc.services.Models;
using microsvc.services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace microsvc.services.Services.Imp
{
    public class UsersOrdersSvc : IUsersOrdersSvc
    {
        private readonly IUserSvc usersvc;
        private readonly IOrderSvc ordersvc;

        public UsersOrdersSvc(IUserSvc usersvc, IOrderSvc ordersvc)
        {
            this.usersvc = usersvc;
            this.ordersvc = ordersvc;
        }

        public (IEnumerable<OrderEntityExtended>, int) ListOrdersExtended(IFopRequest request)
        {
            var data = (from o in ordersvc.ListOrders()
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
