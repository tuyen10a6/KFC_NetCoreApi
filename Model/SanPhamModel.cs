using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class SanPhamModel
    {
        public int MaSanPham { get;set; }
        public string TenSanPham { get; set; }
        public int GiaTien { get; set; }
        public string Image { get; set; }
        public DateTime NgayTao { get; set; }


        public int MaDanhMuc { get; set; }
        public int LuotXem { get; set; }
        public string MoTa { get; set; }
        public int MaNhaCungCap { get; set; }
        public int   TotalQuantitySold { get; set; }

    }
}
