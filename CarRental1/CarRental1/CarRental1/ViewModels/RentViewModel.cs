using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarRental1.Models;

namespace CarRental1.ViewModels
{
    public class RentViewModel
    {
        public Car Car{ get; set; }
        public List<Customer> Customers { get; set; }
      //  public Payment Payment { get; set; }
    }
}