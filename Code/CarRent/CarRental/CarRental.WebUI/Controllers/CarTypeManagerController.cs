using CarRental.Core.Contracts;
using CarRental.Core.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CarRental.WebUI.Controllers
{
    public class CarTypeManagerController : Controller
    {
        IRepository<CarType> context;

        public CarTypeManagerController(IRepository<CarType> context)
        {
            this.context = context;
        }

        public ActionResult Index()
        {
            List<CarType> carTypes = context.Collection().ToList();
            return View(carTypes);
        }

        public ActionResult Create()
        {
            CarType carType = new CarType();
            return View(carType);
        }

        [HttpPost]
        public ActionResult Create(CarType carType)
        {
            if (!ModelState.IsValid)
            {
                return View(carType);
            }
            else
            {
                context.Insert(carType);
                context.Commit();

                return RedirectToAction("Index");
            }

        }

        public ActionResult Edit(string Id)
        {
            CarType carType = context.Find(Id);
            if (carType == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(carType);
            }
        }

        [HttpPost]
        public ActionResult Edit(CarType carType, string Id)
        {
            CarType carTypeToEdit = context.Find(Id);

            if (carTypeToEdit == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    return View(carType);
                }

                carTypeToEdit.Type = carType.Type;

                context.Commit();

                return RedirectToAction("Index");
            }
        }

        public ActionResult Delete(string Id)
        {
            CarType carTypeToDelete = context.Find(Id);

            if (carTypeToDelete == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(carTypeToDelete);
            }
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(string Id)
        {
            CarType carTypeToEdit = context.Find(Id);

            if (carTypeToEdit == null)
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