using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Iterface
{
    public interface IOrderRepository
    {
        bool CreateOrder(OrderModel Order);
    }
}
