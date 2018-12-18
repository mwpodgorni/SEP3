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

            rent.Car = new Car();
            rent.Customer = context.Customers.SingleOrDefault(c => c.UserId == User.Identity.Name); ;

            return View(rent);
        }

        [HttpPost]
        public ActionResult Create(Car carToRent)
        {
            if (!ModelState.IsValid)
                return View();

            //var carToRent = context.Cars.SingleOrDefault(c => c.Id == carId);

            if (carToRent == null)
                return Content($"Car not found!");

            var rent = new Rent();

            rent.Car = carToRent;

            var customer = context.Customers.SingleOrDefault(c => c.UserId == User.Identity.Name);

            if (customer == null)
                return Content($"Customer not found!");

            rent.Customer = customer;

            context.Rents.Add(rent);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        //[HttpPost]
        //public ActionResult Create(Rent rent)
        //{
        //    if (!ModelState.IsValid)
        //        return View(rent);

        //    context.Rents.Add(rent);
        //    context.SaveChanges();

        //    return RedirectToAction("Index");
        //}


    }
}