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
    public class NhaCungCapAdminRepository: INhaCungCapAdminRepository
    {
        private IDatabaseHelper _databaseHelper;
        public NhaCungCapAdminRepository(IDatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }

        public List<NhaCungCapModel> GetAllNhaCungCap()
        {
            var ProcName = "GetAllNhaCungCap";
            var Ok = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName);
            var result = Ok.ConvertTo<NhaCungCapModel>().ToList();
            return result;
        }
    }
}
