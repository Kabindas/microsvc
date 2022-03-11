using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using microsvc.services.Models;
using microsvc.services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace microsvc.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IOrderSvc orderSvc;

        public OrderController(ILogger<OrderController> logger, IOrderSvc orderSvc)
        {
            _logger = logger;
            this.orderSvc = orderSvc;
        }

        [HttpGet]
        [Route("ListOrders")]
        public IEnumerable<OrderEntityExtended> ListOrders()
        {
            return this.orderSvc.ListOrdersExtended();            
        }
    }
}
