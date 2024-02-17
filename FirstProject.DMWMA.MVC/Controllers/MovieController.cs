using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstProject.DMWMA.MVC.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstProject.DMWMA.MVC.Controllers
{
    public class MovieController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie{ Id=1, name="Name 1"},
                new Movie{ Id=2, name="Name 2"}
            };
            return View(movies);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null) NotFound();

            return Content("Id  "+ id);
        }
    }
}

