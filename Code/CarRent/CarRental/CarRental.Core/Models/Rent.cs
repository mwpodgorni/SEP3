using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Core.Models
{
    public class Rent : BaseEntity
    {
        public Customer Customer { get; set; }
        public Car Car { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public decimal Price { get; set; }

        public double GetPrice()
        {
            return ((EndDate - StartDate).TotalHours) * (double)Car.Price;
        }

    }
}
