using CarRentalWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarRentalWebApplication.ViewModel;


namespace CarRentalWebApplication.Controllers
{
    public class EmployeeController : Controller
    {        

        public ActionResult Index()
        {
            var car = new Car() { PlatesNumber= "KLI14263" };
            var payment = new Payment() { Price = 23 };
            var customer = new Customer() { FirstName = "Jon" };

            var viewModel = new RentViewModel
            {
                Car = car,
                Payment = payment,
                Customer = customer
            };
            return View(viewModel);
        }

        public ActionResult SignIn()
        {
            return View();
        }
    }
}
