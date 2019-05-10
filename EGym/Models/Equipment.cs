using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EGym.Models
{
    public class Equipment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the equipment's name.")]
        [StringLength(30)]
        [Display(Name = "Equipment Name")]
        public string Name { get; set; }

        [StringLength(30)]
        [Display(Name = "Please Upload a Photo")]
        public string Photo { get; set; }

        [StringLength(255)]
        [Display(Name = "Description of Use")]
        public string Description { get; set; }

        // 1 if available and Sign Up button displayed and user ID otherwise
        public int Availability { get; set; } = 0;

        public RentalType RentalType { get; set; }

        [Required(ErrorMessage = "Please select an hourly rental fee.")]
        [Display(Name = "Rental Fee per Hour")]
        public byte RentalTypeId { get; set; }

        public Customer Customer { get; set; }

        public int CustomerId { get; set; }

        public static readonly byte Avaiable = 0;
    }
}