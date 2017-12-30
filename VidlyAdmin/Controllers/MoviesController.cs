using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using VidlyAdmin.Models;
using VidlyAdmin.ViewModels;

namespace VidlyAdmin.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie
            {
                Name = "Shark!"
            };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };
            var viewModel = new RandomMovieViewModel();
            viewModel.Movie = movie;
            viewModel.Customers = customers;
            //ViewData["Movie"] = movie;
            return View(viewModel);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new {page = 1, sortBy = "Name"});
        }

        public ActionResult Edit(int id)
        {
            return Content("Id=" + id);
        }
        //Movies
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }
        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name = "Shrek"},
                new Movie {Id = 2, Name = "Wall-e"},

            };
        }
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByRealeaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}