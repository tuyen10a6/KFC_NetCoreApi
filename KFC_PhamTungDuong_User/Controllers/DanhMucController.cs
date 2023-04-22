using BUS.IBus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KFC_PhamTungDuong_User.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DanhMucController : ControllerBase
    {
        private IDanhMucUserBus _ProductBus;
        public DanhMucController(IDanhMucUserBus productBus)
        {
            _ProductBus = productBus;
        }
        [HttpGet]
        [Route("GetAllDanhMuc")]
        public IActionResult GetAllDanhMuc()
        {
            return Ok(_ProductBus.GetAllDanhMuc());
        }
    }
}
