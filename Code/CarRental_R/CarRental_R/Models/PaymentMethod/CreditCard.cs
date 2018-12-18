using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRental_R.Models
{
    public class CreditCard
    {
        public int CardNumber { get; set; }
        public int ExpiryMonth { get; set; }
        public int ExpiryYear { get; set; }
        public string FullName { get; set; }
        public int CVVNumber { get; set; }
    }
}