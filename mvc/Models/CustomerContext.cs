using Microsoft.Extensions.Configuration.EnvironmentVariables;
using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace Mvc.Models
{
    public class CustomerContext
    {
        /*
        public static List<Customer> customers = new List<Customer>()
        {
            new Customer
            {
                FirstName = "Enes",
                LastName = "Karakan",
                Age = 28
            },
            new Customer
            {
                FirstName = "Fatih",
                LastName = "Karakan",
                Age = 26
            },
            new Customer
            {
                FirstName = "Bilal",
                LastName = "Karakan",
                Age = 23
            },
            new Customer
            {
                FirstName = "Yusuf",
                LastName = "Karakan",
                Age = 21
            }

        };
        */

        //------------C# 9.0----------------

        public static List<Customer> Customers = new()
        {
            new Customer {Id = 1, FirstName = "Enes", LastName = "Karakan", Age = 28},
            new Customer {Id = 2, FirstName = "Fatih", LastName = "Karakan", Age = 26},
            new Customer {Id = 3, FirstName = "Bilal", LastName = "Karakan", Age = 24},
            new Customer {Id = 4, FirstName = "Yusuf", LastName = "Karakan", Age = 21},
        };
    }
}
