using System;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: /<controller>/
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "End Game" };
            return View(movie);
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

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(string.Format("year={0}&month={1}", year, month));
        }
    }
}
