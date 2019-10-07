using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP.NET_MVC_App.IRepositories;
using ASP.NET_MVC_App.ViewModels;

namespace ASP.NET_MVC_App.Facade.Service
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        public IList<ProductVM> GetProducts()
        {
            var result = _productRepository.GetAllProducts().Select(p =>
                new ProductVM
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Category = p.Category.Name,
                    OrdersCount = p.Order.Sum(o => o.Amount)
        }).ToList();

            return result;
        }
    }
}