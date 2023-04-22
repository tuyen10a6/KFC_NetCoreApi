using DAL.Helper;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALUSER
{
    public class SanPhamUserRepository : ISanPhamRepository
    {
        private IDatabaseHelper _databaseHelper;
        public SanPhamUserRepository(IDatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }

        public List<SanPhamModel> BestOrder()
        {
            var ProcName = "GetBestSellingProducts";
            var Ok = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName);
            var result = Ok.ConvertTo<SanPhamModel>().ToList();
            return result;
        }

        public List<SanPhamModel> GetAllSanPham()
        {
            var ProcName = "GetAllSanPham";
            var OK = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName);
            var result = OK.ConvertTo<SanPhamModel>().ToList();
            return result;
        }

        public List<SanPhamModel> GetSanPhamByCateId(int id)
        {
            var ProcName = "GetProductsByCategory";
            var OK = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName, "@CategoryID", id);
            var result = OK.ConvertTo<SanPhamModel>().ToList();
            return result;
        }

        public List<SanPhamModel> GetSanPhamPaging(int PageSize, int PageNumber)
        {
            var ProcName = "GetProductsByCategory";
            var OK = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName, "@PageSize", PageSize, "@PageNumber", PageNumber) ;
            var result = OK.ConvertTo<SanPhamModel>().ToList();
            return result;
        }

        public List<SanPhamModel> ProductTimeNew()
        {
            var ProcName = "GetLatestProduct";
            var OK = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName);
            var result = OK.ConvertTo<SanPhamModel>().ToList();
            return result;
        }

        public List<SanPhamModel> SearchProductByCatePriceRange(int CategoryID, int MinPrice, int MaxPrice)
        {
            var ProcName = "FindSanPhamByPriceRangeByCate";
            var OK = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName, "@CategoryID", CategoryID, "@MinPrice", MinPrice, "@MaxPrice", MaxPrice) ;

            var result = OK.ConvertTo<SanPhamModel>().ToList();
            return result;
        }

        public List<SanPhamModel> SearchSanPham(string ProductName)
        {
            var ProcName = "SearchSanPham";
            var OK = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName, "@TenSanPham", ProductName);

            var result = OK.ConvertTo<SanPhamModel>().ToList();
            return result;
        }

        public List<SanPhamModel> SortPriceSanPhamAsc(int categoryID)
        {
            var ProcName = "SortSanPhamByGiaTienAscByCate";
            var OK = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName, "@CategoryID", categoryID);

            var result = OK.ConvertTo<SanPhamModel>().ToList();
            return result;
        }

        public List<SanPhamModel> SortPriceSanPhamDesc(int categoryID)
        {
            var ProcName = "SortSanPhamByGiaTienDESCByCate";
            var OK = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName, "@categoryId", categoryID);

            var result = OK.ConvertTo<SanPhamModel>().ToList();
            return result;
        }

        public List<SanPhamModel> ViewCount()
        {
            var ProcName = "GetMostViewedSanPham";
            var OK = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName);

            var result = OK.ConvertTo<SanPhamModel>().ToList();
            return result;
        }
    }
}
