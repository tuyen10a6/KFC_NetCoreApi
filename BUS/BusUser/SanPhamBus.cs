using BUS.IBus;
using DAL.DALUSER;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusUser
{
    public class SanPhamBus : ISanPhamUserBus
    {
        private ISanPhamRepository _productRepository;
        public SanPhamBus(ISanPhamRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<SanPhamModel> BestOrder()
        {
            return _productRepository.BestOrder();
        }

        public List<SanPhamModel> GetAllSanPham()
        {
            return _productRepository.GetAllSanPham();  
        }

        public List<SanPhamModel> GetSanPhamByCateId(int id)
        {
            return _productRepository.GetSanPhamByCateId(id);
        }

        public List<SanPhamModel> GetSanPhamPaging(int PageSize, int PageNumber)
        {
            return _productRepository.GetSanPhamPaging(PageSize, PageNumber);
        }

        public List<SanPhamModel> ProductTimeNew()
        {
            return _productRepository.ProductTimeNew();
        }

        public List<SanPhamModel> SearchProductByCatePriceRange(int CategoryID, int MinPrice, int MaxPrice)
        {
            return _productRepository.SearchProductByCatePriceRange(CategoryID, MinPrice, MaxPrice);
        }

        public List<SanPhamModel> SearchSanPham(string ProductName)
        {
            return _productRepository.SearchSanPham(ProductName);
        }

        public List<SanPhamModel> SortPriceSanPhamAsc(int categoryID)
        {
            return _productRepository.SortPriceSanPhamAsc(categoryID);
        }

        public List<SanPhamModel> SortPriceSanPhamDesc(int categoryID)
        {
            return _productRepository.SortPriceSanPhamDesc(categoryID);
        }

        public List<SanPhamModel> ViewCount()
        {
            return _productRepository.ViewCount();
        }
    }
}
