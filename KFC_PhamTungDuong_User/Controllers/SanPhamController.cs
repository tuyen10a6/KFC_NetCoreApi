using BUS.IBus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KFC_PhamTungDuong_User.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamController : ControllerBase
    {
        private ISanPhamUserBus _ProductBus;
        public SanPhamController(ISanPhamUserBus productBus)
        {
            _ProductBus = productBus;
        }
        [HttpGet]
        [Route("GetAllSanPham")]
        public IActionResult GetAllSanPham()
        {
            return Ok(_ProductBus.GetAllSanPham());
        }
    }
}
