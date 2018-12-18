using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
        IRepository<Rent> context;
        IRepository<Car> cars;
        IRepository<Customer> customers;

        public RentsController(IRepository<Rent> rentContext, IRepository<Car> carContext, IRepository<Customer> customerContext)
        {
            this.context = rentContext;
            this.cars = carContext;
            this.customers = customerContext;
        }

        // GET: Rents
        public ActionResult Index()
        {
            List<Rent> rents = context.Collection().ToList();

            return View(rents);
        }

        public ActionResult Create()
        {
            Rent rent = new Rent();

            rent.Car = new Car();
            //rent.Customer = new Customer();

            return View(rent);
        }

        [HttpPost]
        public ActionResult Create(string id, Rent viewRent)
        {
            if (!ModelState.IsValid)
                return View();

            var carToRent = cars.Find(id);

            if (carToRent == null)
                return Content("Car not found!");

            var rent = new Rent();

            
            rent.Car = carToRent;
            rent.StartDate = viewRent.StartDate;
            rent.EndDate = viewRent.EndDate;

            var customer = customers.Collection().SingleOrDefault(c => c.Email == User.Identity.Name);

            if (customer == null)
                return Content("Customer not found!");

            rent.Customer = customer;

            context.Insert(rent);
           
            context.Commit();
            

            return RedirectToAction("Index","Rents");
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