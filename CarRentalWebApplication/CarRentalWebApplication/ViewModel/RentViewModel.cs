using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarRentalWebApplication.Models;

namespace CarRentalWebApplication.ViewModel
{
    public class RentViewModel
    {
        public Car Car { get; internal set; }
        public Payment Payment { get; set; }
        public Customer Customer { get; set; }
    }
}