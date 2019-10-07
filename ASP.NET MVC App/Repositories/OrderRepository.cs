using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP.NET_MVC_App.IRepositories;
using ASP.NET_MVC_App.Mocks;
using ASP.NET_MVC_App.Models;

namespace ASP.NET_MVC_App.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly MockContext _mockContext;

        public OrderRepository(MockContext mockContext)
        {
            _mockContext = mockContext;
        }

        public IList<Order> GetAllOrders(int id)
        {
            var result = (from order in _mockContext.Orders
                          join customer in _mockContext.Customers on order.CustomerId equals customer.Id
                          where order.ProductId == id
                          select new Order
                          {
                              Id = order.Id,
                              Amount = order.Amount,
                              Customer = customer,
                          }).ToList();
            return result;
        }
    }
}
