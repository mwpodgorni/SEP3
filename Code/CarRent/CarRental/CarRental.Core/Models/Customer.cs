using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Core.Models
{
    public class Customer : BaseEntity
    {
        public string UserId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public Address Address { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string AddressId { get; set; }


    }
}
