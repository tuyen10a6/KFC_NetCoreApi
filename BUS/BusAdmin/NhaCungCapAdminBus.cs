using BUS.IBus;
using DAL.Iterface;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhaCungCapAdminBus : INhaCungCapBus
    {
        private INhaCungCapAdminRepository _danhMucRepository;
        public NhaCungCapAdminBus(INhaCungCapAdminRepository danhMucRepository)
        {
            _danhMucRepository = danhMucRepository;
        }
        public List<NhaCungCapModel> GetAllNhaCungCap()
        {
           return _danhMucRepository.GetAllNhaCungCap();
        }
    }
}
