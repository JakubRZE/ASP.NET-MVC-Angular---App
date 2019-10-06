using ASP.NET_MVC_App.Models;
using System.Collections.Generic;
using System.Linq;

namespace ASP.NET_MVC_App.Repositories
{
    public class ProductRepository
    {
        private List<Product> _products;

        public ProductRepository()
        {
            if (_products == null)
            {
                InitializeProducts();
            }
        }

        private void InitializeProducts()
        {
            _products = new List<Product> {
                new Product { Id = 1, Name = "Apple", Price=0.50M, CategoryId = 1},
                new Product { Id = 2, Name = "Orange", Price=0.50M, CategoryId = 1},
                new Product { Id = 3, Name = "", Price=0.50M, CategoryId = 1},
                new Product { Id = 4, Name = "Apple", Price=0.50M, CategoryId = 1},
                new Product { Id = 5, Name = "Apple", Price=0.50M, CategoryId = 1},
                new Product { Id = 6, Name = "Apple", Price=0.50M, CategoryId = 1},
                new Product { Id = 7, Name = "Apple", Price=0.50M, CategoryId = 1},
                new Product { Id = 8, Name = "Apple", Price=0.50M, CategoryId = 1},
                new Product { Id = 9, Name = "Apple", Price=0.50M, CategoryId = 1},
                new Product { Id = 10, Name = "Apple", Price=0.50M, CategoryId = 1},
            };
        }

        public IEnumerable<Product> GetAllPies()
        {
            return _products;
        }

        public Product GetPieById(int productId)
        {
            return _products.FirstOrDefault(p => p.Id == productId);
        }
    }
}