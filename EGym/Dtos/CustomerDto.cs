using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EGym.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Sorry. You must be 19 years old in order to go to the EGym.")]
        public bool IsOver19 { get; set; }
    }
}