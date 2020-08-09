using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Vidly.Models;
using Vidly.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: /<controller>/
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "End Game" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" },
                new Customer { Name = "Customer 3" }
            };
            var viewModel = new RandomMovieViewModels
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        public ActionResult Index(int? pageIndex, String sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        [Route("/movies/byreleasedate/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(string.Format("year={0}&month={1}", year, month));
        }
    }
}
