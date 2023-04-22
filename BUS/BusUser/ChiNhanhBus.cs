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
    public class ChiNhanhBus : IChiNhanhUserBus
    {
        private IChiNhanhRepository _productRepository;
        public ChiNhanhBus(IChiNhanhRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public List<ChiNhanhModel> GetAllChiNhanh()
        {
            return _productRepository.GetAllChiNhanh();
        }
    }
}
