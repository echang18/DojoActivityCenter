using System;
using System.ComponentModel.DataAnnotations;

public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is DateTime)
        {
            if ((DateTime)value > DateTime.Now)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Must be a future date");
            }
        }
        else
        {
            return new ValidationResult("Not a valid date");
        }
    }
}