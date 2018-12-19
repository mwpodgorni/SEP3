using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Core.Models;

namespace CarRental.Core.ViewModels
{
    public class RentViewModel
    {
        public Rent Rent { get; set; }
        public IEnumerable<Car> Cars { get; set; }
        public Customer Customer { get; set; }
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[Display(Name = "Start Date")]
        //public DateTimeOffset StartDate { get; set; }

        //[Display(Name = "End Date")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //public DateTimeOffset EndDate { get; set; }

        public RentViewModel()
        {
            Rent = new Rent();
            Customer = new Customer();
        }

    }
}
