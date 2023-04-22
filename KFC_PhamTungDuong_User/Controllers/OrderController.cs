using BUS.IBus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MODEL;
using System.Diagnostics.CodeAnalysis;

namespace KFC_PhamTungDuong_User.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderUserBus _ProductBus;
        public OrderController(IOrderUserBus productBus)
        {
            _ProductBus = productBus;
        }
        [HttpPost]
        [Route("CreateOrder")]
        public IActionResult CreateOrder(OrderModel model)
        {
            return Ok(_ProductBus.CreateOrder(model));
        }
    }
}
