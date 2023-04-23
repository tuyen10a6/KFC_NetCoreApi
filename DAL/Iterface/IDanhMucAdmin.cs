using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Iterface
{
    public interface IDanhMucAdmin
    {
        List<DanhMucModel> GetAllDanhMuc();
        bool CreateDanhMuc (DanhMucModel model);
        bool UpdateDanhMuc (DanhMucModel model);
        bool DeleteDanhMuc(int DanhMucID);
    }
}
