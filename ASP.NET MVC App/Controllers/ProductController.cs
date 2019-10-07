using ASP.NET_MVC_App.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_App.Controllers
{
    public class ProductController : Controller
    {
        private readonly BLLFacade _bllFacade;

        public ProductController(BLLFacade bllFacade)
        {
            _bllFacade = bllFacade;
        }

        // GET: Index
        public ActionResult Index()
        {
            return View();
        }


        // GET: Product/Products
        public JsonResult Products()
        {
            var products = _bllFacade.GetProductsList();
            return Json(products, JsonRequestBehavior.AllowGet);
        }

        //GET: Product/Orders/5
        public JsonResult Orders(int id)
        {
            var orders = _bllFacade.GetOrdersList(id);
            return Json(orders, JsonRequestBehavior.AllowGet);
        }
    }
}
