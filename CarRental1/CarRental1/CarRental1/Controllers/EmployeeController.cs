using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarRental1.Models;
using CarRental1.ViewModels;

namespace CarRental1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var car = new Car() {PlatesNumber = "Kli123"};
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