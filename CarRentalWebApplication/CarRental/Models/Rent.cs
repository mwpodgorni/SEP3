using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sep3_C_
{
   public class Rent
    {
        [ForeignKey("Email")]
        public string Email { get; set; }
        [ForeignKey("Id")]
        public string PaymentID { get; set; }
        [ForeignKey("PlateNumber")]
        public string PlateNumber { get; set; }
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime DateOfRent { get; set; }
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime EndOfRent { get; set; }


        public Rent(string _Email, string _PaymentID, string _PlateNumber, DateTime _DateOfRent, DateTime _EndOfRent)
        {
            Email = _Email;
            PaymentID = _PaymentID;
            PlateNumber = _PlateNumber;
            DateOfRent = _DateOfRent;
            EndOfRent = _EndOfRent;
        }
        private Rent()
        {

        }
    }
}