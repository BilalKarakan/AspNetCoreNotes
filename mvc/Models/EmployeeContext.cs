using System.Collections.Generic;

namespace Mvc.Models
{
    public static class EmployeeContext
    {
        public static List<Employee> employees = new()
        {
            new Employee() {Name = "Elizabeth Bennet", Salary = 20000},
            new Employee() {Name = "Fitzwilliam Darcy", Salary = 30000},
        };
    }
}
