using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieLibraryWeb.Data;
using MovieLibraryWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieLibraryWeb.Controllers
{
    public class ActorsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ActorsController(ApplicationDbContext db)
        {
            this._db = db;
        }

        [HttpGet("Actor/{id}")]
        public IActionResult Actor(int id)
        {
            Actor actor;
            using (this._db)
            {
                actor = this._db.Actors.Include(e => e.Movies).Where(e => e.Id == id).FirstOrDefault();
            }
            return View(actor);
        }

        [HttpGet("Actors/Filter")]
        public IActionResult Index(string name = "", string lastname = "", float ratingFrom = (float)0.0, float ratingTo = (float)10.0, string bornAfter = "1000-01-01", string bornBefore = "3000-01-1")
        {
            IEnumerable<Actor> objActorList = this._db.Actors;
            return View(objActorList.Where(e => e.Name.Contains(name) && e.Lastname.Contains(lastname) && e.Rating >= ratingFrom && e.Rating <= ratingTo));
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Actor obj)
        {
            if (ModelState.IsValid)
            {
                this._db.Actors.Add(obj);
                this._db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
                return NotFound();
            Actor actor = this._db.Actors.Find(id);
            if (actor == null)
                return NotFound();

            return View(actor);
        }

        [HttpPost]
        public IActionResult Edit(Actor obj)
        {
            this._db.Actors.Update(obj);
            this._db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Actor actor = this._db.Actors.Find(id);
            this._db.Actors.Remove(actor);
            this._db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
