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

            var id = (string)RouteData.Values["id"];    


            ViewBag.Name = "Edward Casaubon";
            ViewData["Name"] = "Dorothea Brooke";
            TempData["Name"] = "Will Ladislaw";


            ViewBag.Name = "Bilal";
            ViewData["Name"] = "Elif";
            TempData["Name"] = "Mehmet";

            return View();
        }

        public IActionResult Index2(int id)
        {
            return View();
        }

        public IActionResult Index3()
        {
            var customers = CustomerContext.Customers;
            return View(customers);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateWithForm()
        {

            var firstName = HttpContext.Request.Form["firstName"].ToString();
            var lastName = HttpContext.Request.Form["lastName"].ToString();
            var age = int.Parse(HttpContext.Request.Form["age"].ToString());

            /*
            var lastCustomer = CustomerContext.Customers.Last();

            var id = lastCustomer.Id + 1;
            */

            Customer lastCustomer = null; 
            if (CustomerContext.Customers.Count>0)
            {
                lastCustomer = CustomerContext.Customers.Last();
            }

            int id = 1;
            if (lastCustomer != null )
            {
                id = lastCustomer.Id + 1;
            }

            CustomerContext.Customers.Add(new Customer
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Age = age
            });

            //return RedirectToAction("Create");
            return RedirectToAction("Index3");
        }

        [HttpGet]
        public IActionResult Remove()
        {
            var id = int.Parse(RouteData.Values["id"].ToString());
            var removedCustomer = CustomerContext.Customers.Find(I => I.Id == id);
            CustomerContext.Customers.Remove(removedCustomer);
            return RedirectToAction("Index3");
        }

        [HttpGet]
        public IActionResult Update()
        {
            var id = int.Parse(RouteData.Values["id"].ToString());
            return View();
        }
    }
}
