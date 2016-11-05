using Padam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Padam.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> customers = new List<Customer> {
            new Customer { ID = 1, Name = "Arju Mikisawa",City="Tokyo" },
            new Customer { ID = 2, Name = "Bammy Tondo", City="Harare" }
        };

        // GET: Customers
        public ActionResult Index()
        {
            return View("CustomersIndex", customers);
        }

        //GET: Customers/Details/{id}
        public ActionResult Details(int id)
        {
            var customer = customers.FirstOrDefault(c => c.ID == id);
            if (customer != null)
                return View("CustomerDetails", customer);
            else
                return HttpNotFound("Kanavillai!");
        }

    }
}