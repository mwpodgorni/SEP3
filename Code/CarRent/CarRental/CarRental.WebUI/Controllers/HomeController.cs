using CarRental.Core.Contracts;
using CarRental.Core.Models;
using CarRental.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRental.WebUI.Controllers
{
    public class HomeController : Controller
    {
        IRepository<Car> context;
        IRepository<CarType> carTypes;

        public HomeController(IRepository<Car> carContext, IRepository<CarType> carTypeContext)
        {
            context = carContext;
            carTypes = carTypeContext;
        }

        public ActionResult Index(string type = null)
        {
            List<Car> cars;
            var types = carTypes.Collection().ToList();
           
            if (type == null)
            {
                cars = context.Collection().ToList();
            }
            else
            {
                cars = context.Collection().Where(c => c.Type.Equals(type)).ToList();
            }

            var carListViewModel = new CarListViewModel();

            carListViewModel.Cars = cars;
            carListViewModel.CarTypes = types;

            return View(carListViewModel);
        }

        public ActionResult Details(string Id)
        {
            var car = context.Find(Id);

            if(car == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(car);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public ActionResult Rent(string Id)
        //{
        //    var carToRent = context.Find(Id);
        //    var rent = new Rent();



        //    if (carToRent == null)
        //        return Content($"Car not found!");

        //    return RedirectToAction("Create","Rents");
        //}
        public ActionResult Rent(string id)
        {
            return RedirectToAction("Create", "Rents");
        }
    }
}