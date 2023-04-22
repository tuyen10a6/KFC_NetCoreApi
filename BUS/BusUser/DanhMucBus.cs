using BUS.IBus;
using DAL.DALUSER;
using DAL.Iterface;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusUser
{
    public class DanhMucBus : IDanhMucUserBus
    {
        private IDanhMucRepository _productRepository;
        public DanhMucBus(IDanhMucRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public List<DanhMucModel> GetAllDanhMuc()
        {
            return _productRepository.GetAllDanhMuc();
        }
    }
}
