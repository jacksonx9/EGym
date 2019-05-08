using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EGym.Models
{
    public class RentalType
    {
        public byte Id { get; set; }
        public double RentalFee { get; set; } // per minute
    }
}