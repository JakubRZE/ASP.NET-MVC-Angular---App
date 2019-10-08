using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages;
using ASP.NET_MVC_App.IRepositories;
using ASP.NET_MVC_App.ViewModels;
using System.Linq.Dynamic;

namespace ASP.NET_MVC_App.Facade.Service
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductService(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }


        public IList<ProductVM> GetProducts(Filter filter)
        {
            var result = _productRepository.GetAllProducts(filter).Select(p =>
                new ProductVM
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Category = p.Category.Name,
                    OrdersCount = p.Order.Sum(o => o.Amount)
        }).OrderBy(filter.SortParam + " " + filter.SortOrder).ToList(); ;

            return result;
        }

        public IList<Dictionary> GetCategories()
        {
            var result = _categoryRepository.GetCategoryNames().Select(c =>
                new Dictionary
                {
                    Id = c.Id,
                    Name = c.Name
                }).ToList();
                
            return result;
        }
    }
}