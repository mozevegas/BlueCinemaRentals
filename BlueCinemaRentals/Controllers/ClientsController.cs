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

        // GET: Clients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clients/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            // Create new client
            var client = new Client();
            UpdateModel(client);
            var newClient = new ClientServices().CreateClient(client);
            return RedirectToAction("Index");
        }

    }
}