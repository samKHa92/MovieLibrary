using Microsoft.AspNetCore.Mvc;
using MovieLibraryWeb.Data;
using MovieLibraryWeb.Models;
using System;
using System.Collections.Generic;

namespace MovieLibraryWeb.Controllers
{
    public class DirectorController : Controller
    {

        private readonly ApplicationDbContext _db;
        public DirectorController(ApplicationDbContext db)
        {
            this._db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Director> objDirectorList = this._db.Directors;
            return View(objDirectorList);
        }
    }
}
