using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP.NET_MVC_App.IRepositories;
using ASP.NET_MVC_App.ViewModels;

namespace ASP.NET_MVC_App.Facade.Service
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IList<OrderVM> GetAllOrders(int id)
        {
            var result = _orderRepository.GetAllOrders(id).Select(o =>
                new OrderVM
                {
                    Amount = o.Amount,
                    CustomerName = o.Customer.FirstName + " " + o.Customer.LastName,
                    CustomerEmail = o.Customer.Email
                }).ToList();

            return result;
        }
    }
}