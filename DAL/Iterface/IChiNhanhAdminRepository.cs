using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Iterface
{
    public interface IChiNhanhAdminRepository
    {
        List<ChiNhanhModel> GetAllChiNhanh();
        bool CreateChiNhanh (ChiNhanhModel model);
        bool UpdateChiNhanh(ChiNhanhModel model);
        bool DeleteChiNhanh (int ChiNhanhID);
    }
}
