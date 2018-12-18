using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Core.Models
{
    public class Rent : BaseEntity
    {
        public Customer Customer { get; set; }
        public Car Car { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]
        public DateTimeOffset StartDate { get; set; }
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTimeOffset EndDate { get; set; }
        public decimal Price { get; set; }

        public double GetPrice()
        {
            return ((EndDate - StartDate).TotalHours) * (double)Car.PricePerDay;
        }

    }
}
