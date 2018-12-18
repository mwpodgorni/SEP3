using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRental_R.Models
{
    public class MobilePay : Payment
    {
        public int PhoneNumber { get; set; }
    }
}