using BUS.IBus;
using DAL.Iterface;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusUser
{
    public class SlideBus: ISlideUserBus
    {
        private ISlideRepository _productRepository;
        public SlideBus(ISlideRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<SlideModel> GetAllSlide()
        {
            return _productRepository.GetAllSlide();
        }
    }
}
