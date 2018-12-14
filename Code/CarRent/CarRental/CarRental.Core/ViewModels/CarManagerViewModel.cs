using CarRental.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Core.ViewModels
{
    public class CarManagerViewModel
    {
        public Car Car { get; set; }
        public IEnumerable<CarType> CarTypes { get; set; } 
    }
}
