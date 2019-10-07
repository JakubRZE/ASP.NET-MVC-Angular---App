using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ASP.NET_MVC_App.Models;

namespace ASP.NET_MVC_App.ViewModels
{
    public class OrderVM
    {
        public int Amount { get; set; }
        
        public string CustomerName { get; set; }

        public string CustomerEmail { get; set; }
    }
}