using DAL.Helper;
using DAL.Iterface;
using MODEL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALUSER
{
    public class OrderUserRepository : IOrderRepository
    {
        private IDatabaseHelper _databaseHelper;
        public OrderUserRepository(IDatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }
        public bool CreateOrder(OrderModel Order)
        {
            if (Order == null || Order.khach == null || Order.listchitiet == null || !Order.listchitiet.Any())
            {
                return false;
            }

            try
            {
                var orderDetailsList = Order.listchitiet.Select(x => new
                {
                    ProductID = x.MaSanPham,
                    Quantity = x.QUANTITY,
                    Price = x.PRICE
                }).ToList();

                var orderDetailsJson = JsonConvert.SerializeObject(orderDetailsList);

                string msgError = "";
                var result = _databaseHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "AddOrder",
                    "@CustomerName", Order.khach.CUSTOMERNAME,
                    "@PhoneNumber", Order.khach.CUSTOMERPHONE,
                    "@CustomerAddress", Order.khach.CUSTOMERADDRESS,
                    "@CustomerEmail", Order.khach.CUSTOMEREMAIL,
                    "@OrderStatusID", Order.khach.ORDERSTATUSID,
                    "@OrderDetailsList", orderDetailsJson,
                    "@MaChiNhanh", Order.khach.MaChiNhanh
                );

                if (result != null && !string.IsNullOrEmpty(result.ToString()))
                {
                    throw new Exception(Convert.ToString(result));
                }
                else if (!string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(msgError);
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
