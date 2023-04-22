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
    public class ChiNhanhUserRepository : IChiNhanhRepository
    {
        private IDatabaseHelper _databaseHelper;
        public ChiNhanhUserRepository(IDatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }

        public List<ChiNhanhModel> GetAllChiNhanh()
        {
            var ProcName = "GetAllChiNhanh";
            var OK = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName);
            var result = OK.ConvertTo<ChiNhanhModel>().ToList();
            return result;
        }
    }
}
