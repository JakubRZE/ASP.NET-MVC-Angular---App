using ASP.NET_MVC_App.IRepositories;
using ASP.NET_MVC_App.Models;
using System.Collections.Generic;
using System.Linq;
using ASP.NET_MVC_App.Mocks;

namespace ASP.NET_MVC_App.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly MockContext _mockContext;

        public ProductRepository(MockContext mockContext)
        {
            _mockContext = mockContext;
        }


        public IEnumerable<Product> GetAllProducts()
        {
            return _mockContext.Products;
        }

        public Product GetProductById(int id)
        {
            throw new System.NotImplementedException();
        }


        //public IEnumerable<Product> GetAllPies()
        //{
        //    return _products;
        //}

        //public Product GetPieById(int productId)
        //{
        //    return _products.FirstOrDefault(p => p.Id == productId);
        //}
    }
}