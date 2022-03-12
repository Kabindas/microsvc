using Fop;
using Fop.FopExpression;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using microsvc.services.Models;
using microsvc.services.Services.Interfaces;

namespace microsvc.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserOrderController : ControllerBase
    {
        private readonly ILogger<UserOrderController> _logger;
        private readonly IUsersOrdersSvc userOrdersSvc;

        public UserOrderController(ILogger<UserOrderController> logger, IUsersOrdersSvc userOrdersSvc)
        {
            _logger = logger;
            this.userOrdersSvc = userOrdersSvc;
        }

        [HttpGet]
        [Route("ListOrders")]
        public IActionResult ListOrders([FromQuery] FopQuery request)
        {
            var fopRequest = FopExpressionBuilder<OrderEntityExtended>.Build(request.Filter, request.Order, request.PageNumber, request.PageSize);
            var (filteredOrders, totalCount) = this.userOrdersSvc.ListOrdersExtended(fopRequest);
            return Ok(filteredOrders);
        }
    }
}
