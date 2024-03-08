using Microsoft.AspNetCore.Mvc;
using Mvc_Movie_2.Models;


namespace Mvc_Movie_2.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public IActionResult Random()
        {
            var movie = new Movie() { Id = 1, Name = "Iron Man 2!" };
            return View(movie);
        }
    }
}
