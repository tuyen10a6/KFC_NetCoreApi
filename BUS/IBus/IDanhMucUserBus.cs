using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IBus
{
    public interface IDanhMucUserBus
    {
        List<DanhMucModel> GetAllDanhMuc();
    }
}
