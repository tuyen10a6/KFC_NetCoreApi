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
    public class DanhMucAdminRepository : IDanhMucAdmin
    {
        private IDatabaseHelper _databaseHelper;
        public DanhMucAdminRepository(IDatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }
        public bool CreateDanhMuc(DanhMucModel model)
        {
            var requestJson = model != null ? MessageConvert.SerializeObject(model) : null;
            try
            {
                string msgError = "";
                var result = _databaseHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "AddDanhMuc",
                "@requestbody", requestJson
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

        public bool DeleteDanhMuc(int DanhMucID)
        {
            try
            {
                string msgError = "";
                var result = _databaseHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "XoaDanhMuc",
                    "@MaDanhMuc", DanhMucID
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

        public List<DanhMucModel> GetAllDanhMuc()
        {
            var ProcName = "GetAllDanhMuc";
            var Ok = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName);
            var result = Ok.ConvertTo<DanhMucModel>().ToList();

            return result;
        }

        public bool UpdateDanhMuc(DanhMucModel model)
        {
            var requestJson = model != null ? MessageConvert.SerializeObject(model) : null;
            try
            {
                string msgError = "";
                var result = _databaseHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "UpdateDanhMuc",
                "@requestbody", requestJson
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
