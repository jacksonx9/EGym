using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace EGym.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        [Required]
        [StringLength(30)]
        public string EquipmentName { get; set; }
        public string EquipmentDescription { get; set; }
        // 0 if available and Sign Up button displayed and user ID otherwise
        public int Availability { get; set; } = 0;
        public RentalType RentalType { get; set; }
        public byte RentalTypeId { get; set; }
    }
}