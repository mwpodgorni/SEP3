using CarRental_R.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRental_R.Controllers
{
    public class RegisteredCustomerController : Controller
    {
        private ApplicationDbContext _context;

        public RegisteredCustomerController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }



        public ActionResult Index()
        {
            var registeredCustomers = GetCustomers();
            return View(registeredCustomers);
        }
        public ActionResult Details(string idNumber)
        {
            var customer = _context.RegisteredCustomers.SingleOrDefault(c => c.IdNumber == idNumber);
            return View(customer);
        }
        public ActionResult SignIn()
        {
            return View();
        }
        private IEnumerable<RegisteredCustomer> GetCustomers()
        {
            return new List<RegisteredCustomer>
            {
                new RegisteredCustomer { IdNumber = "1", FirstName = "f", LastName = "L", Age = 20, Email = "21@gmail.com", Country = "Denmark",
                Address = "213", PostCode = "800", PhoneNumber = 123123, DateOfIssue = "23/21/2323", ExpiryDate = "32/32/2333", Password = "1231" }
        };
            
        }
    }
}