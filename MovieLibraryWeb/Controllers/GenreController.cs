using Microsoft.AspNetCore.Mvc;
using MovieLibraryWeb.Data;
using MovieLibraryWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieLibraryWeb.Controllers
{
    public class GenreController : Controller
    {
        private readonly ApplicationDbContext _db;

        public GenreController(ApplicationDbContext db)
        {
            this._db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Genre> objGenreList = this._db.Genres;
            return View(objGenreList);
        }
    }
}
