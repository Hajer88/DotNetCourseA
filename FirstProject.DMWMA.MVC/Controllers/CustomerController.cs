using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstProject.DMWMA.MVC.Models;
using FirstProject.DMWMA.MVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstProject.DMWMA.MVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            Movie m = new Movie() { Id = 2, name = "Name1" };

            MovieCustomerVM moviecustomers =
                    new MovieCustomerVM()
                    {
                        movie = m,
                        customers = GetAll()
                    };
            return View(moviecustomers);
        }
        public IActionResult Details(int ?id)
        {
            var customer = GetAll()
                .FirstOrDefault(c => c.Id == id);
            return View(customer);

        }

        private List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>()
            {
            new Customer {Id=1, Name="Customer 1"},
            new Customer {Id= 2, Name="Customer 2"}
            };
            return customers;
        }
    }
}

