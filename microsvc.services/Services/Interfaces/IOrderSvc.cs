using Fop;
using microsvc.services.DbRepos.Order;
using microsvc.services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace microsvc.services.Services.Interfaces
{
    public interface IOrderSvc
    {
        IEnumerable<OrderEntity> ListOrders();
        (IEnumerable<OrderEntityExtended>, int) ListOrdersExtended(IFopRequest request);
    }
}
