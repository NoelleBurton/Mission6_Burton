using Microsoft.AspNetCore.Mvc;
using Mission6.Models;
using Mission6_Burton.Models;
using System.Diagnostics;

namespace Mission6_Burton.Controllers
{
    public class HomeController : Controller
    {

        private FilmContext _context;

        public HomeController(FilmContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddFilm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddFilm(AddFilm response)
        {
            _context.AddFilms.Add(response);
            _context.SaveChanges();

            return View("Response", response);
        }

    }
}
