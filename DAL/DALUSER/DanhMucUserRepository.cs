using DAL.Helper;
using DAL.Iterface;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALUSER
{
    public class DanhMucUserRepository : IDanhMucRepository
    {
        private IDatabaseHelper _databaseHelper;
        public DanhMucUserRepository(IDatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }
        public List<DanhMucModel> GetAllDanhMuc()
        {
            var ProcName = "GetAllDanhMuc";
            var Ok = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName);
            var result = Ok.ConvertTo<DanhMucModel>().ToList();
            return result;
        }
    }
}
