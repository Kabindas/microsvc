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

        public OrderSvc(orderContext orderdb)
        {
            this.orderdb = orderdb;
        }
        public IEnumerable<OrderEntity> ListOrders()
        {
            return orderdb.OrderEntity;
        }
    }
}
