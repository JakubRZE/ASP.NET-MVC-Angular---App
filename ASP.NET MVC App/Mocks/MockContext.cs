using ASP.NET_MVC_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_App.Mocks
{
    public class MockContext
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }


        public MockContext()
        {
            Categories = new List<Category> {
                new Category { Id = 1, Name = "Fruits"},
                new Category { Id = 2, Name = "Vegetables"},
                new Category { Id = 3, Name = "Sweets"},
                new Category { Id = 4, Name = "Tools"},
                new Category { Id = 5, Name = "Toys"},
            };

            Products = new List<Product> {
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
    }
}