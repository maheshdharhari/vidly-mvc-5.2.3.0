using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using System.Web.Mvc;
using VidlyAdmin.Models;

namespace VidlyAdmin.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }
        public ActionResult Details(int id)
        {
            var customers = GetCustomers().SingleOrDefault(c=>c.Id==id);
            if (customers == null)
                return HttpNotFound();
           
            return View(customers);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
        {
            new Customer{Id = 1, Name = "John Smith"},
            new Customer{Id = 2, Name = "Mary Williams"},

        };
        }
    }
}