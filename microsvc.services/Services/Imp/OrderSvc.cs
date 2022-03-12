using Fop;
using microsvc.services.DbRepos.Order;
using microsvc.services.Services.Interfaces;
using System.Collections.Generic;

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
