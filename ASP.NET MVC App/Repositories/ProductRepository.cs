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


        //public IEnumerable<ProductVM> GetAllProducts()
        //{
        //   var product = (from prod in _mockContext.Products
        //                     join category in _mockContext.Categories on prod.CategoryId equals category.Id
        //              select new ProductVM
        //        {
        //            Name = prod.Name,
        //            Category = prod.CategoryId,
        //            ///...
        //            OrdersCount = _mockContext.Orders.Count(x => x.ProductId == product.Id)

        //        }).ToList();

        //   return product;
        //}




        //(from product in _mockContext.Products
        // select new ProductVM
        // {
        //     Name = product.Name,

        // }).ToList();





    }
}