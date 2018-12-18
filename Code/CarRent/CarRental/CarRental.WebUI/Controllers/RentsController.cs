using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarRental.Core.Contracts;
using CarRental.Core.Models;
using CarRental.Core.ViewModels;
using CarRental.DataAccess.SQL;

namespace CarRental.WebUI.Controllers
{
    [Authorize]
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
            RentViewModel viewModel = new RentViewModel();
            
            viewModel.Rent = new Rent();
            //viewModel.Customer = customers.Collection().SingleOrDefault(c => c.Email.Equals(User.Identity.Name));
            viewModel.Cars = cars.Collection();

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(Rent rent)
        {
            //if (!ModelState.IsValid)
            //{
            //    return Content("Model State is invalid!");
            //}
            //else
            //{
                rent.Customer = customers.Collection().SingleOrDefault(c => c.Email.Equals(User.Identity.Name));
                context.Insert(rent);
            try
            {
                context.Commit();
            }
            catch (DbEntityValidationException e)
            {
                Console.WriteLine(e);
            }
            //}

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