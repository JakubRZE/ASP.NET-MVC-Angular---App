using ASP.NET_MVC_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_App.IRepositories
{
    public interface IOrderRepository
    {
        IList<Order> GetAllOrders(int id);
    }
}