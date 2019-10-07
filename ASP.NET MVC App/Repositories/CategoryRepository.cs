using ASP.NET_MVC_App.IRepositories;
using ASP.NET_MVC_App.Mocks;
using ASP.NET_MVC_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC_App.Repositories
{
    public class CategoryRepository: ICategoryRepository
    {
        public IList<Category> GetAllCategories()
        {
            throw new NotImplementedException();
        }
    }
}