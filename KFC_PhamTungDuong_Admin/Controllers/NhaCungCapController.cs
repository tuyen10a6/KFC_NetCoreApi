using BUS.IBus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KFC_PhamTungDuong_Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhaCungCapController : ControllerBase
    {
        private INhaCungCapBus _nhacungcapbus;
        public NhaCungCapController (INhaCungCapBus NHACUNGCAPBUS)
        {
            _nhacungcapbus = NHACUNGCAPBUS;
        }
        [HttpGet]
        [Route("GetNhaCungCap")]
        public IActionResult GetAllNhaCungCap()
        {
            return Ok(_nhacungcapbus.GetAllNhaCungCap());
        }
    }

}
