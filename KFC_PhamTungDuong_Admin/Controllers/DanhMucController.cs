using BUS.IBus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MODEL;

namespace KFC_PhamTungDuong_Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DanhMucController : ControllerBase
    {
        private IDanhMucAdminBus _danhmucadminbus;
        public DanhMucController (IDanhMucAdminBus danhmucadminbus)
        {
            _danhmucadminbus = danhmucadminbus;
        }
        [HttpGet]
        [Route("GetAllDanhMuc")]
        public IActionResult GetAllDanhMuc()
        {
            return Ok(_danhmucadminbus.GetAllDanhMuc());
        }
        [HttpPost]
        [Route("CreateDanhMuc")]
        public IActionResult CreateDanhMuc(DanhMucModel model)
        {
            return Ok(_danhmucadminbus.CreateDanhMuc(model));
        }
        [HttpPost]
        [Route("UpdateDanhMuc")]
        public IActionResult UpdateDanhMuc(DanhMucModel model)
        {
            return Ok(_danhmucadminbus.UpdateDanhMuc(model));

        }
        [HttpDelete]
        [Route("DeleteDanhMuc/{id}")]
        public IActionResult DeleteDanhMuc(int id)
        {
            return Ok(_danhmucadminbus.DeleteDanhMuc(id));
        }    
    }
}
