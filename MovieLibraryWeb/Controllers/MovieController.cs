using Microsoft.AspNetCore.Mvc;
using MovieLibraryWeb.Data;
using MovieLibraryWeb.Models;
using System;
using System.Collections.Generic;

namespace MovieLibraryWeb.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _db;
        public MovieController(ApplicationDbContext db)
        {
            this._db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Movie> objMovieList = this._db.Movies;
            return View(objMovieList);
        }
    }
}
