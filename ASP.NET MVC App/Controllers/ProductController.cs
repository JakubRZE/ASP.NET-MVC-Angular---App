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
        private readonly CategoryFacade _categoryFacade;

        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;

            _categoryFacade = new CategoryFacade(); // todo DI
        }

        // GET: Product
        public JsonResult Index()
        {
            var products = _productRepository.GetAllProducts();
            return Json(products, JsonRequestBehavior.AllowGet);
        }

        //// GET: Product/Details/5
        //public ActionResult Details(int id)
        //{
        //    var products = _categoryFacade.GetCategories();
        //    return View();
        //}

        //// GET: Product/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Product/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Product/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Product/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Product/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Product/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
