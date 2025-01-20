using Microsoft.AspNetCore.Mvc;
using Moviewala.Models;
using Moviewala.ViewModels;

namespace Moviewala.Controllers
{
    public class MoviesController : Controller
    {
        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }
        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }
        public IActionResult Random()
        {
            var movie = new Movie { Name = "Sherk!" };

            /* Example of creating a ViewResult manually
               var viewResult = new ViewResult();
               viewResult.ViewData.Model = movie;
            */

            var customers = new List<Customer>
            {
                new Customer { Name = "customer 1" },
                new Customer { Name = "customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel); // Pass the viewModel to the view
        }

        // Example of returning content with a parameter
        public IActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // Attribute route for movies released by year and month
        [Route("movies/released/{year:int}/{month:regex(\\d{{2}})}")]
        public IActionResult ByReleaseDate(int year, string month)
        {
            // Convert month to integer if needed
            if (int.TryParse(month, out int monthValue))
            {
                return Content($"Year: {year}, Month: {monthValue:D2}"); // 'D2' ensures two-digit formatting
            }
            else
            {
                return BadRequest("Invalid month format.");
            }
        }
    }
}
