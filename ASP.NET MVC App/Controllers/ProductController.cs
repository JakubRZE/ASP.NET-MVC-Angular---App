using ASP.NET_MVC_App.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET_MVC_App.IRepositories;

namespace ASP.NET_MVC_App.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductFacade _productFacade;

        public ProductController(ProductFacade productFacade)
        {
            _productFacade = productFacade;
        }

        // GET: Product
        public JsonResult Index()
        {
            var products = _productFacade.GetProducts();
            return Json(products, JsonRequestBehavior.AllowGet);
        }

        //GET: Product/Details/5
        public JsonResult Details(int id)
        {
            var product = _productFacade.ProductDetails(id);
            return Json(product, JsonRequestBehavior.AllowGet);
        }
    }
}
