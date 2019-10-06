using System.Web.Mvc;
using ASP.NET_MVC_App.Facade;
using ASP.NET_MVC_App.IRepositories;
using ASP.NET_MVC_App.Mocks;
using ASP.NET_MVC_App.Repositories;
using Unity;
using Unity.Injection;
using Unity.Mvc5;

namespace ASP.NET_MVC_App
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<MockContext>();

            container.RegisterType<ProductFacade>();
            container.RegisterType<CategoryFacade>();

            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<ICategoryRepository, CategoryRepository>();
            container.RegisterType<IOrderRepository, OrderRepository>();
            container.RegisterType<ICustomerRepository, CustomerRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}