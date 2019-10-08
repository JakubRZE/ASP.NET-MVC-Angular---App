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


        public IList<Product> GetAllProducts(Filter filter)
        {
            var query = (from product in _mockContext.Products
                         join cat in _mockContext.Categories on product.CategoryId equals cat.Id
                         select new Product
                         {
                             Id = product.Id,
                             Name = product.Name,
                             Price = product.Price,
                             Category = cat,
                             Order = _mockContext.Orders.Where(x => x.ProductId == product.Id).ToList()
                         }).AsQueryable();


            if (!string.IsNullOrEmpty(filter.SearchString) )
                query = query.Where(p => p.Name.ToLower().Contains(filter.SearchString.ToLower()));

            if (filter.Category != null)
                query = query.Where(p => p.Category.Id == filter.Category);

            if(filter.DownPrice != null)
                query = query.Where(p => p.Price >= filter.DownPrice);

            if (filter.UpPrice != null)
                query = query.Where(p => p.Price <= filter.UpPrice);

            return query.ToList();
        }
    }
}