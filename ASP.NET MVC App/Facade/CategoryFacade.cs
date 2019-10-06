using ASP.NET_MVC_App.Models;
using ASP.NET_MVC_App.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_App.Facade
{
    public class CategoryFacade
    {
        private CategoryRepository _categoryRepository { get; set; }

        public CategoryFacade()
        {
            _categoryRepository = new CategoryRepository();
        }

        public List<Category> GetCategories()
        {
            return _categoryRepository.GetCategories();
        }
    }
}