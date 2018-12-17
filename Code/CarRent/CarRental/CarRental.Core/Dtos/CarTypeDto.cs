using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Core.Models;

namespace CarRental.Core.Dtos
{
    public class CarTypeDto : BaseEntity
    {
        public string Type { get; set; }
    }
}
