using CarRental_R.Models;
using CarRental_R.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRental_R.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext _context;
        public EmployeeController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var car = new Car() { PlatesNumber = "Kli123" };
            var customers = new List<Customer>
            {
                new Customer() {IdNumber = "Customer 1"},
                new Customer() {IdNumber = "Customer 2"},
                new Customer() {IdNumber = "Customer 3"}
            };
            var viewModel = new RentViewModel
            {
                Car = car,
                Customers = customers
            };
            return View(viewModel);
        }
        public ActionResult SignIn()
        {
            return View();
        }
    }
}