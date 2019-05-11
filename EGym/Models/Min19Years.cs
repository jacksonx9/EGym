using System;
using System.ComponentModel.DataAnnotations;

namespace EGym.Models
{
    public class Min19Years : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;

            if (customer.IsOver19)
                return ValidationResult.Success;

            return new ValidationResult("Sorry. You must be at least 19 years old to train at the EGym.");
        }
    }
}