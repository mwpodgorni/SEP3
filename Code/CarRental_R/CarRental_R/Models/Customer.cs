using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRental_R.Models
{
    public class Customer : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DoB { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]

        public string Address { get; set; }
        [Required]

        public string PostCode { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public string DateOfIssue { get; set; }
        [Required]
        public string ExpiryDate{ get; set; }
        //public string Password { get; set; }
    }
}