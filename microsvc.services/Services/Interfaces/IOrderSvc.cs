using microsvc.services.DbRepos.Order;
using System.Collections.Generic;

namespace microsvc.services.Services.Interfaces
{
    public interface IOrderSvc
    {
        IEnumerable<OrderEntity> ListOrders();
    }
}
