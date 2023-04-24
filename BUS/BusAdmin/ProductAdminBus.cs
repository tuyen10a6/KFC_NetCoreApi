using BUS.IBus;
using DAL.Iterface;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusAdmin
{
    public class ProductAdminBus : ISanPhamAdminBus
    {
        private ISanPhamAdminRepository _productRepository;
        public ProductAdminBus(ISanPhamAdminRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public bool CreateProduct(SanPhamModel model)
        {
          return _productRepository.CreateProduct(model);
        }

        public bool DeleteProduct(int ProductID)
        {
            return _productRepository.DeleteProduct(ProductID);
        }

        public List<SanPhamModel> GetAllSanPham()
        {
            return _productRepository.GetAllSanPham();
        }

        public SanPhamModel GetProductByID(int ProductID)
        {
            return _productRepository.GetProductByID(ProductID);
        }

        public List<SanPhamModel> SearchProduct(string ProductName)
        {
            return _productRepository.SearchProduct(ProductName);
        }

        public bool UpdateProduct(SanPhamModel model)
        {
            return _productRepository.UpdateProduct(model);
        }
    }
}
