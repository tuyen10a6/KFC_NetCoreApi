using BUS.IBus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KFC_PhamTungDuong_User.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChiNhanhController : ControllerBase
    {
        private IChiNhanhUserBus _ProductBus;
        public ChiNhanhController(IChiNhanhUserBus productBus)
        {
            _ProductBus = productBus;
        }
        [HttpGet]
        [Route("GetAllChiNhanh")]
        public IActionResult GetAllChiNhanh()
        {
            return Ok(_ProductBus.GetAllChiNhanh());
        }
    }
}
