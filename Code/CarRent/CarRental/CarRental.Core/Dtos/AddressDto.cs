using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Core.Models;

namespace CarRental.Core.Dtos
{
    public class AddressDto : BaseEntity
    {
        [Required]
        public string Street { get; set; }
        [Required]
        public string House { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Postcode { get; set; }
        [Required]
        public string Country { get; set; }
    }
}
