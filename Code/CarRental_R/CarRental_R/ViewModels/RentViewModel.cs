using CarRental_R.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRental_R.ViewModels
{
    public class RentViewModel
    {
        public Car Car { get; set; }
        public List<Customer> Customers { get; set; }
        //  public Payment Payment { get; set; }
    }
}