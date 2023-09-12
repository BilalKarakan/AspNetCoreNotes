using Microsoft.AspNetCore.Mvc;
using Mvc.Models;

namespace Mvc.ViewComponents
{
    public class EmployeeComponent:ViewComponent
    {
        public IViewComponentResult Invoke(string role="Default")
        {
            var list = EmployeeContext.employees;

            if (role == "Default")
                return View(list);
            else if (role == "Developer")
                return View("Developer", list);
            else
                return View("Manager", list);

        }
    }
}
