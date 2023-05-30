using Microsoft.AspNetCore.Mvc;

using Mvc.Models;
using System.Collections.Generic;
using System.Linq;

using System.Collections.Generic;


namespace Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // ViewBag, ViewData, TempData, Model

            /*
            Dictionary<string, object > dictionary = new();
            var list = dictionary.Values;
            */

            //var id = (string)RouteData.Values["id"];    

            var customers = CustomerContext.Customers.ToList();

            return View(customers);
            
        }

        public IActionResult Index2(int id)
        {
            return View();
        }

        public IActionResult Index3()
        {
            ViewBag.Name = "Edward Casaubon";
            ViewData["Name"] = "Dorothea Brooke";
            TempData["Name"] = "Will Ladislaw";


            ViewBag.Name = "Bilal";
            ViewData["Name"] = "Elif";
            TempData["Name"] = "Mehmet";

            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Customer());
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            /*
            var firstName = HttpContext.Request.Form["firstName"].ToString();
            var lastName = HttpContext.Request.Form["lastName"].ToString();
            var age = int.Parse(HttpContext.Request.Form["age"].ToString());
            */

            /*
            var lastCustomer = CustomerContext.Customers.Last();

            var id = lastCustomer.Id + 1;
            */

            Customer lastCustomer = null; 
            if (CustomerContext.Customers.Count>0)
            {
                lastCustomer = CustomerContext.Customers.Last();
            }

            customer.Id = 1;

            if (lastCustomer != null )
            {
                customer.Id = lastCustomer.Id + 1;
            }

            /*
            CustomerContext.Customers.Add(new Customer
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Age = age
            });
            */

            CustomerContext.Customers.Add(customer);

            //return RedirectToAction("Create");
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            //var id = int.Parse(RouteData.Values["id"].ToString());

            var removedCustomer = CustomerContext.Customers.Find(I => I.Id == id);
            CustomerContext.Customers.Remove(removedCustomer);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            //var id = int.Parse(RouteData.Values["id"].ToString());

            var updatedCustomer = CustomerContext.Customers.FirstOrDefault(x => x.Id == id);
            return View(updatedCustomer);
        }

        [HttpPost]
        public IActionResult Update(Customer customer)
        {
            //var id = int.Parse(HttpContext.Request.Form["id"].ToString());

            var updatedCustomer = CustomerContext.Customers.FirstOrDefault(I => I.Id == customer.Id);

            /*
            updatedCustomer.FirstName = HttpContext.Request.Form["firstName"].ToString();
            updatedCustomer.LastName = HttpContext.Request.Form["lastName"].ToString();
            updatedCustomer.Age = int.Parse(HttpContext.Request.Form["age"].ToString());
            */
            updatedCustomer.FirstName = customer.FirstName;
            updatedCustomer.LastName = customer.LastName;
            updatedCustomer.Age = customer.Age;

            return RedirectToAction("Index");
        }
    }
}
