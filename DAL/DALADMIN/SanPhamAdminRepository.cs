using DAL.Helper;
using DAL.Iterface;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALADMIN
{
    public class SanPhamAdminRepository : ISanPhamAdminRepository
    {
        private IDatabaseHelper _databaseHelper;
        public SanPhamAdminRepository(IDatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }
        public bool CreateProduct(SanPhamModel model)
        {
            var requestJson = model != null ? MessageConvert.SerializeObject(model) : null;
            try
            {
                string msgError = "";
                var result = _databaseHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "AddSanPham",
                "@RequestBody", requestJson
                );
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteProduct(int ProductID)
        {
            try
            {
                string msgError = "";
                var result = _databaseHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "DeleteSanPham",
                    "@MaSanPham", ProductID
                );
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }

            catch (Exception ex)
            {
                // Handle other exceptions
                return false;
            }
        }

        public List<SanPhamModel> GetAllSanPham()
        {
            var ProcName = "GetAllSanPham";
            var OK = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName);
            var result = OK.ConvertTo<SanPhamModel>().ToList();
            return result;
        }
        public SanPhamModel GetProductByID(int ProductID)
        {
            var ProcName = "GetSanPhamById";
            var Ok = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName , "@ProductID", ProductID);
            var result = Ok.ConvertTo<SanPhamModel>().FirstOrDefault();
            return result;
        }

        public List<SanPhamModel> SearchProduct(string ProductName)
        {
            var ProcName = "SearchSanPham";
            var OK = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName, "@TenSanPham", ProductName);
            var result = OK.ConvertTo<SanPhamModel>().ToList();
            return result;
        }

        public bool UpdateProduct(SanPhamModel model)
        {
            var requestJson = model != null ? MessageConvert.SerializeObject(model) : null;
            try
            {
                string msgError = "";
                var result = _databaseHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "UpdateSanPham",
                "@RequestBody", requestJson
                );
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
