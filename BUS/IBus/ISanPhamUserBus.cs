using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IBus
{
    public interface ISanPhamUserBus
    {
        List<SanPhamModel> GetAllSanPham();
        List<SanPhamModel> GetSanPhamByCateId(int id);
        List<SanPhamModel> SearchSanPham(string ProductName);
        //cao xuống thấp
        List<SanPhamModel> SortPriceSanPhamDesc(int categoryID);
        List<SanPhamModel> SortPriceSanPhamAsc(int categoryID);
        //phân trang sản phẩm
        List<SanPhamModel> GetSanPhamPaging(int PageSize, int PageNumber);
        List<SanPhamModel> SearchProductByCatePriceRange(int CategoryID, int MinPrice, int MaxPrice);
        // Lay luot xem cao nhat
        List<SanPhamModel> ViewCount();
        // Ngay tao moi nhat
        List<SanPhamModel> ProductTimeNew();
        // Ban Chay Nhat
        List<SanPhamModel> BestOrder();

    }
}
