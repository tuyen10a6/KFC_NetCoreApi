using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IBus
{
    public interface IDanhMucAdminBus
    {
        List<DanhMucModel> GetAllDanhMuc();
        bool CreateDanhMuc(DanhMucModel model);
        bool UpdateDanhMuc(DanhMucModel model);
        bool DeleteDanhMuc(int DanhMucID);
    }
}
