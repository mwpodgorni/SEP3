using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Core.Models
{
    public class Car : BaseEntity
    {
        [MinLength(2,ErrorMessage = "Manufacturer name is too short!")]
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public string Color { get; set; }
        [DisplayName("Car Type")]
        public string Type { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

    }
}
