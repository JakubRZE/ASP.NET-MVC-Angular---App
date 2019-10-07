using ASP.NET_MVC_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP.NET_MVC_App.ViewModels;

namespace ASP.NET_MVC_App.IRepositories
{
    public interface IProductRepository
    {
        IList<Product> GetAllProducts();
    }
}