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
        [Required]
        public int Amount { get; set; }
        
        public Customer Customer { get; set; }
        
        public Product Product { get; set; }
    }
}