using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRental_R.Models
{
    public class Car : BaseEntity
    {
        public string PlatesNumber { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string FuelType { get; set; }
        public string GearBox { get; set; }
        public int EngineCapacity { get; set; }
        public string Model { get; set; }
        public int NumberOfDoors { get; set; }
    }

}