using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlueCinemaRentals.Models;
using BlueCinemaRentals.Services;

namespace BlueCinemaRentals.Controllers
{
    public class RentalsController : Controller
    {
        // GET: Rentals
        public ActionResult Index()
        {
            var Rentals = new RentalServices().GetAllRentals();
            return View(Rentals);
        }
    }
}