using System;
using System.ComponentModel.DataAnnotations;

namespace sep3_C_
{
    public enum FuelType
    {
        Gasoline,
        Disel
    }
    public enum GearBox
    {
        Manual,
        Automatic
    }
   public class Car
    {
        [Key]
        public string PlateNumber { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string Colour { get; set; }
        [EnumDataType(typeof(FuelType))]
        [Required]
        public FuelType FuelType { get; set; }
        [EnumDataType(typeof(GearBox))]
        [Required]
        public GearBox GearBox { get; set; }
        [Range(0.9, 10, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        [Required]
        public double EngineCapacity { get; set; }
        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string Model { get; set; }
        [Range(0, 5, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        [Required]
        public int NumberOfDoors { get; set; }
        [Range(1, 20, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        [Required]
        public int NumberOfSeats { get; set; }

        public Car(string platenumber, string colour, int fueltype, int gearbox, double enginecapacity, string model, int numberofseats, int numberofdoors)
        {
            PlateNumber = platenumber;
            Colour = colour;
            FuelType = (FuelType)fueltype;
            GearBox = (GearBox)gearbox;
            EngineCapacity = enginecapacity;
            Model = model;
            NumberOfDoors = numberofdoors;
            NumberOfSeats = numberofseats;
        }
        private Car()
        {

        }
    }
}