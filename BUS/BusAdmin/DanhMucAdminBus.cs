using BUS.IBus;
using DAL.Iterface;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusAdmin
{
    public class DanhMucAdminBus : IDanhMucAdminBus
    {
        private IDanhMucAdmin _danhMucRepository;
        public DanhMucAdminBus(IDanhMucAdmin danhMucRepository)
        {
            _danhMucRepository = danhMucRepository;
        }

        public bool CreateDanhMuc(DanhMucModel model)
        {
            return _danhMucRepository.CreateDanhMuc(model);
        }

        public bool DeleteDanhMuc(int DanhMucID)
        {
            return _danhMucRepository.DeleteDanhMuc(DanhMucID);
        }

        public List<DanhMucModel> GetAllDanhMuc()
        {
            return _danhMucRepository.GetAllDanhMuc();
        }

        public bool UpdateDanhMuc(DanhMucModel model)
        {
            return _danhMucRepository.UpdateDanhMuc(model);
        }
    }
}
