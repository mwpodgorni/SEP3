using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Core.Models;

namespace CarRental.Core.ViewModels
{
    public class RentViewModel
    {
        public Customer Customer { get; set; }
        public Car Car { get; set; }
        public Rent Rent { get; set; }


    }
}
