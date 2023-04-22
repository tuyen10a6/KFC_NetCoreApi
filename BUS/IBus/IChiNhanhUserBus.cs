using DAL.Iterface;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IBus
{
    public interface IChiNhanhUserBus
    {
        List<ChiNhanhModel> GetAllChiNhanh();
    }
}
