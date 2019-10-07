using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP.NET_MVC_App.Facade.Service;
using ASP.NET_MVC_App.IRepositories;
using ASP.NET_MVC_App.ViewModels;

namespace ASP.NET_MVC_App.Facade
{
    public class BLLFacade
    {
        private readonly ProductService _productService;
        private readonly OrderService _orderService;

        public BLLFacade(ProductService productService, OrderService orderService)
        {
            _productService = productService;
            _orderService = orderService;
        }

        public IList<ProductVM> GetProductsList()
        {
            return _productService.GetProducts();
        }

        public IList<OrderVM> GetOrdersList(int id)
        {
            return _orderService.GetAllOrders(id);
        }
    }
}