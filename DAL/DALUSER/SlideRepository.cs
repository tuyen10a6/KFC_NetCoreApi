using DAL.Helper;
using DAL.Iterface;
using MODEL;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALUSER
{
    public class SlideRepository: ISlideRepository
    {
        private IDatabaseHelper _databaseHelper;
        public SlideRepository(IDatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }

        public List<SlideModel> GetAllSlide()
        {
            var ProcName = "GetAllSlide";
            var Ok = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName);
            var result = Ok.ConvertTo<SlideModel>().ToList();
            return result;
        }
    }
}
