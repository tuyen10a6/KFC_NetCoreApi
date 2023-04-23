using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IBus
{
    public interface ISanPhamAdminBus
    {
        List<SanPhamModel> GetAllSanPham();
        bool CreateProduct(SanPhamModel model);
        bool DeleteProduct(int ProductID);
        bool UpdateProduct(SanPhamModel model);
        List<SanPhamModel> SearchProduct(string ProductName);
    }
}
