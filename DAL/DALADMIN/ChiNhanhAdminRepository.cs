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
    public class ChiNhanhAdminRepository: IChiNhanhAdminRepository
    {
        private IDatabaseHelper _databaseHelper;
        public ChiNhanhAdminRepository(IDatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }

        public bool CreateChiNhanh(ChiNhanhModel model)
        {
            var requestJson = model != null ? MessageConvert.SerializeObject(model) : null;
            try
            {
                string msgError = "";
                var result = _databaseHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_category_create",
                "@request", requestJson
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

        public bool DeleteChiNhanh(int ChiNhanhID)
        {
            throw new NotImplementedException();
        }

        public List<ChiNhanhModel> GetAllChiNhanh()
        {
            throw new NotImplementedException();
        }

        public bool UpdateChiNhanh(ChiNhanhModel model)
        {
            throw new NotImplementedException();
        }
    }

}
