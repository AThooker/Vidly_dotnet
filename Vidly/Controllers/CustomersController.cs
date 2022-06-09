using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        //GET: Details
        public ActionResult Details(int? id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.ID == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        //Get customers helper method
        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer{ ID = 1, Name = "Tom"},
                new Customer{ ID = 2, Name = "Tim"}
            };

        }

    }
}