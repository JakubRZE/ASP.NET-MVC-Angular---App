using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP.NET_MVC_App.IRepositories;
using ASP.NET_MVC_App.Models;

namespace ASP.NET_MVC_App.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public IEnumerable<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }
    }
}