using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlueCinemaRentals.Models;
using BlueCinemaRentals.Services;

namespace BlueCinemaRentals.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var Movie = new MovieServices().GetAllMovies();
            return View(Movie);
        }

        // GET: Movies/Details/5
        public ActionResult Details(int Id)
        {
            return View();
        }

        // GET: Movies/Create
        //[HttpPost]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            // Create new Movie
            var movie = new Movie();
            UpdateModel(movie);
            var newMovie = new MovieServices().CreateMovie(movie);
            return RedirectToAction("Index");
        }



        // GET: Movies/Edit/5
        public ActionResult Edit(int Id)
        {
            return View();
        }

        // POST: Movies/Edit/5
        [HttpPost]
        public ActionResult Edit(int Id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int Id)
        {
            return View();
        }

        // POST: Movies/Delete/5
        [HttpPost]
        public ActionResult Delete(int Id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
