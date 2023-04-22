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
        [HttpGet]
        [Route("BestOrder")]
        public IActionResult BestOrder()
        {
            return Ok(_ProductBus.BestOrder());
        }
        [HttpGet]
        [Route("ProductByCategory/{id}")]
        public IActionResult GetProductByCategory(int id)
        {
            return Ok(_ProductBus.GetSanPhamByCateId(id));
        }
        [HttpGet]
        [Route("GetProductPaging_PageSize/{Size}_PageNumber/{Number}")]
        public IActionResult GetProductPaging (int Size , int Number)
        { 
            return Ok(_ProductBus.GetSanPhamPaging(Size, Number));  
                
          }
        // San pham ngay tao moi nhat
        [HttpGet]
        [Route("ProductTimeNew")]
        public IActionResult GetProductTimeNew()
        {
            return Ok(_ProductBus.ProductTimeNew());
        }
        [HttpGet]
        [Route("SearchProductByCatePriceRange_CategoryId/{id}_Min/{min}_Max/{max}")]
        public IActionResult SearchProductByCatePriceRange(int id , int min , int max)
        {
            return Ok(_ProductBus.SearchProductByCatePriceRange(id, min, max));
        }
        [HttpGet]
        [Route("SearchSanPham/{ProductName}")]
        public IActionResult SearchSanPham(string ProductName)
        {
            return Ok(_ProductBus.SearchSanPham(ProductName));
        }
        [HttpGet]
        [Route("SortPriceSanPhamAsc/{id}")]
        public IActionResult SortPriceSanPhamAsc(int id)
        {
            return Ok(_ProductBus.SortPriceSanPhamAsc(id));

        }
        [HttpGet]
        [Route("SortPriceSanPhamDesc/{id}")]
        public IActionResult SortPriceSanPhamDesc(int id)
        {
            return Ok(_ProductBus.SortPriceSanPhamDesc(id));

        }
        [HttpGet]
        [Route("ViewCount")]
        public IActionResult ViewCount()
        {
            return Ok(_ProductBus.ViewCount());
        }    
    }
}
