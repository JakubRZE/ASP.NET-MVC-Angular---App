using ASP.NET_MVC_App.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET_MVC_App.Facade.Service;

namespace ASP.NET_MVC_App.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;
        private readonly OrderService _orderService;

        public ProductController(ProductService productService, OrderService orderService)
        {
            _productService = productService;
            _orderService = orderService;
        }

        // GET: Index
        public ActionResult Index()
        {
            return View();
        }


        // GET: Product/Products
        public JsonResult Products()
        {
            var products = _productService.GetProducts();
            return Json(products, JsonRequestBehavior.AllowGet);
        }

        //GET: Product/Orders/5
        public JsonResult Orders(int id)
        {
            var orders = _orderService.GetAllOrders(id);
            return Json(orders, JsonRequestBehavior.AllowGet);
        }

        //GET: Product/Categories
        public JsonResult Categories()
        {
            var categories = _productService.GetCategories();
            return Json(categories, JsonRequestBehavior.AllowGet);
        }
    }
}
