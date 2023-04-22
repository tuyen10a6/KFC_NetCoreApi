using BUS.IBus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KFC_PhamTungDuong_User.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlideController : ControllerBase
    {
        private ISlideUserBus _ProductBus;
        public SlideController(ISlideUserBus productBus)
        {
            _ProductBus = productBus;
        }
        [Route("GetAllSlide")]
        [HttpGet]
        public IActionResult GetAllSlide()
        {
            return Ok(_ProductBus.GetAllSlide());
        }
    }
}
