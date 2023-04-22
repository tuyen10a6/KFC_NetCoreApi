
using BUS.IBus;
using DAL.Iterface;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusUser
{
    public class OrderUserBus : IOrderUserBus
    {
        private IOrderRepository _productRepository;
        public OrderUserBus(IOrderRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public bool CreateOrder(OrderModel Order)
        {
            return _productRepository.CreateOrder(Order);
        }
    }
}
