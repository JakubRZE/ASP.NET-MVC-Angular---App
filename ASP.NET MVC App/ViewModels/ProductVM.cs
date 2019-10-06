using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ASP.NET_MVC_App.Models;

namespace ASP.NET_MVC_App.ViewModels
{
    public class ProductVM
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

        public int OrdersCount { get; set; }
    }
}