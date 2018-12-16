using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRental_R.Models
{
    public class RegisteredCustomer : Customer
    {
        [Required]
        public string Password { get; set; }
    }
}