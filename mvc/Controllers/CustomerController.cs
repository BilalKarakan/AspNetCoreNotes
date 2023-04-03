using Microsoft.AspNetCore.Mvc;
using Mvc.Models;

namespace Mvc.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            Customer customer = new()
            {
                FirstName = "Bilal",
                LastName = "Karakan",
                Age = 24
            };
            //return RedirectToAction("example");
            return View(customer);
        }
        public IActionResult Index2()
        {
            return RedirectToAction("Index", "Home", new {@id = 1});
        }

        public IActionResult Example()
        {
            return View();
        }
    }
}
