using CarRental.Core.Contracts;
using CarRental.Core.Models;
using CarRental.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRental.WebUI.Controllers
{
    public class CarManagerController : Controller
    {
        IRepository<Car> context;
        IRepository<CarType> carTypes;

        public CarManagerController(IRepository<Car> carContext, IRepository<CarType> carTypeContext)
        {
            context = carContext;
            carTypes = carTypeContext;
        }
        // GET: ProductManager
        public ActionResult Index()
        {
            List<Car> cars = context.Collection().ToList();
            return View(cars);
        }

        public ActionResult Create()
        {
            var viewModel = new CarManagerViewModel();

            viewModel.Car = new Car();
            viewModel.CarTypes = carTypes.Collection();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(Car car, HttpPostedFileBase file)
        {
            
            if (!ModelState.IsValid)
            {
                return Content("Model State is invalid!");
            }
            else
            {
                if (file!= null)
                {
                    car.Image = car.Id + Path.GetExtension(file.FileName);
                    file.SaveAs(Server.MapPath("//Context/CarImages//") + car.Image);
                }

                car.Name = $"{car.Manufacturer} {car.Model}";
                context.Insert(car);
                context.Commit();

                return RedirectToAction("Index");
            }

        }

        public ActionResult Details(string Id)
        {
            var car = context.Find(Id);

            if (car == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(car);
            }
        }

        public ActionResult Edit(string Id)
        {
            Car car = context.Find(Id);
            if (car == null)
            {
                return HttpNotFound();
            }
            else
            {
                CarManagerViewModel viewModel = new CarManagerViewModel();
                viewModel.Car = car;
                viewModel.CarTypes = carTypes.Collection();

                return View(viewModel);
            }
        }

        [HttpPost]
        public ActionResult Edit(Car car, string Id, HttpPostedFileBase file)
        {
            Car carToEdit = context.Find(Id);

            if (carToEdit == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                if (file != null)
                {
                    carToEdit.Image = car.Id + Path.GetExtension(file.FileName);
                    file.SaveAs(Server.MapPath("//Content/CarImages//") + carToEdit.Image);
                }

                carToEdit.Manufacturer = car.Manufacturer;
                carToEdit.Model = car.Model;
                carToEdit.ProductionYear = car.ProductionYear;
                carToEdit.Color = car.Color;
                carToEdit.Type = car.Type;
                carToEdit.PricePerDay = car.PricePerDay;
                carToEdit.Name = $"{car.Manufacturer} {car.Model}";

                context.Commit();

                return RedirectToAction("Index");
            }
        }

        public ActionResult Delete(string Id)
        {
            Car carToDelete = context.Find(Id);

            if (carToDelete == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(carToDelete);
            }
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(string Id)
        {
            Car carToDelete = context.Find(Id);

            if (carToDelete == null)
            {
                return HttpNotFound();
            }
            else
            {
                context.Delete(Id);
                context.Commit();
                return RedirectToAction("Index");
            }
        }
    }
}