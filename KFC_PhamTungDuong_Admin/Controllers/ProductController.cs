using BUS.IBus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MODEL;
using System.Diagnostics.CodeAnalysis;
using System.Security.AccessControl;

namespace KFC_PhamTungDuong_Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ISanPhamAdminBus _sanPhamAdminBus;
        public ProductController (ISanPhamAdminBus sanPhamAdminBus)
        {
            _sanPhamAdminBus = sanPhamAdminBus;
        }
        [HttpPost]
        [Route("CreateProduct")]
        public IActionResult CreateProduct(SanPhamModel model)
        {
            return Ok(_sanPhamAdminBus.CreateProduct(model));
        }
        [HttpPost]
        [Route("UpdateProduct")]
        public IActionResult UpdateProduct(SanPhamModel model)
        {
            return Ok(_sanPhamAdminBus.UpdateProduct(model));
        }
        [HttpDelete]
        [Route("DeleteProduct/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            return Ok(_sanPhamAdminBus.DeleteProduct(id));
        }
        [HttpGet]
        [Route("SearchProduct/{ProductName}")]
        public IActionResult SearchProduct(string ProductName)
        {
            return Ok(_sanPhamAdminBus.SearchProduct(ProductName));
        }
        [HttpGet]
        [Route("GetAllProduct")]
        public IActionResult GetAllProduct()
        {
            return Ok(_sanPhamAdminBus.GetAllSanPham());
        }

    }
}
