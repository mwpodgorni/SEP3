using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Core.Models
{
    public class Car : BaseEntity
    {
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(20, MinimumLength = 2,ErrorMessage = "Name is too short!")]
        [Required]
        public string Manufacturer { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Name is too short!")]
        [Required]
        public string Model { get; set; }

        [Required]
        [Range(1885, int.MaxValue)]
        [DisplayName("Production Year")]
        public int ProductionYear { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Color name is too short!")]
        [Required]
        public string Color { get; set; }

        [DisplayName("Car Type")]
        [Required]
        public string Type { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [DisplayName("Rent Price")]
        public decimal PricePerDay { get; set; }

        //[Required]
        public string Image { get; set; }

    }
}
