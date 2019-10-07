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
        public List<Order> Orders { get; set; }
        public List<Customer> Customers { get; set; }


        public MockContext()
        {
            Categories = new List<Category> {
                new Category { Id = 1, Name = "Fruits" },
                new Category { Id = 2, Name = "Vegetables" },
                new Category { Id = 3, Name = "Sweets" },
                new Category { Id = 4, Name = "Drinks" },
                new Category { Id = 5, Name = "Dairy Foods" },
            };

            Products = new List<Product> {
                new Product { Id = 1, Name = "Apple", Price=0.50M, CategoryId = 1 },
                new Product { Id = 2, Name = "Orange", Price=0.90M, CategoryId = 1 },
                new Product { Id = 3, Name = "Pear", Price=0.80M, CategoryId = 1 },

                new Product { Id = 4, Name = "Carrot", Price=0.20M, CategoryId = 2 },
                new Product { Id = 5, Name = "Tomato", Price=0.50M, CategoryId = 2 },
                new Product { Id = 6, Name = "Spinach", Price=1M, CategoryId = 2 },

                new Product { Id = 7, Name = "Chocolate", Price=2M, CategoryId = 3 },
                new Product { Id = 8, Name = "Cookies", Price=3.50M, CategoryId = 3 },

                new Product { Id = 9, Name = "Water", Price=0.20M, CategoryId = 4 },
                new Product { Id = 10, Name = "Juice", Price=2.50M, CategoryId = 4 },

                new Product { Id = 11, Name = "Milk", Price=1.50M, CategoryId = 5 },
                new Product { Id = 12, Name = "Butter", Price=3M, CategoryId = 5 },
                new Product { Id = 13, Name = "Cheese", Price=3.50M, CategoryId = 5 },
            };

            Customers = new List<Customer> {
                new Customer { Id = 1, FirstName = "Paul", LastName = "Mueller", Email = "Mueller@mail.com" },
                new Customer { Id = 2, FirstName = "Monica", LastName = "Faro", Email = "Alfaro@mail.com" },
                new Customer { Id = 3, FirstName = "Jeanette", LastName = "Stewart", Email = "Stewart@mail.com" },
                new Customer { Id = 4, FirstName = "Leslie", LastName = "Schneider", Email = "Schneider@mail.com" },
                new Customer { Id = 5, FirstName = "Victor ", LastName = "Mason", Email = "Mason@mail.com" },
                new Customer { Id = 6, FirstName = "Charles", LastName = "Wright", Email = "Wright@mail.com" },
                new Customer { Id = 7, FirstName = "Jamie", LastName = "Johnson", Email = "Johnson@mail.com" },
            };

            Orders = new List<Order>
            {
                new Order { Id = 1, Amount = 4, CustomerId = 1, ProductId =1 },
                new Order { Id = 2, Amount = 4, CustomerId = 1, ProductId =4 },
                new Order { Id = 2, Amount = 2, CustomerId = 1, ProductId =12 },

                new Order { Id = 3, Amount = 1, CustomerId = 2, ProductId =1 },
                new Order { Id = 3, Amount = 3, CustomerId = 2, ProductId =6 },
                new Order { Id = 3, Amount = 1, CustomerId = 2, ProductId =12 },

                new Order { Id = 4, Amount = 2, CustomerId = 3, ProductId =3 },
                new Order { Id = 5, Amount = 3, CustomerId = 3, ProductId =7 },
                new Order { Id = 6, Amount = 1,CustomerId = 3, ProductId =9 },
                new Order { Id = 6, Amount = 2, CustomerId = 3, ProductId =11 },

                new Order { Id = 7, Amount = 1,CustomerId = 4, ProductId =3 },
                new Order { Id = 8, Amount = 1, CustomerId = 4, ProductId =4 },
                new Order { Id = 8, Amount = 4, CustomerId = 4, ProductId =7 },

                new Order { Id = 9, Amount = 3, CustomerId = 5, ProductId =2 },
                new Order { Id = 9, Amount = 2, CustomerId = 5, ProductId =5 },
                new Order { Id = 10, Amount = 1, CustomerId = 5, ProductId =10 },

                new Order { Id = 10, Amount = 1, CustomerId = 6, ProductId =2 },
                new Order { Id = 10, Amount = 3, CustomerId = 6, ProductId =10 },
                new Order { Id = 10, Amount = 1, CustomerId = 6, ProductId =5 },
                new Order { Id = 10, Amount = 2, CustomerId = 6, ProductId =9 },
            };
        }
    }
}