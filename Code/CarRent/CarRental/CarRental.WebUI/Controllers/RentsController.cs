using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRental.WebUI.Controllers
{
    public class RentsController : Controller
    {
        public RentsController()
        {

        }

        // GET: Rents
        public ActionResult Index()
        {
            return View();
        }
    }
}