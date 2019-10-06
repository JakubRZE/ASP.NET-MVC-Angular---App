using ASP.NET_MVC_App.Mocks;
using ASP.NET_MVC_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_App.Repositories
{
    public class CategoryRepository
    {
        private List<Category> _categories;
        private MockContext MockContext { get; set; }

        public CategoryRepository()
        {
            MockContext = new MockContext();
        }
        

        public List<Category> GetCategories()
        {
            return MockContext.Categories;
        }

        public List<Product> GetProducts()
        {
            return (from product in MockContext.Products
                    join category in MockContext.Categories on product.CategoryId equals category.Id
                    select new Product
                    {
                        Name = product.Name,
                        //itd...
                        Category = category,
                    }).ToList();  
        }

        public IEnumerable<Category> GetAllPies()
        {
            return _categories;
        }

        public Category GetPieById(int categoryId)
        {
            return _categories.FirstOrDefault(p => p.Id == categoryId);
        }
    }
}