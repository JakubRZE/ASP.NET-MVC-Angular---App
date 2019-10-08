using System;
using ASP.NET_MVC_App.IRepositories;
using ASP.NET_MVC_App.Models;
using System.Collections.Generic;
using System.Linq;
using ASP.NET_MVC_App.Mocks;
using ASP.NET_MVC_App.ViewModels;

namespace ASP.NET_MVC_App.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly MockContext _mockContext;

        public ProductRepository(MockContext mockContext)
        {
            _mockContext = mockContext;
        }


        //public IList<Product> GetAllProducts(string column = null, string sortOrder = null, string searchString = null)
        //{

        //    var query = (from product in _mockContext.Products
        //                 join category in _mockContext.Categories on product.CategoryId equals category.Id
        //                 select new Product
        //                 {
        //                     Id = product.Id,
        //                     Name = product.Name,
        //                     Price = product.Price,
        //                     Category = category,
        //                     Order = _mockContext.Orders.Where(x => x.ProductId == product.Id).ToList()
        //                 }).AsQueryable();


        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        query = query.Where(p => p.Name.ToLower().Contains(searchString.ToLower()) || 
        //                                 p.Price.ToString().Contains(searchString));
        //    }

        //    if (column != null)
        //        query = query.OrderBy(column + " " + sortOrder);



        //    return query.ToList();
        //}


        public IList<Product> GetAllProducts()
        {
            var result = (from product in _mockContext.Products
                          join category in _mockContext.Categories on product.CategoryId equals category.Id
                          select new Product
                          {
                              Id = product.Id,
                              Name = product.Name,
                              Price = product.Price,
                              Category = category,
                              Order = _mockContext.Orders.Where(x => x.ProductId == product.Id).ToList()
                          }).ToList();
            return result;
        }
    }
}