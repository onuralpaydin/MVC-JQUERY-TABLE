using System.ComponentModel.DataAnnotations;

namespace TEST.CustomValidations
{
    public class FeetValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            int feetNumber = (int)value;
            if (value == null)
            {
                return new ValidationResult("Number of feet must be entered.");
            }
            if (!(feetNumber == 2 || feetNumber == 4 || feetNumber == 6 || feetNumber == 8))
            {
                return new ValidationResult("Invalid Number Of Feet.");
            }
            return ValidationResult.Success;
        }
    }
}
