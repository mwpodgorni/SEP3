using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarRental.Core.Contracts;
using CarRental.Core.Models;
using CarRental.DataAccess.SQL;

namespace CarRental.WebUI.Controllers
{
    public class RentsController : Controller
    {
        private DataContext context;

        public RentsController()
        {
            this.context = new DataContext();
        }

        // GET: Rents
        public ActionResult Index()
        {
            List<Rent> rents = context.Rents.ToList();

            return View(rents);
        }

        public ActionResult Create()
        {
            Rent rent = new Rent();
            return View(rent);
        }

        [HttpPost]
        public ActionResult Create(Rent rent)
        {
            if (!ModelState.IsValid)
                return View(rent);

            context.Rents.Add(rent);
            context.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}