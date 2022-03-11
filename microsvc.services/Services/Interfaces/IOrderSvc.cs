using microsvc.services.DbRepos.Order;
using microsvc.services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace microsvc.services.Services.Interfaces
{
    public interface IOrderSvc
    {
        IEnumerable<OrderEntity> ListOrders();
        IEnumerable<OrderEntityExtended> ListOrdersExtended();
    }
}
