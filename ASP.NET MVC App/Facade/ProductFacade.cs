using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP.NET_MVC_App.IRepositories;
using ASP.NET_MVC_App.Models;
using ASP.NET_MVC_App.ViewModels;

namespace ASP.NET_MVC_App.Facade
{
    public class ProductFacade
    {
        private readonly IProductRepository _productRepository;

        public ProductFacade(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        public IList<ProductVM> GetProducts()
        {
            var result = _productRepository.GetAllProducts().Select(p =>
                new ProductVM
                {
                    Id = p.Id,
                    Name =p.Name,
                    Price = p.Price,
                    Category = p.Category.Name,
                    OrdersCount = p.Order.Count()
                }).ToList();

            return result;
        }


        public Product ProductDetails(int id)
        {
            return _productRepository.GetProductById(id);
        }
    }
}