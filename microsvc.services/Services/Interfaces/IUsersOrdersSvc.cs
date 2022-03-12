using Fop;
using microsvc.services.Models;
using System.Collections.Generic;

namespace microsvc.services.Services.Interfaces
{
    public interface IUsersOrdersSvc
    {
        (IEnumerable<OrderEntityExtended>, int) ListOrdersExtended(IFopRequest request);
    }
}