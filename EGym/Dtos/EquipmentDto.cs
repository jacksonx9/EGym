using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EGym.Dtos
{
    public class EquipmentDto
    {
        public int Id { get; set; } = 0;

        [Required(ErrorMessage = "Please enter the equipment's name.")]
        [StringLength(30)]
        [Display(Name = "Equipment Name")]
        public string Name { get; set; }

        [StringLength(30)]
        public string Photo { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        // 1 if available and Sign Up button displayed and user ID otherwise
        public int Availability { get; set; } = 0;

        public RentalTypeDto RentalType { get; set; }

        [Required(ErrorMessage = "Please select an hourly rental fee.")]
        public byte RentalTypeId { get; set; }

        public CustomerDto Customer { get; set; }

        public int CustomerId { get; set; }

        public static readonly byte Avaiable = 0;
    }
}