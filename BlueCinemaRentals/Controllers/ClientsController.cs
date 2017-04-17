using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlueCinemaRentals.Models;
using BlueCinemaRentals.Services;

namespace BlueCinemaRentals.Controllers
{
    public class ClientsController : Controller
    {
        // GET: Clients
        public ActionResult Index()
        {
            var Client = new ClientServices().GetAllClients();
            return View(Client);
        }
    }
}