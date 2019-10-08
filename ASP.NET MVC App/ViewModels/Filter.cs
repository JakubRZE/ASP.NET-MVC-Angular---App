using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_App.ViewModels
{
    public class Filter
    {
        public string SearchString { get; set; }
        public int? Category { get; set; }
        public decimal? DownPrice { get; set; }
        public decimal? UpPrice { get; set; }
    }
}