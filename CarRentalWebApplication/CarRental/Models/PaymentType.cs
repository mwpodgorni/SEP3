using System;
using System.ComponentModel.DataAnnotations;

namespace sep3_C_
{
    public enum PaymentType
    {
        MobilePay, Cash, CreditCard, BankTransfer
    }
    public class PaymentMethod
    {
        [Key]
        public string Id { get; set; }
        [Display(Name = "Date Of Payment")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOfpayment { get; set; }
        [DataType(DataType.Currency)]
        [Required]
        public double Amount { get; set; }
        [EnumDataType(typeof(PaymentType))]
        [Required]
        public PaymentType _type;
        public PaymentMethod(string _Id, DateTime _DateOfpayment, double _Amount, int typeOfpayment)
        {
            Id = _Id;
            DateOfpayment = _DateOfpayment;
            Amount = _Amount;
            _type = (PaymentType)typeOfpayment;

        }
        private PaymentMethod()
        {

        }
    }
}